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
    public partial class ManagerViewOrders : UserControl
    {
        public ManagerViewOrders()
        {
            InitializeComponent();
           dgvRequests.DataSource = OrderDL.LoadAllOrders();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
