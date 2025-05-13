using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        protected List<Order_DetailsBL> orderDetails;
        public List<FeedbackBL> feedback;
        private string Designdescription;
        public List<DesignBL> designs;
        public OrderBL() { }
        public OrderBL(int orderid)
        {
            this.orderID = orderid;
        }
        public int OrderID
        {
            get { return this.orderID; }
            set { this.orderID = value; }
        }
        public OrderBL(int orderid,CustomersBL customer,DateTime orderdate,decimal ammount,string description,List<DesignBL> design)
        {
            this.orderID = orderid;
            this.customer = customer;
            this.Order_date = orderdate;
            this.totalAmount = ammount;
            this.Designdescription = description;
            this.designs = design;
            
        }
        public OrderBL(int orderID, DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails, CustomersBL customer)
        {
            this.orderID = orderID;
            this.customer = customer;
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
        }

        public OrderBL(int orderID, DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails, CustomersBL customer,List<FeedbackBL> feedbak)
        {
            this.orderID = orderID;
            this.customer = customer;
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
            this.feedback = feedbak;
        }

        public OrderBL(CustomersBL customer, DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails)
        {
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
            this.customer = customer;
        }
        public OrderBL(CustomersBL customer, DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails, string designdescription)
        {
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
            this.customer = customer;
            this.Designdescription = designdescription;
        }
        public OrderBL(CustomersBL customer, DateTime orderdate, bool DeliveryRequired, AddressBL delivery_address, decimal totalamount, List<Order_DetailsBL> orderDetails, string designdescription,List<DesignBL> designs)
        {
            this.Order_date = orderdate;
            this.DeliveryRequired = DeliveryRequired;
            this.delivery_address = delivery_address;
            this.totalAmount = totalamount;
            this.orderDetails = orderDetails;
            this.DeliveryRequired = DeliveryRequired;
            this.customer = customer;
            this.Designdescription = designdescription;
            this.designs    = designs;
        }
        public void calculateTotalamount()
        {
            foreach (Order_DetailsBL detail in orderDetails)
            {
                totalAmount += detail.getproduct().Price * detail.getQuantity();
            }
        }
        public void setDesignDesctiption(string description)
        {
            this.Designdescription = description;
        }
        public decimal gettotalamount()
        {
            return totalAmount;
        }
        public bool getDeliveryRequired()
        {
            return DeliveryRequired;
        }
        public DateTime getOrderDate()
        {
            return Order_date;
        }
        public int getOrderID()
        {
            return orderID;
        }
        public void setOrderDetail(List<Order_DetailsBL> detail)
        {
            this.orderDetails = detail;
        }
        public AddressBL getDeliveryAddress()
        {
            return delivery_address;
        }
        public LookupBL getOrderStatus()
        {
            return orderStatus;
        }
        public List<Order_DetailsBL> getOrderDetails()
        {
            return orderDetails;
        }   
        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }
        public void setOrderDate(DateTime orderdate)
        {
            this.Order_date = orderdate;
        }
        public void setDeliveryRequired(bool deliveryRequired)
        {
            this.DeliveryRequired = deliveryRequired;
        }
        public void setDeliveryAddress(AddressBL delivery_address)
        {
            this.delivery_address = delivery_address;
        }
        public void setOrderStatus(LookupBL orderStatus)
        {
            this.orderStatus = orderStatus;
        }
        public CustomersBL getCustomer()
        {
            return customer;
        }
        public void setCustomer(CustomersBL customer)
        {
            this.customer = customer;
        }

     
        public decimal gettotalAmount()
        {
            //foreach(Order_DetailsBL detail in orderDetails)
            //{
            //    totalAmount += detail.getproduct().getPrice() * detail.getQuantity();
            //}
            return totalAmount;
        }

        public void setDesigns(List<DesignBL> design)
        {
            this.designs= design;
        }
        public string getDesignDescription()
        {
            return Designdescription;
        }

        public string allOrders()
        {
             string productDetails = "";

            foreach(Order_DetailsBL detail in orderDetails)
            {
                productDetails += detail.getproduct().ProductName+",";
            }
            productDetails += "----" + totalAmount + "\n";
            return productDetails;
        }
    }
}
