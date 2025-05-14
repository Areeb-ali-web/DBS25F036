using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class DesignApproval : UserControl
    {
        private List<OrderBL> orders;
        private OrderBL currentOrder;

        public DesignApproval()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadFormData();
            txtCustomerName.Text = LoginHelpers.currentuser.UserName;
            dvgOrders.CellDoubleClick += DvgOrders_CellDoubleClick;
            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;
        }

        private void ConfigureDataGridView()
        {
            // Enable double buffering to reduce flickering
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dvgOrders, new object[] { true });

            dvgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgOrders.MultiSelect = false;
            dvgOrders.AutoGenerateColumns = false;
            dvgOrders.BackgroundColor = Color.SkyBlue;

            // Alternating rows style
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(185, 226, 218)
            };
            dvgOrders.AlternatingRowsDefaultCellStyle = altStyle;

            // Header style
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(22, 160, 133),
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };
            dvgOrders.ColumnHeadersDefaultCellStyle = headerStyle;
            dvgOrders.ColumnHeadersHeight = 4;
            dvgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Add custom columns
            dvgOrders.Columns.Clear();
            dvgOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderID",
                HeaderText = "Order ID",
                DataPropertyName = "OrderID",
                Width = 80
            });
            dvgOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                HeaderText = "Order Date",
                DataPropertyName = "OrderDate",
                Width = 100
            });
            dvgOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Total Amount",
                DataPropertyName = "TotalAmount",
                Width = 100,
                DefaultCellStyle = { Format = "C2" }
            });
            dvgOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DesignDescription",
                HeaderText = "Design Description",
                DataPropertyName = "DesignDescription",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Hidden column for DesignFile
            dvgOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DesignFile",
                HeaderText = "Design File",
                DataPropertyName = "DesignFile",
                Visible = false
            });
        }

        private void LoadFormData()
        {
            int customerId = LoginHelpers.currentcustomer.UserID;
            orders = OrderDL.LoadOrdersForApprovalByCustomerId(customerId);

            var dt = new DataTable();
            dt.Columns.Add("OrderID", typeof(int));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("TotalAmount", typeof(decimal));
            dt.Columns.Add("DesignDescription", typeof(string));
            dt.Columns.Add("DesignFile", typeof(string)); // Hidden for image path

            foreach (var order in orders)
            {
                List<DesignBL> d= DesignDL.LoadDesignsByOrderId(order.OrderID);
                string designFile = d[0].DesignFile;
                dt.Rows.Add(order.OrderID, order.OrderDate, order.TotalAmount, order.DesignDescription, designFile);
            }

            dvgOrders.DataSource = dt;
        }

        private void DvgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dvgOrders.RowCount) return;

            try
            {
                var row = dvgOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                currentOrder = orders.FirstOrDefault(o => o.OrderID == orderId);
                currentOrder = OrderDL.LoadOrderByOrderId(currentOrder.OrderID);
                if (currentOrder == null) return;

                txtCustomerName.Text = LoginHelpers.currentcustomer.UserName;
                txtProduct.Text = currentOrder.ToString();
                txtQuantity.Text = $"Total Items: {currentOrder.OrderDetails?.Sum(od => od.Quantity) ?? 0}";
                txtDescription.Text = currentOrder.DesignDescription;

                // ✅ Use DataRowView to safely access hidden column
                var dataRowView = row.DataBoundItem as DataRowView;
                string imagePath = dataRowView?["DesignFile"]?.ToString();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    picDesign.Image = Image.FromFile(imagePath);
                    MessageBox.Show("behchod immage nai a rahi");
                }
                else
                {
                    picDesign.Image = null;
                    MessageBox.Show("Design string khali ha", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
            {
                MessageBox.Show("Please select an order first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "manufactured");
                DesignDL.UpdateDesignApprovalStatusByOrderId(currentOrder.OrderID, 22);
                MessageBox.Show("Order approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error approving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
            {
                MessageBox.Show("Please select an order first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "being_designed");
                DesignDL.UpdateDesignApprovalStatusByOrderId(currentOrder.OrderID, 23);
                MessageBox.Show("Order rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rejecting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional empty event handlers (if unused, you can remove these)
        private void panelHeader_Paint(object sender, PaintEventArgs e) { }
        private void dvgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelHeader_Paint_1(object sender, PaintEventArgs e) { }
        private void btnApprove_Click_1(object sender, EventArgs e) { }
        private void dvgOrders_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void panelImage_Paint(object sender, PaintEventArgs e) { }
        private void DesignApproval_Load(object sender, EventArgs e) { }
        private void dvgOrders_CellContentClick_2(object sender, DataGridViewCellEventArgs e) { }
        private void btnReject_Click_1(object sender, EventArgs e) { }

        private void btnApprove_Click_2(object sender, EventArgs e)
        {

        }
    }
}
