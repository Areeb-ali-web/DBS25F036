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
using G_36_SmartPrint.DAL;

namespace G_36_SmartPrint.UI
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string username = TxtNewUsername.Text;
            string password = TxtPassword.Text;
            string name = TxtName.Text;
            string email = TxtEmail.Text;
            UserBL userBL = new UserBL(username,password,email,name);
            UserDL.UserSignIN(username,password,email,name,2);
        }

        private void TxtNewUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
