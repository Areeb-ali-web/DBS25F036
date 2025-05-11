using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class designerViewAssignedOrders : UserControl
    {
        public designerViewAssignedOrders()
        {
            InitializeComponent();
        }

        private void dgvAssignedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAssignedDesigns()
        {
            try
            {
                int designerID = LoginHelpers.currentEmployee.getUserID(); // Assumes getUserID returns int

                var designs = DesignDL.LoadDesignsByDesignerID(designerID);

                dgvAssignedOrders.Rows.Clear();
                dgvAssignedOrders.Columns.Clear();

                dgvAssignedOrders.Columns.Add("OrderID", "Order ID");
                dgvAssignedOrders.Columns.Add("Description", "Design Description");
                dgvAssignedOrders.Columns.Add("Status", "Design Status");

                foreach (var design in designs)
                {
                    dgvAssignedOrders.Rows.Add(
                        design.order.OrderID,
                        design.order.getDesignDescription() ?? "N/A",
                        design.approvalstatus?.getLookupValue() ?? "Unknown"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load assigned designs:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
