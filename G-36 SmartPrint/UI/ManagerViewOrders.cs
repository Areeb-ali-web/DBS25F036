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
using Mysqlx.Datatypes;

namespace G_36_SmartPrint.UI
{
    public partial class ManagerViewOrders : UserControl
    {
        public ManagerViewOrders()
        {
            InitializeComponent();
            this.Load += DesignerViewSalary_Load;
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
                List<OrderBL> orders = OrderDL.LoadAllOrders();

                dgvRequests.Rows.Clear();
                dgvRequests.Columns.Clear();

                dgvRequests.Columns.Add("OrderID", "Order ID");
                dgvRequests.Columns.Add("Amount", "Amount");
                dgvRequests.Columns.Add("DessignDescription", "DesignDescription");
                dgvRequests.Columns.Add("Products", "Products");
                dgvRequests.Columns.Add("Status", "Status");
                dgvRequests.Columns.Add("orderDate", "OrderDate");

                foreach (var order in orders)
                {
                    dgvRequests.Rows.Add(
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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
