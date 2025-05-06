using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.UI;
using Org.BouncyCastle.Utilities;

namespace G_36_SmartPrint
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<OrderBL> order = OrderDL.LoadAllOrders();
            // AddressDL.AddAddressIfNotExists(3, adress);
            List<OrderBL> orders = OrderDL.LoadAllOrders();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
