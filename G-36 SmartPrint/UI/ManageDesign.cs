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
        private int currentDesignerId; // Assuming you'll set this from login or elsewhere

        public ManageDesign()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set current designer ID (you would get this from login or other context)
            //currentDesignerId = LoginHelpers.currentEmployee.getEmployeeID(); // Example ID, replace with actual logic
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
            
            // Clear existing columns
            dgvDesigns.Columns.Clear();

            // Add columns
            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderId",
                HeaderText = "Order ID",
                DataPropertyName = "OrderID",
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
                DataPropertyName = "DesignerName",
                Width = 150
            });
            
            dgvDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStatus",
                HeaderText = "Status",
                DataPropertyName = "ApprovalStatusValue",
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
                LoadDesigns(); // Refresh the list
                
                MessageBox.Show("Design added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Update the design file
                bool success = DesignDL.UpdateDesignFile(
                    selectedDesign.order.OrderID, 
                    selectedDesign.designid, // You'll need to add DesignID to your DesignBL class
                    newDesignLink);

                if (success)
                {
                    LoadDesigns(); // Refresh the list
                    MessageBox.Show("Design updated successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    
                    // You would need to add a DeleteDesign method to your DL class
                    // DesignDL.DeleteDesign(selectedDesign.OrderID, selectedDesign.DesignID);
                    // For now, we'll just show a message
                    MessageBox.Show("Delete functionality would be implemented here", 
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadDesigns(); // Refresh the list
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
                txtorderid.Text = selectedDesign.order.OrderID.ToString();
                txtDesignLink.Text = selectedDesign.designFile;
                txtDesignerName.Text = selectedDesign.designer.getUserName();
                dtpCreatedDate.Value = selectedDesign.createddate;
                
                // You might want to load the full description from the order
                // txtDesignDescription.Text = ...;
            }
        }

        private void dgvDesigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any specific cell content clicks if needed
        }

        private void txtDesignerName_TextChanged(object sender, EventArgs e)
        {
            // Handle designer name text change if needed
        }

        private void lblDesignerName_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }
    }
}