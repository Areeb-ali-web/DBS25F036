using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ManageConsumables : UserControl
    {
        private List<ConsumableInventoryBL> consumablesList;

        public ManageConsumables()
        {
            InitializeComponent();
            InitializeUIEvents();
            ConfigureDataGridView();
            LoadConsumables();
        }

        private void InitializeUIEvents()
        {
            dgvConsumables.CellDoubleClick += dgvConsumables_CellDoubleClick;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void ConfigureDataGridView()
        {
            dgvConsumables.AutoGenerateColumns = false;
            dgvConsumables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsumables.MultiSelect = false;
            dgvConsumables.AllowUserToAddRows = false;

            dgvConsumables.Columns.Clear();

            dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "ItemId",
                Width = 100
            });

            dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Item Name",
                DataPropertyName = "ItemName",
                Width = 300
            });

            dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Current Stock",
                DataPropertyName = "CurrentStock",
                Width = 150
            });
        }

        private void LoadConsumables()
        {
            try
            {
                consumablesList = ConsumeableInventoryDL.LoadAllItems();
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading consumables: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            dgvConsumables.DataSource = null;
            dgvConsumables.DataSource = consumablesList;
            ClearFields();
        }

        private void ClearFields()
        {
            txtConsumableId.Text = string.Empty;
            txtItemName.Text = string.Empty;
            numQuantity.Value = numQuantity.Minimum;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text.Trim();
                int quantity = (int)numQuantity.Value;

                ConsumeableInventoryDL.AddItem(itemName, quantity);
                LoadConsumables();

                MessageBox.Show("Item added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Duplicate Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtConsumableId.Text, out int itemId))
            {
                MessageBox.Show("Please select an item to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int newStock = (int)numQuantity.Value;
                ConsumeableInventoryDL.UpdateStock(itemId, newStock);
                LoadConsumables();

                MessageBox.Show("Stock updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtConsumableId.Text, out int itemId))
            {
                MessageBox.Show("Please select an item to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this item?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Implement this method in DL if not already done
                    // ConsumeableInventoryDL.DeleteItem(itemId);

                    MessageBox.Show("Delete functionality placeholder.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadConsumables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting item: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvConsumables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvConsumables.Rows.Count > e.RowIndex)
            {
                var row = dgvConsumables.Rows[e.RowIndex];

                txtConsumableId.Text = row.Cells["colId"].Value?.ToString() ?? string.Empty;
                txtItemName.Text = row.Cells["colName"].Value?.ToString() ?? string.Empty;

                if (int.TryParse(row.Cells["colStock"].Value?.ToString(), out int stock))
                {
                    numQuantity.Value = stock;
                }
                else
                {
                    numQuantity.Value = numQuantity.Minimum;
                }
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom painting code
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
