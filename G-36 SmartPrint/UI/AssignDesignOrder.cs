using System;
using System.Collections.Generic;
using System.Data;
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
        }

        private void LoadDesigners()
        {
            List<EmployeesBL> list = EmployeeDL.LoadEmployeesByPosition(4); // 4 = Designer
            cmbDesigner.DataSource = list;
            cmbDesigner.DisplayMember = "UserName";
            cmbDesigner.ValueMember = "Employeeid";
            if (list.Count > 0) cmbDesigner.SelectedIndex = 0;
        }

        private void LoadOrders()
        {
            List<OrderBL> orders = OrderDL.LoadOrdersByStatus("manufactured");
            cmbOrder.DataSource = orders;
            cmbOrder.DisplayMember = "OrderID";
            cmbOrder.ValueMember = "OrderID";
            if (orders.Count > 0) cmbOrder.SelectedIndex = 0;
        }

        private void DesignerViewSalary_Load(object sender, EventArgs e)
        {
            LoadDesignOrders();
        }

        private void LoadDesignOrders()
        {
            try
            {
                List<OrderBL> orders = OrderDL.LoadOrdersByStatus("pending");

                dgvDesignOrders.Rows.Clear();
                dgvDesignOrders.Columns.Clear();

                dgvDesignOrders.Columns.Add("OrderID", "Order ID");
                dgvDesignOrders.Columns.Add("Amount", "Amount");
                dgvDesignOrders.Columns.Add("DessignDescription", "Design Description");
                dgvDesignOrders.Columns.Add("Products", "Products");
                dgvDesignOrders.Columns.Add("Status", "Status");
                dgvDesignOrders.Columns.Add("OrderDate", "Order Date");

                foreach (var order in orders)
                {
                    dgvDesignOrders.Rows.Add(
                        order.OrderID,
                        order.TotalAmount.ToString("C"),
                        order.DesignDescription,
                        order.ToString(),
                        order.OrderStatus?.LookupValue?? "Unknown",
                        order.OrderDate.ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedItem is OrderBL selectedOrder)
            {
                txtDesignDescription.Text = selectedOrder.DesignDescription;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDesigner.SelectedItem is EmployeesBL designer && cmbOrder.SelectedItem is OrderBL order)
                {
                    // Call InsertDesign from DesignDL
                    DesignDL.InsertDesign(order.OrderID, designer.EmployeeID);

                    MessageBox.Show("Design task assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDesignOrders(); // Refresh table
                }
                else
                {
                    MessageBox.Show("Please select both a designer and an order.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning design:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDesignOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
