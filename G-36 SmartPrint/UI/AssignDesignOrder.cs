using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<EmployeesBL> list = EmployeeDL.LoadEmployeesByPosition(4);
            cmbDesigner.Items.Clear();
            cmbDesigner.DataSource = list;
            cmbDesigner.DisplayMember = "userName";
            cmbDesigner.SelectedIndex = 0;
            cmbDesigner.ValueMember = "Employeeid";
        }
        private void DesignerViewSalary_Load(object sender, EventArgs e)
        {
            LoadDesignerSalaries();

        }
        private void LoadDesignerSalaries()
        {
            try
            {





                // ✅ FIX: Confirm method LoadSalariesByEmployeeId exists and returns a list
                List<OrderBL> orders = OrderDL.LoadOrdersByStatus("pending");

                dgvDesignOrders.Rows.Clear();
                dgvDesignOrders.Columns.Clear();

                dgvDesignOrders.Columns.Add("OrderID", "Order ID");
                dgvDesignOrders.Columns.Add("Amount", "Amount");
                dgvDesignOrders.Columns.Add("DessignDescription", "DesignDescription");
                dgvDesignOrders.Columns.Add("Products", "Products");
                dgvDesignOrders.Columns.Add("Status", "Status");
                dgvDesignOrders.Columns.Add("orderDate", "OrderDate");

                foreach (var order in orders)
                {
                    dgvDesignOrders.Rows.Add(
                        order.getOrderID(),
                        order.gettotalAmount().ToString("C"), // Currency formatting based on system locale
                        order.getDesignDescription(),
                        order.allOrders(),
                        order.getOrderStatus()?.getLookupValue() ?? "Unknown", // ✅ NULL check
                        order.getOrderDate().ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDesignOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
