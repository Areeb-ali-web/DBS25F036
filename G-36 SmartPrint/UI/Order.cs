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

namespace G_36_SmartPrint.UI
{
    public partial class Order : UserControl
    {
        List<Order_DetailsBL> oders = new List<Order_DetailsBL> ();

        public Order()
        {
            InitializeComponent();
            CheckOut checkOutControl = new CheckOut();
            this.Controls.Add(checkOutControl);
            checkOutControl.BringToFront();
            checkOutControl.CenterOnScreen(this);
            cbProduct.DataSource = ProductDL.LoadProducts();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";


             // Hide the Product column
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
           



            txtCustomerName.Text = LoginHelpers.currentuser.getUserName();

            string productname = cbProduct.Text;
            string quantity = txtQuantity.Text;
            int Quantity = Convert.ToInt32(quantity);
            int productID = Convert.ToInt32(cbProduct.SelectedValue);
            ProductBL product = ProductDL.GetProductById(productID);
            Order_DetailsBL order = new Order_DetailsBL(product, Quantity);
            oders.Add(order);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
