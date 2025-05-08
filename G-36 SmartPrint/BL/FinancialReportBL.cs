using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class FinancialReportBL
    {
        public int financeID { get; private set; }
        public ManagerBL Manager { get; private set; }
        public DateTime date { get; private set; }
        public decimal totalRevenue { get; private set; }
        public decimal totalExpenses { get; private set; }
        public decimal netprofit { get; private set; }
    }
}
