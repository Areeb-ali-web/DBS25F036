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
            //Order OrderControl = new Order();
            //this.Controls.Add(OrderControl);
            //OrderControl.BringToFront();
            txtCustomerName.Text = LoginHelpers.currentuser.UserName;
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
                Width = 50
            });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 150
            });
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustomerName.Text = LoginHelpers.currentuser.UserName;

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
                    ProductName = order.Product.ProductName,
                    Quantity = order.Quantity,
                    Description = order.Product.Description
                });
            }

            dgvCart.DataSource = displayList;
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            orders.Clear();
            RefreshCart();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Check checkOut = new Check();
            checkOut.Show();
            OrderBL order = new OrderBL() { };
            order.OrderDetails=(orders);
            LoginHelpers.currentcustomer.GetOrders().Add(order);
            LoginHelpers.order = order;
        }
    }
}
