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
    public partial class DesignApproval : UserControl
    {
        public DesignApproval()
        {
            InitializeComponent();
        }
        private void loadformdate()
        {
            // Load the data into the DataGridView
            dvgOrders.DataSource = OrderDL.LoadOrdersByCustomerId(LoginHelpers.currentuser.getUserID());
            dvgOrders.Columns["orderID"].HeaderText = "Order ID";
            dvgOrders.Columns["customerID"].HeaderText = "Customer ID";
            dvgOrders.Columns["orderDate"].HeaderText = "Order Date";
            dvgOrders.Columns["totalAmount"].HeaderText = "Total Amount";
            dvgOrders.Columns["status"].HeaderText = "Status";
            // Set the DataGridView to read-only mode
            dvgOrders.ReadOnly = true;
        }
        private void dvgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
