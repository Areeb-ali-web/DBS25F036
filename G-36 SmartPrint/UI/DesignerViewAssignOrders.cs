﻿using System;
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



            List<DesignBL> designs = DesignDL.LoadDesignsByDesignerID(LoginHelpers.currentEmployee.EmployeeID);

            foreach(DesignBL db in designs)
            {
                db.Order = OrderDL.LoadOrderByOrderId(db.Order.OrderID);
            }
            foreach (var design in designs)
            {
                dgvAssignedOrders.Rows.Add(
                    design.Order.OrderID,                      // Order ID
                    design.Order.DesignDescription,            // Design Description
                    design.DesignFile,                              // Design File
                    design.ApprovalStatus.LookupValue          // Design Status
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
