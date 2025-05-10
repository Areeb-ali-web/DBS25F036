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
        
        public CustomersBL(int userID, string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role) : base(userID, userName, passwordHash, email, name, phoneNumber, createdDate, role)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.PasswordHash = passwordHash;
            this.Email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
            CreatedDate = createdDate;
            Role = role;
        }

        public CustomersBL(UserBL user) : base(user)
        {

        }

        public CustomersBL(int userid,string username,string email,string naem,string phoneNumber):base(userid,username,email,naem,phoneNumber)        {
            this.UserID = userid;
            this.UserName = username;
            this.Email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
