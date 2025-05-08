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
            
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            CheckOut checkOutControl = new CheckOut();
            this.Controls.Add(checkOutControl); 
            checkOutControl.BringToFront(); 
            checkOutControl.CenterOnScreen(this);
            cbProduct.DataSource = ProductDL.LoadProducts();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";


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
            guna2DataGridView1.DataSource = oders;
            guna2DataGridView1.Columns["Product"].HeaderText = "Product Name";
            guna2DataGridView1.Columns["Product"].DisplayIndex = 0;
            guna2DataGridView1.Columns["Quantity"].HeaderText = "Quantity";
            guna2DataGridView1.Columns["Quantity"].DisplayIndex = 1;
            guna2DataGridView1.Columns["Product"].Width = 200;
            guna2DataGridView1.Columns["Quantity"].Width = 100;
            guna2DataGridView1.Columns["Product"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            guna2DataGridView1.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            guna2DataGridView1.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          
        }
    }
}
