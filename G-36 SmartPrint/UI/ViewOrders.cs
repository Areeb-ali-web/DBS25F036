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
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
            txtCustomerName.Text =LoginHelpers.currentuser.UserName;

            this.Load += DesignerViewSalary_Load;
        }

        private void DesignerViewSalary_Load(object sender, EventArgs e)
        {
            LoadDesignerSalaries();

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadDesignerSalaries()
        {
            try
            {



                int customerid= LoginHelpers.currentcustomer.UserID;

                // ✅ FIX: Confirm method LoadSalariesByEmployeeId exists and returns a list
                List<OrderBL> orders = OrderDL.LoadOrdersByCustomerId(customerid);

                dgvCustomerOrders.Rows.Clear();
                dgvCustomerOrders.Columns.Clear();

                dgvCustomerOrders.Columns.Add("OrderID", "Order ID");
                dgvCustomerOrders.Columns.Add("Amount", "Amount");
                dgvCustomerOrders.Columns.Add("DessignDescription", "DesignDescription");
                dgvCustomerOrders.Columns.Add("Products", "Products");
                dgvCustomerOrders.Columns.Add("Status", "Status");
                dgvCustomerOrders.Columns.Add("orderDate", "OrderDate");

                foreach (var order in orders)
                {
                    dgvCustomerOrders.Rows.Add(
                        order.OrderID,
                        order.TotalAmount.ToString("C"), // Currency formatting based on system locale
                        order.DesignDescription,
                        order.ToString(),
                        order.OrderStatus?.LookupValue ?? "Unknown", // ✅ NULL check
                        order.OrderDate.ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomerOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
