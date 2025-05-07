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
            string role = LoginHelpers.currentuser.getRole().getLookupValue();
            if (role == "customer")
            {
                Application.Run(new CustomerDashboardForm());
            }
            MessageBox.Show("Login successful but your program has stuck behn chod!");


        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username= this.TxtUsername.Text;
            string password= this.TxtPassword.Text;
            string email = this.guna2TextBox1.Text;
            LoginHelpers.currentuser = UserDL.UserLogin(username, email, password);
            SelectNextInterface();
        }
    }
}
