using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.ModelBinding;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.I;

namespace G_36_SmartPrint.BL
{
    internal class OrderBL:IPrice
    {
        // Private fields
        private int orderID;
        private CustomersBL customer;
        private DateTime orderDate;
        
        private AddressBL deliveryAddress;
        private LookupBL orderStatus;
        private decimal totalAmount;
        private string designDescription;

        // Associated collections
        private List<Order_DetailsBL> orderDetails;
        private List<DesignBL> designs;
        private List<FeedbackBL> feedback;

        // Public Properties
        public int OrderID { get => orderID; set => orderID = value; }
        public CustomersBL Customer { get => customer; set => customer = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        
        public AddressBL DeliveryAddress { get => deliveryAddress; set => deliveryAddress = value; }
        public LookupBL OrderStatus { get => orderStatus; set => orderStatus = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public string DesignDescription { get => designDescription; set => designDescription = value; }

        public List<Order_DetailsBL> OrderDetails
        {
            get => orderDetails = new List<Order_DetailsBL>();
            set => orderDetails = value;
        }

        public List<DesignBL> Designs
        {
            get => designs = new List<DesignBL>();
            set => designs = value;
        }

        public List<FeedbackBL> Feedback
        {
            get => feedback = new List<FeedbackBL>();
            set => feedback = value;
        }

        // Constructors
        public OrderBL() { }

        public OrderBL(int orderId)
        {
            this.orderID = orderId;
        }

        public OrderBL(CustomersBL customer, DateTime orderDate, bool deliveryRequired, AddressBL deliveryAddress,
                       decimal totalAmount, List<Order_DetailsBL> orderDetails, string designDescription = "", List<DesignBL> designs = null)
        {
            this.customer = customer;
            this.orderDate = orderDate;
            
            this.deliveryAddress = deliveryAddress;
            this.totalAmount = totalAmount;
            this.orderDetails = orderDetails ?? new List<Order_DetailsBL>();
            this.designDescription = designDescription;
            this.designs = designs ?? new List<DesignBL>();
        }

        public OrderBL(int orderID, CustomersBL customer, DateTime orderDate, decimal amount, string description, List<DesignBL> designs)
            : this(customer, orderDate, false, null, amount, null, description, designs)
        {
            this.orderID = orderID;
        }

        public OrderBL(int orderID, DateTime orderDate, bool deliveryRequired, AddressBL deliveryAddress,
                       decimal totalAmount, List<Order_DetailsBL> orderDetails, CustomersBL customer, List<FeedbackBL> feedback = null)
            : this(customer, orderDate, deliveryRequired, deliveryAddress, totalAmount, orderDetails)
        {
            this.orderID = orderID;
            this.feedback = feedback ?? new List<FeedbackBL>();
            this.deliveryAddress = deliveryAddress;
            this.totalAmount = totalAmount;
            this.orderDetails = orderDetails;
            this.customer = customer;


        }

        public int GetTotalProducts()
        { int i = 0;
            foreach(Order_DetailsBL detail in orderDetails)
            {
                i++;
            }
            return i;
        }

        public decimal CalculateTotal()
        {
            totalAmount = 0;
            foreach (Order_DetailsBL detail in this.orderDetails) 
            {
                totalAmount += totalAmount + detail.CalculateTotal(); 
            }
            return totalAmount;
        }
        public void CalculateTotalAmount()
        {
            totalAmount = 0;
            foreach (var detail in OrderDetails)
            {
                totalAmount += detail.Product.Price * detail.Quantity;
            }
        }

        public void SetDesigns(List<DesignBL> designList)
        {
            this.designs = designList ?? new List<DesignBL>();
        }


        public string GetOrderSummary()
        {
            var summary = new System.Text.StringBuilder();
            foreach (var detail in OrderDetails)
            {
                summary.Append(detail.Product.ProductName + ", ");
            }

            if (summary.Length > 2)
                summary.Length -= 2; // Remove last comma

            summary.Append(" ---- " + totalAmount + "\n");
            return summary.ToString();
        }

        /// <summary>
        /// Adds a single order detail.
        /// </summary>
        public void AddOrderDetail(Order_DetailsBL detail)
        {
            if (orderDetails == null)
                orderDetails = new List<Order_DetailsBL>();
            orderDetails.Add(detail);
        }

        /// <summary>
        /// Adds a design to the order.
        /// </summary>
        public void AddDesign(DesignBL design)
        {
            if (designs == null)
                designs = new List<DesignBL>();
            designs.Add(design);
        }

        /// <summary>
        /// Adds feedback from a customer.
        /// </summary>
        public void AddFeedback(FeedbackBL fb)
        {
            if (feedback == null)
                feedback = new List<FeedbackBL>();
            feedback.Add(fb);
        }

        /// <summary>
        /// Returns whether delivery is required.
        /// </summary>


        /// <summary>
        /// Sets the order status by lookup.
        /// </summary>
        public void SetOrderStatusByName(string statusName)
        {
            var lookup = new LookupBL();
            lookup.SetLookupValue(statusName);
            this.orderStatus = lookup;
        }
        public string ToString()
        {
            string productDetails = "";

            foreach (Order_DetailsBL detail in orderDetails)
            {
                productDetails += detail.Product.ProductName + ",";
            }
            //productDetails += "----" + totalAmount + "\n";
            return productDetails;
        }
    }
}
