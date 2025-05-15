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
            currentDesignerId = 2; // Simulated session value

            ConfigureDataGridView();
            LoadDesigns();
            ClearFields();
        }

        private void ConfigureDataGridView()
        {
            dgvDesigns.AutoGenerateColumns = false;
            dgvDesigns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesigns.MultiSelect = false;
            dgvDesigns.Columns.Clear();

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesignID",
                HeaderText = "Design ID",
                Width = 70
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderID",
                HeaderText = "Order ID",
                Width = 70
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesignFile",
                HeaderText = "Design File",
                Width = 200
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCreatedDate",
                HeaderText = "Created Date",
                Width = 150
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesigner",
                HeaderText = "Designer",
                Width = 120
            });

            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStatus",
                HeaderText = "Status",
                Width = 120
            });

            dgvDesigns.CellDoubleClick += dgvDesigns_CellDoubleClick;
            dgvDesigns.SelectionChanged += dgvDesigns_SelectionChanged;
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

        // Manual row population method:
        private void RefreshDataGridView()
        {
            dgvDesigns.Rows.Clear();

            foreach (var d in designsList)
            {
                dgvDesigns.Rows.Add(
                    d.DesignID,
                    d.Order?.OrderID ?? 0,
                    d.DesignFile,
                    d.CreatedDate.ToString("yyyy-MM-dd"),
                    d.Designer?.UserName ?? "",
                    d.ApprovalStatus?.LookupValue ?? ""
                );
            }
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
            if (string.IsNullOrWhiteSpace(txtorderid.Text) || !int.TryParse(txtorderid.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
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
                int selectedDesignID = Convert.ToInt32(dgvDesigns.SelectedRows[0].Cells["colDesignID"].Value);
                var selectedDesign = designsList.Find(d => d.DesignID == selectedDesignID);

                if (selectedDesign == null)
                {
                    MessageBox.Show("Selected design not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                    int selectedDesignID = Convert.ToInt32(dgvDesigns.SelectedRows[0].Cells["colDesignID"].Value);
                    var selectedDesign = designsList.Find(d => d.DesignID == selectedDesignID);

                    if (selectedDesign == null)
                    {
                        MessageBox.Show("Selected design not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DesignDL.DeleteDesign(selectedDesign.DesignID);
                    LoadDesigns();

                    MessageBox.Show("Design deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
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
                int selectedDesignID = Convert.ToInt32(dgvDesigns.SelectedRows[0].Cells["colDesignID"].Value);
                var selectedDesign = designsList.Find(d => d.DesignID == selectedDesignID);
                if (selectedDesign != null)
                {
                    PopulateFieldsFromSelection(selectedDesign);
                }
            }
        }

        private void dgvDesigns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDesigns.Rows.Count)
            {
                int selectedDesignID = Convert.ToInt32(dgvDesigns.Rows[e.RowIndex].Cells["colDesignID"].Value);
                var selectedDesign = designsList.Find(d => d.DesignID == selectedDesignID);
                if (selectedDesign != null)
                {
                    PopulateFieldsFromSelection(selectedDesign);
                }
            }
        }

        private void PopulateFieldsFromSelection(DesignBL design)
        {
            txtorderid.Text = design.Order?.OrderID.ToString() ?? "";
            txtDesignLink.Text = design.DesignFile;
            txtDesignerName.Text = design.Designer?.UserName ?? "";
            dtpCreatedDate.Value = design.CreatedDate;
            txtDesignDescription.Text = design.Order?.DesignDescription ?? "";
        }
    }
}
