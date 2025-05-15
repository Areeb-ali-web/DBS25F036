using System;
using System.Collections.Generic;
using System.Configuration;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.I;

namespace G_36_SmartPrint.BL
{
    internal class CustomersBL : UserBL, CustomerI
    {
        private List<OrderBL> orders = new List<OrderBL>();

        public CustomersBL() { }

        public CustomersBL(List<OrderBL> orders)
        {
            this.orders = orders ?? new List<OrderBL>();
        }

        public CustomersBL(int userID, string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role)
            : base(userID, userName, passwordHash, email, name, phoneNumber, createdDate, role)
        {
        }

        public CustomersBL(UserBL user) : base(user) 
        {
            this.UserID = user.UserID;
            this.UserName = user.UserName;
            this.Addresses = user.Addresses;
            this.PhoneNumber = user.PhoneNumber;
            this.CreatedDate = user.CreatedDate;
            this.Email = user.Email;
        }

        public CustomersBL(int userID, string username, string email, string name, string phoneNumber) : base(userID, username, email, name, phoneNumber)
        {
            this.UserID = userID;
            this.UserName = username;
            this.Addresses = new List<AddressBL>();
            this.Email = email;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
          
        }

        private void ProvideFeedback(int productId, string feedback)
        {
            OrderDL orderDL = new OrderDL();
        }
        
        public void PlaceOrder(OrderBL order)
        {
            OrderDL.AddOrder(order);
        }
        public override string GetUserType()
        {
            return "Customer";
        }

        public override List<OrderBL> GetOrders()
        {
            return orders;
        }
        public void setOrders(List<OrderBL> orders)
        {
            this.orders = orders;
        }

        public void AddOrder(OrderBL order)
        {
            if (order != null)
                orders.Add(order);
        }

        void CustomerI.ProvideFeedback(int productId, string feedback)
        {
            ProvideFeedback(productId, feedback);
        }
    }
}
