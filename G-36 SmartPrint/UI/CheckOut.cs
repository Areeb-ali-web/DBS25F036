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
using G_36_SmartPrint.DL;
using Org.BouncyCastle.Bcpg;

namespace G_36_SmartPrint.UI
{
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
            txtPayment.Text = "50000";
            btnBuy.Click += btnBuy_Click;
        }

       
        public void CenterOnScreen(Control parent)
        {
            this.Location = new Point(
                (parent.ClientSize.Width - this.Width) / 2,
                (parent.ClientSize.Height - this.Height) / 2);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
               int userid = LoginHelpers.currentuser.UserID;
                string addressdetail = txtAddress.Text;
                string state = txtState.Text;
                string country = txtCountry.Text;
                string postalcode = "5200";
                string city = txtCity.Text; 
                AddressBL addressBL = new AddressBL(addressdetail,city,state,postalcode,country);
                AddressDL.AddAddressIfNotExists(userid,addressBL);
                int addressid = AddressDL.GetAddressIdFromAddress(addressBL);
                addressBL.AddressID = addressid;
                string designdescription =txtDesignDescription.Text;
                LoginHelpers.order.DesignDescription = (designdescription);
                LoginHelpers.order.DeliveryAddress = (addressBL);
                OrderDL.AddOrder(LoginHelpers.order);

                //Order_PaymentBL op = new


            }
            catch 
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();


        }
    }
}