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

            dvgOrders.CellDoubleClick += DvgOrders_CellDoubleClick;
        }
<<<<<<< HEAD
=======
<<<<<<< Updated upstream
=======
>>>>>>> Project

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
        }

        private void LoadFormData()
        {
            try
            {
                int customerId = LoginHelpers.currentcustomer.getUserID();
                orders = OrderDL.LoadOrdersForApprovalByCustomerId(customerId);

                var dt = new DataTable();
                dt.Columns.Add("OrderID", typeof(int));
                dt.Columns.Add("OrderDate", typeof(DateTime));
                dt.Columns.Add("TotalAmount", typeof(decimal));
                dt.Columns.Add("DesignDescription", typeof(string));
                dt.Columns.Add("DesignFile", typeof(string)); // For image preview (hidden)

                foreach (var order in orders)
                {
                    string designFile = order.designs?.FirstOrDefault()?.designFile ?? string.Empty;
                    dt.Rows.Add(order.getOrderID(), order.getOrderDate(), order.gettotalAmount(), order.getDesignDescription(),designFile);
                }

                dvgOrders.DataSource = dt;
                //dvgOrders.Columns["DesignFile"].Visible = false; // Optional hidden column
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DvgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dvgOrders.RowCount) return;

            try
            {
                var row = dvgOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                currentOrder = orders.FirstOrDefault(o => o.getOrderID() == orderId);
                currentOrder = OrderDL.LoadOrderByOrderId(currentOrder.getOrderID());
                if (currentOrder == null) return;

                txtCustomerName.Text = LoginHelpers.currentcustomer.getUserName();
                txtProduct.Text = currentOrder.allOrders();
                txtQuantity.Text = $"Total Items: {currentOrder.getOrderDetails()?.Sum(od => od.getQuantity()) ?? 0}";
                txtDescription.Text = currentOrder.getDesignDescription();

                string imagePath = row.Cells["DesignFile"].ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    picDesign.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picDesign.Image = null;
                    MessageBox.Show("Design image not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
<<<<<<< HEAD
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Approved");
                MessageBox.Show("Order approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
=======
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "manufactured");
                DesignDL.UpdateDesignApprovalStatusByOrderId(currentOrder.getOrderID(),22);
                MessageBox.Show("Order approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

>>>>>>> Project
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
<<<<<<< HEAD
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Rejected");
=======
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "being_designed");
                DesignDL.UpdateDesignApprovalStatusByOrderId(currentOrder.getOrderID(), 23);
>>>>>>> Project
                MessageBox.Show("Order rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rejecting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        private void dvgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelHeader_Paint_1(object sender, PaintEventArgs e) { }
<<<<<<< HEAD
=======

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
>>>>>>> Project
    }
}
