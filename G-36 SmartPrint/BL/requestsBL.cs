using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class requestsBL
    {
        public int reqquestid;
        public EmployeesBL employees;
        public ConsumableInventoryBL requested_item;
        public int quantity;
        public LookupBL approvalstatus;

    }
}
