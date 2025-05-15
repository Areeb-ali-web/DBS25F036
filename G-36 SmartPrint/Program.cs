using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.UI;
using SqlServerTypes; // ✅ Add this namespace for spatial support

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
            // ✅ Load the correct native spatial assemblies (x86/x64)
            Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DesignerDashbordForm());
        }
    }
}
