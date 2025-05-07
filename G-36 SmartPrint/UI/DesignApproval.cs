using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadFormData();
            ConfigureDataGridView();
        }
        private void LoadFormData()
        {
            try
            {
                // Get current customer ID from login helper
                int customerId = LoginHelpers.currentcustomer.getUserID();

                // Load orders for approval
                orders = OrderDL.LoadOrdersForApprovalByCustomerId(customerId);

                // Create a DataTable with only the columns we want to display
                DataTable dt = new DataTable();
                dt.Columns.Add("OrderID", typeof(int));
                dt.Columns.Add("TotalAmount", typeof(decimal));
                dt.Columns.Add("DesignDescription", typeof(string));
                dt.Columns.Add("DesignFile", typeof(string)); // Hidden column for image path

                // Populate the DataTable
                foreach (var order in orders)
                {
                    string designFile = order.designs?.FirstOrDefault()?.designFile ?? string.Empty;
                    dt.Rows.Add(
                        order.getOrderID(),
                        order.gettotalAmount(),
                        order.getDesignDescription(),
                        designFile
                    );
                }

                // Bind to DataGridView
                dvgOrders.DataSource = dt;

                // Format columns
                dvgOrders.Columns["OrderID"].HeaderText = "Order ID";
                dvgOrders.Columns["TotalAmount"].HeaderText = "Total Amount";
                dvgOrders.Columns["DesignDescription"].HeaderText = "Design Description";

                // Hide the DesignFile column (we'll use it but not show it)
                dvgOrders.Columns["DesignFile"].Visible = false;

                // Format currency column
                dvgOrders.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
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
                // Get the selected row data
                DataGridViewRow row = dvgOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);

                // Find the complete order from our original list
                currentOrder = orders.FirstOrDefault(o => o.getOrderID() == orderId);
                if (currentOrder == null) return;

                // Load customer info (from login helper)
                txtCustomerName.Text = LoginHelpers.currentcustomer.getUserName();

                // Load product info
                txtProduct.Text = currentOrder.allOrders();

                // Load quantity and total amount
                int totalQuantity = currentOrder.getOrderDetails()?.Sum(od => od.getQuantity()) ?? 0;
                txtQuantity.Text = $"Total Items: {totalQuantity}";

                // Load description
                txtDescription.Text = currentOrder.getDesignDescription();

                // Load design image
                string imagePath = row.Cells["DesignFile"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    picDesign.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picDesign.Image = null;
                    MessageBox.Show("Design image not found", "Warning",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            // Enable double buffering for better performance
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dvgOrders, new object[] { true });

            // Set selection mode
            dvgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgOrders.MultiSelect = false;

            // Handle double click event
            dvgOrders.CellDoubleClick += DvgOrders_CellDoubleClick;
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
                // Update order status to approved
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Approved");
                MessageBox.Show("Order approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData(); // Refresh the list
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
                // Update order status to rejected
                OrderDL.ChangeOrderStatusByName(currentOrder.getOrderID(), "Rejected");
                MessageBox.Show("Order rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData(); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rejecting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any specific cell content clicks if needed
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting for header if needed
        }
    }
}