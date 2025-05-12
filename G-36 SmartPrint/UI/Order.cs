using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class Order : UserControl
    {
        private List<Order_DetailsBL> orders = new List<Order_DetailsBL>();

        public Order()
        {
            InitializeComponent();

            // Initialize controls
            CheckOut checkOutControl = new CheckOut();
            this.Controls.Add(checkOutControl);
            checkOutControl.BringToFront();
            checkOutControl.CenterOnScreen(this);

            // Load products
            cbProduct.DataSource = ProductDL.LoadProducts();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Width = 100
            });
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustomerName.Text = LoginHelpers.currentuser.getUserName();

                string quantityText = txtQuantity.Text.Trim();
                if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbProduct.SelectedItem is ProductBL product)
                {
                    Order_DetailsBL order = new Order_DetailsBL(product, quantity);
                    orders.Add(order);
                    RefreshCart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            var displayList = new List<dynamic>();

            foreach (var order in orders)
            {
                displayList.Add(new
                {
                    ProductName = order.getproduct().ProductName,
                    Quantity = order.getQuantity()
                });
            }

            dgvCart.DataSource = displayList;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
