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
    public partial class DesignerViewAssignOrders : UserControl
    {
        public DesignerViewAssignOrders()
        {
            InitializeComponent();
            dgvAssignedOrders.Rows.Clear(); // Clear any existing rows

<<<<<<< HEAD
            List<DesignBL> designs = DesignDL.LoadDesignsByDesignerID(4);
=======
            List<DesignBL> designs = DesignDL.LoadDesignsByDesignerID(LoginHelpers.currentEmployee.getUserID());
>>>>>>> Project
            foreach(DesignBL db in designs)
            {
                db.order = OrderDL.LoadOrderByOrderId(db.order.getOrderID());
            }
            foreach (var design in designs)
            {
                dgvAssignedOrders.Rows.Add(
                    design.order.getOrderID(),                      // Order ID
                    design.order.getDesignDescription(),            // Design Description
                    design.designFile,                              // Design File
                    design.approvalstatus.getLookupValue()          // Design Status
                );
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAssignedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
