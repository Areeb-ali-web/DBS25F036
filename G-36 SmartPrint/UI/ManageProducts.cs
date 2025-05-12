using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

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
            // Add double-click event handler
            dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;

        }

        private void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks and out-of-range clicks
            if (e.RowIndex < 0 || e.RowIndex >= dgvProducts.Rows.Count)
                return;

            // Get the selected product
            currentProduct = (ProductBL)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            DisplayProductDetails(currentProduct);

            // Optional: Highlight the selected row
            dgvProducts.ClearSelection();
            dgvProducts.Rows[e.RowIndex].Selected = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
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
                Width = 80,
                Visible = false // Hide the ID column as requested
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
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "C2" // Format as currency
                }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colQuantity",
                HeaderText = "Quantity",
                DataPropertyName = "QuantityInStock",
                Width = 100
            });

            // Make the grid look better
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void RefreshDataGridView()
        {
            dgvProducts.DataSource = null;
            productsList = ProductDL.LoadProducts();
            dgvProducts.DataSource = productsList;
        }

        private void ClearFields()
        {
            txtProductName.Text = "";
            cmbFabricType.SelectedIndex = -1;
            txtDescription.Text = "";
            nudQuantity.Text = "";
            txtPrice.Text = "";
            currentProduct = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                // Create new product
                var newProduct = new ProductBL(
                    txtProductName.Text,
                    cmbFabricType.SelectedItem + ": " + txtDescription.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(nudQuantity.Text)
                );

                // Add to database
                ProductDL.AddProduct(newProduct);
                newProduct.ProductID = 00;

                // Add to our list
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

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbFabricType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fabric type", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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
                if (!ValidateInputs())
                    return;

                // Update product
                currentProduct.setname(txtProductName.Text);
                currentProduct.Description = cmbFabricType.SelectedItem + ": " + txtDescription.Text;
                currentProduct.setprice(decimal.Parse(txtPrice.Text));
                int quantity = int.Parse(nudQuantity.Text.ToString());
                currentProduct.setQuantity(quantity);

                // Update in database
                ProductDL.UpdateProductPrice(currentProduct.ProductName, currentProduct.price);
                ProductDL.UpdateProductStock(currentProduct.ProductName, currentProduct.quantityInStock);


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
                    // Delete from database
                    if (ProductDL.DeleteProduct(currentProduct.ProductID))
                    {
                        RefreshDataGridView();
                        ClearFields();
                    }

                    // Remove from our list
                    productsList.Remove(currentProduct);

                    RefreshDataGridView();
                    ClearFields();

                    MessageBox.Show("Product deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productsList.Remove(currentProduct);

                    RefreshDataGridView();
                    ClearFields();
                }
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                currentProduct = (ProductBL)dgvProducts.SelectedRows[0].DataBoundItem;
                DisplayProductDetails(currentProduct);
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
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

            txtPrice.Text = product.getPrice().ToString("0.00");
            nudQuantity.Text = product.getStocks().ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!ValidateInputs())
                    return;

                // Update product
                currentProduct.setname(txtProductName.Text);
                currentProduct.Description = cmbFabricType.SelectedItem + ": " + txtDescription.Text;
                currentProduct.setprice(decimal.Parse(txtPrice.Text));
                int quantity = int.Parse(nudQuantity.Text.ToString());
                currentProduct.setQuantity(quantity);

                // Update in database
                ProductDL.UpdateProductPrice(currentProduct.ProductName, currentProduct.price);
                ProductDL.UpdateProductStock(currentProduct.ProductName, currentProduct.quantityInStock);


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

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                    // Delete from database
                    if (ProductDL.DeleteProduct(currentProduct.ProductID))
                    {
                        RefreshDataGridView();
                        ClearFields();
                    }

                    // Remove from our list
                    productsList.Remove(currentProduct);

                    RefreshDataGridView();
                    ClearFields();

                    MessageBox.Show("Product deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productsList.Remove(currentProduct);

                    RefreshDataGridView();
                    ClearFields();
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                // Create new product
                var newProduct = new ProductBL(
                    txtProductName.Text,
                    cmbFabricType.SelectedItem + ": " + txtDescription.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(nudQuantity.Text)
                );

                // Add to database
                ProductDL.AddProduct(newProduct);
                newProduct.ProductID = 00;

                // Add to our list
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
    }
}