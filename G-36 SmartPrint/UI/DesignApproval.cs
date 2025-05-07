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
        }

        private void ConfigureDataGridView()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dvgOrders, new object[] { true });

            dvgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgOrders.MultiSelect = false;
            dvgOrders.CellDoubleClick += DvgOrders_CellDoubleClick;
        }

        private void LoadFormData()
        {
            try
            {
                int customerId = LoginHelpers.currentcustomer.getUserID();
                orders = OrderDL.LoadOrdersForApprovalByCustomerId(customerId);

                DataTable dt = new DataTable();
                dt.Columns.Add("OrderID", typeof(int));
                dt.Columns.Add("TotalAmount", typeof(decimal));
                dt.Columns.Add("DesignDescription", typeof(string));
                dt.Columns.Add("DesignFile", typeof(string)); // For image loading

                foreach (var order in orders)
                {
                    string designFile = order.designs?.FirstOrDefault()?.designFile ?? string.Empty;
                    dt.Rows.Add(order.getOrderID(), order.gettotalAmount(), order.getDesignDescription(), designFile);
                }

                // ✅ First bind the DataTable
                dvgOrders.DataSource = dt;

                // ✅ Then format the columns safely
                //if (dvgOrders.Columns["OrderID"] != null)
                //    dvgOrders.Columns["OrderID"].HeaderText = "Order ID";

                //if (dvgOrders.Columns["TotalAmount"] != null)
                //{
                //    dvgOrders.Columns["TotalAmount"].HeaderText = "Total Amount";
                //    dvgOrders.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                //}

                //if (dvgOrders.Columns["DesignDescription"] != null)
                //    dvgOrders.Columns["DesignDescription"].HeaderText = "Design Description";

                //if (dvgOrders.Columns["DesignFile"] != null)
                    //dvgOrders.Columns["DesignFile"].Visible = false;
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
                if (currentOrder == null) return;

                txtCustomerName.Text = LoginHelpers.currentcustomer.getUserName();
                txtProduct.Text = currentOrder.allOrders();
                txtQuantity.Text = $"Total Items: {currentOrder.getOrderDetails()?.Sum(od => od.getQuantity()) ?? 0}";
                txtDescription.Text = currentOrder.getDesignDescription();

                string imagePath = row.Cells["DesignFile"].Value?.ToString();
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
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Approved");
                MessageBox.Show("Order approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData(); // Refresh list
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
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Rejected");
                MessageBox.Show("Order rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData(); // Refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rejecting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom header styling
        }

        private void dvgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reserved for future enhancements
        }
    }
}
