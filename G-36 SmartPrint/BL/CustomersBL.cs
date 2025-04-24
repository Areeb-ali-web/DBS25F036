using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class CustomersBL : UserBL
    {
        public List<OrderBL> orders = new List<OrderBL>();
        
        public CustomersBL() { }    
        public CustomersBL(List<OrderBL> orders)
        {
            this.orders = orders;
        }
    }
}
