using System;
using System.Collections.Generic;

namespace G_36_SmartPrint.BL
{
    internal class CustomersBL : UserBL
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

        public CustomersBL(UserBL user) : base(user) { }

        public CustomersBL(int userID, string username, string email, string name, string phoneNumber) : base(userID, username, email, name, phoneNumber)
        {
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
    }
}
