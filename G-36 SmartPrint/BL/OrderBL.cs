using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class OrderBL
    {
        private int orderID;
        private CustomersBL customer;
        private DateTime Order_date;
        private bool DeliveryRequired;
        private AddressBL delivery_address;
        private LookupBL orderStatus;
        private decimal totalAmount;

    }
}
