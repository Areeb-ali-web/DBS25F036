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
    public partial class RequestDesigner : UserControl
    {
        private List<ConsumeableInventoryBL> consumablesList;
        private int itemid;

        public RequestDesigner()
        {
            InitializeComponent();
            this.Load += RequestDesigner_Load;
        }
        private void RequestDesigner_Load(object sender, EventArgs e)
        {
            txtDesignerName.Text = LoginHelpers.currentuser.getUserName();
            ConfigureDataGridView();
            LoadConsumables();
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
            dgvRequests.AutoGenerateColumns = false;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvRequests.Columns.Count == 0)
            {
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

                string itemName = selectedRow.Cells["colName"].Value?.ToString();
                txtitem_name.Text = itemName;

                string item = selectedRow.Cells["colId"].Value?.ToString();
                itemid = Convert.ToInt32(item);
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
                RequestsDL.AddRequest(itemid, LoginHelpers.currentEmployee.Employeeid, quantity);

                MessageBox.Show("Request submitted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields
                txtitem_name.Clear();
                numQuantity.Value = 1;
                itemid = 0;

                // Reload the grid
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to submit request.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle if needed
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: handle if needed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
