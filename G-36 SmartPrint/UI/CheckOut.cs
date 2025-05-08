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
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
            
        }

       
        public void CenterOnScreen(Control parent)
        {
            this.Location = new Point(
                (parent.ClientSize.Width - this.Width) / 2,
                (parent.ClientSize.Height - this.Height) / 2);
        }
    }
}