using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ManageProducts : UserControl
    {
        private List<ProductBL> productsList;
        private ProductBL currentProduct;

        public ManageProducts()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadProducts();
            ConfigureDataGridView();
            ClearFields();
        }

        private void LoadProducts()
        {
            try
            {
                productsList = ProductDL.LoadProducts();
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Clear existing columns
            dgvProducts.Columns.Clear();

            // Add columns
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "ProductID",
                Width = 80
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colFabricType",
                HeaderText = "Fabric Type",
                DataPropertyName = "FabricType",
                Width = 150
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDescription",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 250
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colPrice",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 100
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colQuantity",
                HeaderText = "Quantity",
                DataPropertyName = "QuantityInStock",
                Width = 100
            });
        }

        private void RefreshDataGridView()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productsList;
        }

        private void ClearFields()
        {
            txtProductName.Text = "";
            cmbFabricType.SelectedIndex = -1;
            txtDescription.Text = "";
            nudQuantity.Value = nudQuantity.Minimum;
            txtPrice.Text = "";
            currentProduct = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name is required", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbFabricType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a fabric type", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Description is required", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid positive price", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new product
                var newProduct = new ProductBL(
                    txtProductName.Text,
                    cmbFabricType.SelectedItem + ": " + txtDescription.Text, // Combine fabric type and description
                    price,
                    (int)nudQuantity.Value
                );

                // Add to database (you'll need to implement ProductDL.AddProduct)
                // ProductDL.AddProduct(newProduct);

                // For now, just add to our list
                newProduct.ProductID = productsList.Count + 1;
                productsList.Add(newProduct);

                RefreshDataGridView();
                ClearFields();

                MessageBox.Show("Product added successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name is required", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbFabricType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a fabric type", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Description is required", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid positive price", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update product
                currentProduct.setname(txtProductName.Text);
                currentProduct.Description = cmbFabricType.SelectedItem + ": " + txtDescription.Text;
                currentProduct.setprice(price);
                currentProduct.setQuantity((int)nudQuantity.Value);

                // Update in database
                ProductDL.UpdateProductPriceByID(currentProduct.ProductID, price);
                ProductDL.UpdateProductStockByID(currentProduct.ProductID, (int)nudQuantity.Value);

                RefreshDataGridView();
                ClearFields();

                MessageBox.Show("Product updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Instead of deleting, set quantity to 0 (soft delete)
                    ProductDL.UpdateProductStockByID(currentProduct.ProductID, 0);

                    // Remove from our list
                    productsList.Remove(currentProduct);

                    RefreshDataGridView();
                    ClearFields();

                    MessageBox.Show("Product quantity set to 0 (marked as deleted)", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                currentProduct = (ProductBL)dgvProducts.SelectedRows[0].DataBoundItem;
                DisplayProductDetails(currentProduct);
            }
        }

        private void DisplayProductDetails(ProductBL product)
        {
            txtProductName.Text = product.getProductName();

            // Extract fabric type from description (format: "FabricType: Description")
            var descriptionParts = product.Description.Split(new[] { ": " }, 2, StringSplitOptions.None);
            if (descriptionParts.Length == 2)
            {
                cmbFabricType.SelectedItem = descriptionParts[0];
                txtDescription.Text = descriptionParts[1];
            }
            else
            {
                cmbFabricType.SelectedIndex = -1;
                txtDescription.Text = product.Description;
            }

            txtPrice.Text = product.getPrice().ToString();
            nudQuantity.Value = product.getStocks();
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
   
        
    }
}