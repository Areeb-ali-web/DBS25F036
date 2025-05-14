using System;
using System.Collections.Generic;
using System.Web.Management;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class RequestDesigner : UserControl
    {
        private List<ConsumableInventoryBL> consumablesList;
        private int itemid;
        private ConsumableInventoryBL selectedConsumable;

        public RequestDesigner()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Wire up event handlers
            this.Load += RequestDesigner_Load;
            dgvRequests.CellDoubleClick += DgvRequests_CellDoubleClick;
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvRequests.DataError += DgvRequests_DataError;

            // Initialize UI
            txtDesignerName.Text = LoginHelpers.currentuser?.UserName ?? "Unknown";
            ConfigureDataGridView();
        }

        private void RequestDesigner_Load(object sender, EventArgs e)
        {
            LoadConsumables();
        }

        private void ConfigureDataGridView()
        {
            dgvRequests.AutoGenerateColumns = false;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.ReadOnly = true;
            dgvRequests.Columns.Clear();

            // Add columns with proper DataPropertyNames matching the BL class
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "ItemId",
                Width = 100
            });

            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = "Item Name",
                DataPropertyName = "ItemName",
                Width = 300
            });

            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn()
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
            dgvRequests.DataSource = null;
            dgvRequests.DataSource = consumablesList;
        }

        private void DgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRequests.Rows.Count)
            {
                selectedConsumable = dgvRequests.Rows[e.RowIndex].DataBoundItem as ConsumableInventoryBL;

                if (selectedConsumable != null)
                {
                    itemid = selectedConsumable.ItemId;
                    txtitem_name.Text = selectedConsumable.ItemName;
                    numQuantity.Maximum = selectedConsumable.CurrentStock;
                    numQuantity.Value = Math.Min(1, selectedConsumable.CurrentStock);
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (LoginHelpers.currentEmployee == null)
            {
                MessageBox.Show("No employee logged in.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedConsumable == null)
            {
                MessageBox.Show("Please select an item from the table first.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity > selectedConsumable.CurrentStock)
            {
                MessageBox.Show($"Cannot request more than available stock ({selectedConsumable.CurrentStock}).",
                    "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RequestsDL.AddRequest(itemid, LoginHelpers.currentEmployee.EmployeeID, quantity);
                bool success = true;
                if (success)
                {
                    MessageBox.Show("Request submitted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadConsumables(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Failed to submit request.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to submit request: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtitem_name.Clear();
            numQuantity.Value = 1;
            itemid = 0;
            selectedConsumable = null;
            numQuantity.Maximum = decimal.MaxValue;
        }

        private void DgvRequests_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Data error: {e.Exception.Message}", "Data Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }
}