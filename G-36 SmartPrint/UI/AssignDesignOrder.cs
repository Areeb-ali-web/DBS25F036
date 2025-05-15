using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class AssignDesignOrder : UserControl
    {
        public AssignDesignOrder()
        {
            InitializeComponent();
            LoadDesigners();
            LoadOrders();
            LoadDesignOrders();
            cmbOrder.SelectedIndexChanged += cmbOrder_SelectedIndexChanged;

        }

        private void LoadDesigners()
        {
            try
            {
                List<EmployeesBL> designers = EmployeeDL.LoadEmployeesByPosition(4); // 4 = Designer

                cmbDesigner.DataSource = designers;
                cmbDesigner.DisplayMember = "UserName";
                cmbDesigner.ValueMember = "EmployeeID";

                if (designers.Count > 0)
                {
                    cmbDesigner.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No designers available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading designers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrders()
        {
            try
            {
                List<OrderBL> orders = OrderDL.LoadOrdersByStatus("waiting");

                cmbOrder.DataSource = orders;
                cmbOrder.DisplayMember = "OrderID";
                cmbOrder.ValueMember = "OrderID";

                if (orders.Count > 0)
                {
                    cmbOrder.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No orders available for assignment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDesignOrders()
        {
            try
            {
                List<OrderBL> orders = OrderDL.LoadOrdersByStatus("waiting");

                dgvDesignOrders.Rows.Clear();
                dgvDesignOrders.Columns.Clear();

                // Add columns
                dgvDesignOrders.Columns.Add("OrderID", "Order ID");
                dgvDesignOrders.Columns.Add("Amount", "Amount");
                dgvDesignOrders.Columns.Add("DesignDescription", "Design Description");
                dgvDesignOrders.Columns.Add("Products", "Products");
                dgvDesignOrders.Columns.Add("Status", "Status");
                dgvDesignOrders.Columns.Add("OrderDate", "Order Date");

                // Format columns
                dgvDesignOrders.Columns["Amount"].DefaultCellStyle.Format = "C";
                dgvDesignOrders.Columns["OrderDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

                // Add rows
                foreach (var order in orders)
                {
                    dgvDesignOrders.Rows.Add(
                        order.OrderID,
                        order.TotalAmount,
                        order.DesignDescription,
                        order.ToString(),
                        order.OrderStatus?.LookupValue ?? "Unknown",
                        order.OrderDate
                    );
                }

                // Auto-size columns
                foreach (DataGridViewColumn column in dgvDesignOrders.Columns)
                {
                    //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetProductsString(List<ProductBL> products)
        {
            if (products == null || products.Count == 0)
                return "No products";

            return string.Join(", ", products.Select(p => p.ProductName));
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrder.SelectedItem is OrderBL selectedOrder)
                {
                    OrderBL order = (OrderBL)cmbOrder.SelectedItem;
                    order= OrderDL.LoadOrderByOrderId(order.OrderID);
                    txtDesignDescription.Text = order.DesignDescription ?? "No description available";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDesigner.SelectedItem == null)
                {
                    MessageBox.Show("Please select a designer.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbOrder.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbDesigner.SelectedItem is EmployeesBL designer &&
                    cmbOrder.SelectedItem is OrderBL order)
                {
                    // Call InsertDesign from DesignDL
                     DesignDL.InsertDesign(order.OrderID, designer.EmployeeID);
                    bool success = true;
                    if (success)
                    {
                        MessageBox.Show("Design task assigned successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDesignOrders(); // Refresh table
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign design task.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning design: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesignerViewSalary_Load(object sender, EventArgs e)
        {
            // Already loading data in constructor
        }

        private void dgvDesignOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Painting logic if needed
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Painting logic if needed
        }
    }
}