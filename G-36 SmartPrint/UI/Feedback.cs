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
            LoginHelpers.currentcustomer = new CustomersBL(LoginHelpers.currentuser);

            //if (LoginHelpers.currentcustomer == null)
            //{
            //    MessageBox.Show("Current user is not a customer.");
            //    return;
            //}

            // Load and bind customer details
            txtCustomerName.Text = LoginHelpers.currentuser.UserName;
            txtCustomerName.Enabled = false;

            txtEmail.Text = LoginHelpers.currentcustomer.Email;
            dtpFeedbackDate.Value = DateTime.Now;

            // Load orders for this customer
            LoginHelpers.currentcustomer.setOrders(OrderDL.LoadOrdersByCustomerId(LoginHelpers.currentcustomer.UserID));

            // Bind orders to combobox
            var orderDisplayList = LoginHelpers.currentcustomer.GetOrders().Select(o => new
            {
                OrderID = o.OrderID,
                Display = $"Order #{o.OrderID} - {o.OrderDate:yyyy-MM-dd} - Total: {o.TotalAmount:C}"
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
            int customerID=LoginHelpers.currentcustomer.UserID;
            DateTime feedbackdate = DateTime.Now;
            string comment = txtComments.Text;
            string order = (cbOrder).SelectedValue.ToString();
            int orderID = Convert.ToInt32(order);
            int rating =(int)numRating.Value;

            FeedbackDL.AddFeedback(orderID,customerID,rating,comment);
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
             
        }
    }
}
