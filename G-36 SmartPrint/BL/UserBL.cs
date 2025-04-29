using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        public List<AddressBL> Addresses { get; set; } = new List<AddressBL>();
        public UserBL() { }
        public UserBL(string username, string passwordHash, string email, string name, string phone_number, DateTime date, LookupBL role)
        {
            this.name = name;
            this.phoneNumber = phone_number;
            this.UserName = username;
            this.PasswordHash = passwordHash;
            this.Email = email;
            this.CreatedDate = date;
            this.Role = role;

        }
        public UserBL(int userID, string userName, string passwordHash, string email, LookupBL role)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;

            Role = role;
        }
        public UserBL(int userID, string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
            CreatedDate = createdDate;
            Role = role;
        }
        public UserBL(int userID, string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role, AddressBL address) : this(userID, userName, passwordHash, email, name, phoneNumber, createdDate, role)
        {
            Addresses = new List<AddressBL> { address };
        }

        public UserBL(string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role, AddressBL address)
        {
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
            CreatedDate = createdDate;
            Role = role;
            Addresses = new List<AddressBL> { address };
        }

        public UserBL(int userID, AddressBL address)
        {
            UserID = userID;
            Addresses = new List<AddressBL> { address };
            // Ensure Role is initialized if required, possibly via a parameter or default value
        }



        public UserBL(int userID)
        {
            this.UserID = userID;
        }
        public UserBL(String username, string passwordHash, string email)
        {
            this.Email = email;
            this.UserName = username;
            this.PasswordHash = passwordHash;
        }
        public UserBL(String username, string passwordHash, string email,string name)
        {
            this.Email = email;
            this.UserName = username;
            this.name = name;
            this.PasswordHash = passwordHash;
        }

        public UserBL(int userid,string username, string email, string name, string phoneNumber)
        {
            this.UserID = userid;
            this.UserName = username;
            this.Email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public string getphoneNumber() { return phoneNumber; }
        public string getEmail() { return this.Email; }
        public DateTime getCreatedDate() { return CreatedDate; }
        public LookupBL getRole() { return Role; }
        public string getname() { return name; }

        public string getPasswordHash() { return PasswordHash; }

        public void setname(string name) { this.name = name; }

        public void setemail(string email) { this.Email = email; }
        public void setpassword(string password) { this.PasswordHash = password; }

        public void setRole(LookupBL role) { this.Role = role; }

        public int getuserID()
        {
            return UserID;
        }

        public void setuserID(int userID) { this.UserID = userID; }
        





    }
}