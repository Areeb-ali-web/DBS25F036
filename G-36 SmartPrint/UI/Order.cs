using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            CheckOut checkOutControl = new CheckOut();
            this.Controls.Add(checkOutControl); 
            checkOutControl.BringToFront(); 
            checkOutControl.CenterOnScreen(this);
        }
    }
}
