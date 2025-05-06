using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class ForgotPassword : UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            string email  = TxtEmail.Text;
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            UserDL.UpdateUserPassword(username,email,password);
        }
    }
}
