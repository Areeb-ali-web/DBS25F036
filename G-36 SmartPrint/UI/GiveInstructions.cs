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
    public partial class GiveInstructions : UserControl
    {
        public GiveInstructions()
        {
            InitializeComponent();
            List<EmployeesBL> list = EmployeeDL.LoadEmployeesByPosition(3);
            cmbManagerName.Items.Clear();
            cmbManagerName.DataSource = list;
            cmbManagerName.DisplayMember = "userName";
            cmbManagerName.SelectedIndex = 0;
            cmbManagerName.ValueMember = "Employeeid";

        }

        private void cmbManagerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
