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
        
        private DateTime Order_date;
        private bool DeliveryRequired;
        private AddressBL delivery_address;
        private LookupBL orderStatus;
        private decimal totalAmount;
        protected List<Order_DetailsBL> orderDetails;
        public List<FeedbackDL> feedback;
        
        public OrderBL() { }
        public OrderBL(int orderID,DateTime orderdate,bool DeliveryRequired,AddressBL delivery_address,decimal totalamount,List<Order_DetailsBL> orderDetails)
        {
            this.orderID = orderID;

            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
        }

        public OrderBL(  DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails)
        {
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
        }

        public decimal gettotalamount()
        {
            return totalAmount;
        }

    }
}
