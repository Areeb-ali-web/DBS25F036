using System;
using System.Windows.Forms;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.UI
{
    public partial class CustomerBoard : UserControl
    {
        public CustomerBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            LoadCustomerWelcome();
        }

        private void LoadCustomerWelcome()
        {
            try
            {
                string customerName = LoginHelpers.currentuser?.getUserName() ?? "Customer";

                // Set the welcome message
                lblWelcome.Text = $"WELCOME {customerName.ToUpper()}!";

                // Replace the placeholder in appreciation label
                string htmlContent = lblAppreciation.Text;
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    htmlContent = htmlContent.Replace("Dear Customer,", $"Dear {customerName},");
                    lblAppreciation.Text = htmlContent;
                }
            }
            catch (Exception ex)
            {
                lblWelcome.Text = "WELCOME!";
                MessageBox.Show("Error loading welcome message: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            // Optional click handler
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Optional header paint handler
        }
    }
}
