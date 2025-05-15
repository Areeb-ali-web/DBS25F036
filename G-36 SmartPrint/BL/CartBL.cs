using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    abstract class CartBL
    {
       protected int _orderDetailID;
        protected ProductBL _product;
        protected int _quantity;
        protected LookupBL _orderStatus;

        public abstract decimal CalculateTotal();
        public abstract int GetProductID();
    }
}
