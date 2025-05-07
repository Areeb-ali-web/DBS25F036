using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class Feedback : UserControl
    {
        public Feedback()
        {
            InitializeComponent();
            InitializeFeedbackForm();
        }

        private void InitializeFeedbackForm()
        {
            // Set current customer from logged-in user
            LoginHelpers.currentcustomer = LoginHelpers.currentuser as CustomersBL;

            if (LoginHelpers.currentcustomer == null)
            {
                MessageBox.Show("Current user is not a customer.");
                return;
            }

            // Load and bind customer details
            txtCustomerName.Text = LoginHelpers.currentcustomer.getUserName();
            txtCustomerName.Enabled = false;

            guna2TextBox1.Text = LoginHelpers.currentcustomer.getEmail();
            dtpFeedbackDate.Value = DateTime.Now;

            // Load orders for this customer
            LoginHelpers.currentcustomer.orders = OrderDL.LoadOrdersByCustomerId(LoginHelpers.currentcustomer.getUserID());

            // Bind orders to combobox
            var orderDisplayList = LoginHelpers.currentcustomer.orders.Select(o => new
            {
                OrderID = o.getOrderID(),
                Display = $"Order #{o.getOrderID()} - {o.getOrderDate():yyyy-MM-dd} - Total: {o.gettotalamount():C}"
            }).ToList();

            cbOrder.DataSource = orderDisplayList;
            cbOrder.DisplayMember = "Display";
            cbOrder.ValueMember = "OrderID";
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            // Optional: any custom painting logic
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int customerID=LoginHelpers.currentcustomer.getUserID();
            DateTime feedbackdate = DateTime.Now;
            string comment = txtComments.Text;
            string order = (cbOrder).SelectedValue.ToString();
            int orderID = Convert.ToInt32(order);
            int rating = Convert.ToInt32(numRating);

            FeedbackDL.AddFeedback(orderID,customerID,rating,comment);
        }
    }
}
