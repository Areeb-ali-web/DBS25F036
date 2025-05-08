using System;
using System.Data.SqlClient;
using System.Drawing;
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
            LoadCustomerData(LoginHelpers.currentuser.getuserID());
            this.DoubleBuffered = true;
        }

        private void LoadCustomerData(int customerid)
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
                                UpdateWelcomeMessage(firstName, lastName);
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

        public void UpdateWelcomeMessage(string firstName, string lastName)
        {
            lblWelcome.Text = $"WELCOME {firstName} {lastName}!";

            string htmlContent = lblAppreciation.Text;
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                string customerName = $"{firstName} {lastName}";
                htmlContent = htmlContent.Replace("Dear Customer,", $"Dear {customerName},");
                lblAppreciation.Text = htmlContent;
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}