using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Management;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class CustomerBoard : UserControl
    {
        private string connectionString = "Your_Database_Connection_String";
        private int customerId;

        public CustomerBoard(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadCustomerData();
            SetContentTexts();
        }

        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT FirstName, LastName FROM Customers WHERE CustomerId = @CustomerId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                lblWelcome.Text = $"WELCOME {firstName} {lastName}!";
                            }
                            else
                            {
                                lblWelcome.Text = "WELCOME!";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblWelcome.Text = "WELCOME!";
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetContentTexts()
        {
            string customerName = lblWelcome.Text.Replace("WELCOME ", "").Replace("!", "");
            bool hasName = !string.IsNullOrEmpty(customerName) && customerName != "WELCOME";

            lblAppreciation.Text = (hasName ? $"Dear {customerName}," : "Welcome!") + "\n\n" +
                "We sincerely appreciate you choosing SmartPrint for your custom apparel needs. " +
                "Your trust in our services motivates our team to deliver:\n" +
                "• Premium quality garments\n" +
                "• Flawless design execution\n" +
                "• Exceptional customer care\n" +
                "• Fast turnaround times";

            var companyText = new System.Text.StringBuilder();
            companyText.AppendLine("About SmartPrint Clothing Co.");
            companyText.AppendLine();
            companyText.AppendLine("Since 2010, we've specialized in:");
            companyText.AppendLine("✓ High-end custom apparel printing");
            companyText.AppendLine("✓ Sustainable production methods");
            companyText.AppendLine("✓ Small batch and bulk orders");
            companyText.AppendLine("✓ Wholesale programs for businesses");
            companyText.AppendLine();
            companyText.AppendLine("All products come with our quality guarantee.");
            lblCompany.Text = companyText.ToString();

            lblServices.Text = "Customer Support Services\n\n" +
                "We offer comprehensive support:\n" +
                "• Design Assistance: design@smartprint.com\n" +
                "• Order Support: orders@smartprint.com\n" +
                "• Phone: (800) 555-SMART (Mon-Fri 9AM-6PM EST)\n" +
                "• Live Chat: Available on our website\n\n" +
                "Average response time: < 2 hours";

            lblDesign.Text = "Design Services & Capabilities\n\n" +
                "Our design studio offers:\n" +
                "• Free initial design consultation\n" +
                "• Vector artwork conversion ($25 value free with orders)\n" +
                "• 3D mockups of your designs\n" +
                "• Pantone color matching system\n" +
                "• Unlimited revisions until you're satisfied";

            FormatLabel(lblAppreciation);
            FormatLabel(lblCompany);
            FormatLabel(lblServices);
            FormatLabel(lblDesign);
        }

        private void FormatLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 11);
            label.Margin = new Padding(0, 0, 0, 30);
            label.Padding = new Padding(5);
        }
        public void UpdateWelcomeMessage(string firstName, string lastName)
        {
            lblWelcome.Text = $"WELCOME {firstName} {lastName}!";
        }
    }
}