using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;

namespace G_36_SmartPrint.UI
{
    public partial class Login : UserControl
    {
        UserBL currentuser;
        public LinkLabel ForgotPasswordLink { get; private set; }
        public Login()
        {
            InitializeComponent();

            ForgotPasswordLink = linkForgot;
        }
       
        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void SelectNextInterface()
        {
            string role = currentuser.getRole().getLookupValue();
            if(role == "customer")
            {
<<<<<<< Updated upstream
                Application.Run(new CustomerDashboardForm());
=======
                MessageBox.Show("Invalid user role. Cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int role = LoginHelpers.currentuser.getRole().getLookupID();

            if (role == 2) // Customer
            {
                LoginHelpers.currentcustomer = new CustomersBL(LoginHelpers.currentuser);

                MessageBox.Show($"Login successful.\nUsername: {LoginHelpers.currentuser.getUserName()}\nUserID: {LoginHelpers.currentuser.getUserID()}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CustomerDashboardForm form = new CustomerDashboardForm();
                form.Show();
                Form parentForm = this.FindForm();
                if (parentForm != null) parentForm.Hide(); // Hide parent form
            }
            if(role == 19)
            {
                MessageBox.Show($"Login successful.\nUsername: {LoginHelpers.currentuser.getUserName()}\nUserID: {LoginHelpers.currentuser.getUserID()}",
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int employeeid = (int)EmployeeDL.GetEmployeeIDByUserID(LoginHelpers.currentuser.getuserID());

                LoginHelpers.currentEmployee = EmployeeDL.LoadEmployeeById(employeeid);
                if (LoginHelpers.currentEmployee.GetPosition().getLookupValue() == "manager")
                { 
                    ManagerDashboardForm form = new ManagerDashboardForm();
                    form.Show();
                    Form parentForm = this.FindForm();
                    if (parentForm != null) parentForm.Hide();
                }
                else if(LoginHelpers.currentEmployee.GetPosition().getLookupValue() == "designer")
                {
                    DesignerDashbordForm form = new DesignerDashbordForm();
                    form.Show();
                    Form parentForm = this.FindForm();
                    if (parentForm != null) parentForm.Hide();
                }
                else if(LoginHelpers.currentEmployee.GetPosition().getLookupValue() == "Delivery")
                {
                    DeliverymanDashboardForm form = new DeliverymanDashboardForm();
                    form.Show();
                    Form parentForm = this.FindForm();
                    if (parentForm != null) parentForm.Hide();
                }
            }
            else
            {
                MessageBox.Show("Role not supported yet.");
>>>>>>> Stashed changes
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username= this.TxtUsername.Text;
            string password= this.TxtPassword.Text;
            string email = this.guna2TextBox1.Text;
            currentuser = UserDL.UserLogin(username, email, password);
            
        }
    }
}
