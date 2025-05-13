using System;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class designerViewAssignedOrders : UserControl
    {
        public designerViewAssignedOrders()
        {
            InitializeComponent();
            ConfigureDataGridView();
            this.Load += DesignerViewAssignedOrders_Load; // Add load event handler
        }

        private void DesignerViewAssignedOrders_Load(object sender, EventArgs e)
        {
            LoadAssignedDesigns();
        }

        private void ConfigureDataGridView()
        {
            dgvAssignedOrders.AutoGenerateColumns = false;
            dgvAssignedOrders.AllowUserToAddRows = false;
            dgvAssignedOrders.AllowUserToDeleteRows = false;
            dgvAssignedOrders.ReadOnly = true;
            dgvAssignedOrders.RowHeadersVisible = false;
            dgvAssignedOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignedOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadAssignedDesigns()
        {
            try
            {
                // Check if user is logged in
                if (LoginHelpers.currentEmployee == null)
                {
                    MessageBox.Show("No designer is currently logged in.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int designerID = LoginHelpers.currentEmployee.EmployeeID;
                var designs = DesignDL.LoadDesignsByDesignerID(designerID);

                // Clear existing data
                dgvAssignedOrders.Rows.Clear();
                dgvAssignedOrders.Columns.Clear();

                // Add columns if they don't exist
                if (dgvAssignedOrders.Columns.Count == 0)
                {
                    dgvAssignedOrders.Columns.Add("OrderID", "Order ID");
                    dgvAssignedOrders.Columns.Add("Description", "Design Description");
                    dgvAssignedOrders.Columns.Add("Status", "Design Status");
                }

                // Add design data
                foreach (var design in designs)
                {
                    // Null checks for all properties
                    int orderId = design.order?.OrderID ?? 0;
                    string description = design.order?.getDesignDescription() ?? "N/A";
                    string status = design.approvalstatus?.LookupValue ?? "waiting";

                    dgvAssignedOrders.Rows.Add(orderId, description, status);
                }

                // Show message if no designs found
                if (dgvAssignedOrders.Rows.Count == 0)
                {
                    MessageBox.Show("No assigned designs found for this designer.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load assigned designs:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAssignedDesigns();
        }

        private void dgvAssignedOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvAssignedOrders.Rows.Count)
                return;

            try
            {
                // Get selected order ID
                int orderId = Convert.ToInt32(dgvAssignedOrders.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Open design details form or perform action
                MessageBox.Show($"Selected Order ID: {orderId}", "Design Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting design:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}