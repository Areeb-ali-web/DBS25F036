using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class RequestDesigner : UserControl
    {
        private List<ConsumableInventoryBL> consumablesList;
        private int itemid;

        public RequestDesigner()
        {
            InitializeComponent();
            this.Load += RequestDesigner_Load;
        }

        private void RequestDesigner_Load(object sender, EventArgs e)
        {
            txtDesignerName.Text = LoginHelpers.currentuser.UserName;
            ConfigureDataGridView();
            LoadConsumables();

            // Wire up event handler
            dgvRequests.CellDoubleClick += dgvRequests_CellDoubleClick;
        }

        private void ConfigureDataGridView()
        {
            dgvRequests.AutoGenerateColumns = false;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Columns.Clear();

            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Item_id",
                Width = 100
            });

            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = "Item Name",
                DataPropertyName = "Item_name",
                Width = 300
            });

            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStock",
                HeaderText = "Current Stock",
                DataPropertyName = "currentstock",
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
            dgvRequests.DataSource = null;
            consumablesList = ConsumeableInventoryDL.LoadAllItems();
            dgvRequests.DataSource = consumablesList;
        }

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRequests.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvRequests.Rows[e.RowIndex];

                txtitem_name.Text = selectedRow.Cells["colName"].Value?.ToString();
                itemid = Convert.ToInt32(selectedRow.Cells["colId"].Value);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int quantity = (int)numQuantity.Value;

            if (itemid == 0 || string.IsNullOrWhiteSpace(txtitem_name.Text))
            {
                MessageBox.Show("Please select an item from the table first.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RequestsDL.AddRequest(itemid, LoginHelpers.currentEmployee.EmployeeID, quantity);

                MessageBox.Show("Request submitted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset fields
                txtitem_name.Clear();
                numQuantity.Value = 1;
                itemid = 0;

                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to submit request.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtitem_name.Clear();
            numQuantity.Value = 1;
            itemid = 0;
        }
    }
}
