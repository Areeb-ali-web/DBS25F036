using System;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;

namespace G_36_SmartPrint.UI
{
    public partial class Login : UserControl
    {
        public LinkLabel ForgotPasswordLink { get; private set; }

        public Login()
        {
            InitializeComponent();
            ForgotPasswordLink = linkForgot;
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Future implementation for forgot password
            MessageBox.Show("Password recovery not yet implemented.");
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
            if (LoginHelpers.currentuser == null || LoginHelpers.currentuser.getRole() == null)
            {



                Application.Run(new CustomerDashboardForm());


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



            if (role == 18) // Customer
            {
                int employeeid = (int)EmployeeDL.GetEmployeeIDByUserID(LoginHelpers.currentuser.getuserID());
                LoginHelpers.currentEmployee = EmployeeDL.LoadEmployeeById(employeeid);
                if (LoginHelpers.currentEmployee != null)
                {
                    if (LoginHelpers.currentEmployee.getposition().getLookupValue() == "manager")
                    {

                        ManagerDashboardForm form = new ManagerDashboardForm();
                        form.Show();
                    }
                    else if (LoginHelpers.currentEmployee.getposition().getLookupValue() == "delivery")
                    {

                        DeliverymanDashboardForm form = new DeliverymanDashboardForm();
                        form.Show();
                    }
                    else if (LoginHelpers.currentEmployee.getposition().getLookupValue() == "designer")
                    {

                        DesignerDashbordForm form = new DesignerDashbordForm();
                        form.Show();
                    }

                }


                Form parentForm = this.FindForm();
                MessageBox.Show($"Login successful.\nUsername: {LoginHelpers.currentuser.getUserName()}\nUserID: {LoginHelpers.currentuser.getUserID()}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (parentForm != null) parentForm.Hide(); // Hide parent form
            }
            if (role == 1)
            {
                AdminDashboardForm form = new AdminDashboardForm();
                form.Show();
                Form parentForm = this.FindForm();
                MessageBox.Show($"Login successful.\nUsername: {LoginHelpers.currentuser.getUserName()}\nUserID: {LoginHelpers.currentuser.getUserID()}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (parentForm != null) parentForm.Hide();

            }


            else
            {
                MessageBox.Show("Role not supported yet.");

                if (role == 19)
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
                    else if (LoginHelpers.currentEmployee.GetPosition().getLookupValue() == "designer")
                    {
                        DesignerDashbordForm form = new DesignerDashbordForm();
                        form.Show();
                        Form parentForm = this.FindForm();
                        if (parentForm != null) parentForm.Hide();
                    }
                    else if (LoginHelpers.currentEmployee.GetPosition().getLookupValue() == "Delivery")
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


                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text;
            string email = guna2TextBox1.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all login fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginHelpers.currentuser = UserDL.UserLogin(username, email, password);

            if (LoginHelpers.currentuser != null && LoginHelpers.currentuser.getRole() != null)
            {
                SelectNextInterface();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username, email, and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
