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
    public partial class ViewProducts : UserControl
    {
        private List<ProductBL> productsList;
        public ViewProducts()
        {
            InitializeComponent();
            LoadProducts();
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
        private void RefreshDataGridView()
        {
            dgvProducts.DataSource = null;
            productsList = ProductDL.LoadProducts();
            dgvProducts.DataSource = productsList;
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
        private void dvgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
