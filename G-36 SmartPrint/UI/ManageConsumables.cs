using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ManageConsumables : UserControl
    {
        private List<ConsumeableInventoryBL> consumablesList;

        public ManageConsumables()
        {
            InitializeComponent();
            LoadConsumables();
            ConfigureDataGridView();
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

        private void ConfigureDataGridView()
        {
            dgvConsumables.AutoGenerateColumns = false;
            dgvConsumables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add columns if not already added in designer
            if (dgvConsumables.Columns.Count == 0)
            {
                dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "colId",
                    HeaderText = "ID",
                    DataPropertyName = "Item_id",
                    Width = 100
                });

                dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "colName",
                    HeaderText = "Item Name",
                    DataPropertyName = "Item_name",
                    Width = 300
                });

                dgvConsumables.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "colStock",
                    HeaderText = "Current Stock",
                    DataPropertyName = "currentstock",
                    Width = 150
                });
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
            txtConsumableId.Text = "";
            txtItemName.Text = "";
            numQuantity.Value = numQuantity.Minimum;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text.Trim();
                int quantity = (int)numQuantity.Value;

                ConsumeableInventoryDL.AddItem(itemName, quantity);
                LoadConsumables(); // Refresh the list

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
                MessageBox.Show(ex.Message, "Operation Error",
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
            if (string.IsNullOrEmpty(txtConsumableId.Text))
            {
                MessageBox.Show("Please select an item to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int itemId = int.Parse(txtConsumableId.Text);
                int newStock = (int)numQuantity.Value;

                ConsumeableInventoryDL.UpdateStock(itemId, newStock);
                LoadConsumables(); // Refresh the list

                MessageBox.Show("Stock updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConsumableId.Text))
            {
                MessageBox.Show("Please select an item to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this item?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int itemId = int.Parse(txtConsumableId.Text);

                    // You would need to add a DeleteItem method to your DL class
                    // ConsumeableInventoryDL.DeleteItem(itemId);
                    // For now, we'll just show a message
                    MessageBox.Show("Delete functionality would be implemented here",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadConsumables(); // Refresh the list
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
            if (e.RowIndex >= 0) // Ensure header row wasn't clicked
            {
                DataGridViewRow row = dgvConsumables.Rows[e.RowIndex];
                txtConsumableId.Text = row.Cells["colId"].Value.ToString();
                txtItemName.Text = row.Cells["colName"].Value.ToString();
                numQuantity.Value = Convert.ToInt32(row.Cells["colStock"].Value);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add any custom painting code here
        }
    }
}