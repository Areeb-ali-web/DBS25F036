using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class UserBL
    {
        protected int UserID;
        protected string UserName;
        protected string PasswordHash;
        protected string Email;
        protected string name;
        protected string phoneNumber;
        protected DateTime CreatedDate;
        protected LookupBL Role;

        public UserBL() { }
        public UserBL(string username,string passwordHash, string email,string name,string phone_number,DateTime date,LookupBL role) 
        {
            this.name = name;
            this.phoneNumber = phone_number;
            this.UserName = username;
            this.PasswordHash = passwordHash;
            this.Email = email;
            this.CreatedDate = date;
            this.Role = role;
        
        }
        public UserBL(int userID, string userName, string passwordHash, string email,LookupBL role)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
         
            Role = role;
        }


        public string getphoneNumber() { return phoneNumber; }
        public string getEmail() { return this.Email; }
        public DateTime getCreatedDate() { return CreatedDate; }
        public LookupBL getRole() { return Role; } public string getname() { return name; }
        
        public string getPasswordHash() { return PasswordHash; }

        public void setname(string name) { this.name = name; }

        public void setemail(string email) {this.Email = email;}
        public void setpassword(string password) {this.PasswordHash = password;}

        public void setRole(LookupBL role) {this.Role = role;}




    }
}