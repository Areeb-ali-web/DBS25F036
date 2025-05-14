using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ManageDesign : UserControl
    {
        private List<DesignBL> designsList;
        private int currentDesignerId;

        public ManageDesign()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Get current designer ID from login/session (here hardcoded for testing)
            currentDesignerId = 2;

            LoadDesigns();
            ConfigureDataGridView();
            ClearFields();
        }

        private void LoadDesigns()
        {
            try
            {
                designsList = DesignDL.LoadDesignsByDesignerID(currentDesignerId);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading designs: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvDesigns.AutoGenerateColumns = false;
            dgvDesigns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesigns.Columns.Clear();

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderId",
                HeaderText = "Order ID",
                DataPropertyName = "Order.OrderID",
                Width = 100
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesignFile",
                HeaderText = "Design File",
                DataPropertyName = "DesignFile",
                Width = 200
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCreatedDate",
                HeaderText = "Created Date",
                DataPropertyName = "CreatedDate",
                Width = 150
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesigner",
                HeaderText = "Designer",
                DataPropertyName = "Designer.UserName",
                Width = 150
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStatus",
                HeaderText = "Status",
                DataPropertyName = "ApprovalStatus.LookupValue",
                Width = 120
            });
        }

        private void RefreshDataGridView()
        {
            dgvDesigns.DataSource = null;
            dgvDesigns.DataSource = designsList;
        }

        private void ClearFields()
        {
            txtorderid.Text = "";
            txtDesignDescription.Text = "";
            txtDesignLink.Text = "";
            txtDesignerName.Text = "";
            dtpCreatedDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtorderid.Text) || !int.TryParse(txtorderid.Text, out int orderId))
                {
                    MessageBox.Show("Please enter a valid Order ID", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DesignDL.InsertDesign(orderId, currentDesignerId);
                LoadDesigns();

                MessageBox.Show("Design added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding design: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDesigns.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a design to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedDesign = (DesignBL)dgvDesigns.SelectedRows[0].DataBoundItem;
                string newDesignLink = txtDesignLink.Text.Trim();

                bool success = DesignDL.UpdateDesignFile(
                    selectedDesign.Order.OrderID,
                    selectedDesign.DesignID,
                    newDesignLink);

                if (success)
                {
                    LoadDesigns();
                    MessageBox.Show("Design updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update design", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating design: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDesigns.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a design to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this design?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var selectedDesign = (DesignBL)dgvDesigns.SelectedRows[0].DataBoundItem;

                    DesignDL.DeleteDesign(selectedDesign.DesignID);
                    bool deleted = true;
                    if (deleted)
                    {
                        LoadDesigns();
                        MessageBox.Show("Design deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete design.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting design: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDesigns_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDesigns.SelectedRows.Count > 0)
            {
                var selectedDesign = (DesignBL)dgvDesigns.SelectedRows[0].DataBoundItem;
                txtorderid.Text = selectedDesign.Order.OrderID.ToString();
                txtDesignLink.Text = selectedDesign.DesignFile;
                txtDesignerName.Text = selectedDesign.Designer.UserName;
                dtpCreatedDate.Value = selectedDesign.CreatedDate;
                txtDesignDescription.Text = selectedDesign.Order.DesignDescription;
            }
        }

        private void dgvDesigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle clicks on buttons/links inside the DataGridView if needed
        }

        private void txtDesignerName_TextChanged(object sender, EventArgs e)
        {
            // Optional: live filtering or validation
        }

        private void lblDesignerName_Click(object sender, EventArgs e)
        {
            // Optional: UI response
        }
    }
}
