using System;
using System.Collections.Generic;

namespace G_36_SmartPrint.BL
{
    internal class UserBL
    {
        // Fields - Private to ensure encapsulation
        private int userID;
        private string userName;
        private string passwordHash;
        private string email;
        private string name;
        private string phoneNumber;
        private DateTime createdDate;
        private LookupBL role;
        private string v;

        // Addresses
        public List<AddressBL> Addresses { get; set; } = new List<AddressBL>();

        // Constructors
        public UserBL() { }

        public UserBL(int userID)
        {
            this.userID = userID;
        }
        public UserBL(string username,string password,string email,string name)
        {
            this.userName = username;
            this.passwordHash = password;
            this.email = email;
            this.name = name;
            this.phoneNumber = name;
            this.createdDate = DateTime.Now;
                
        }
        public UserBL(string userName, string passwordHash, string email, string name, string phoneNumber, LookupBL role)
        {
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
            Name = name;
            PhoneNumber = phoneNumber;
            Role = role;
            CreatedDate = DateTime.Now;
        }

        public UserBL(int userID, string userName, string passwordHash, string email, string name, string phoneNumber, DateTime createdDate, LookupBL role)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
            Name = name;
            PhoneNumber = phoneNumber;
            CreatedDate = createdDate;
            Role = role;

        }

        public UserBL(UserBL user)
        {
            UserID = user.UserID;
            UserName = user.UserName;
            PasswordHash = user.PasswordHash;
            Email = user.Email;
            Name = user.Name;
            PhoneNumber = user.PhoneNumber;
            CreatedDate = user.CreatedDate;
            Role = user.Role;
            Addresses = new List<AddressBL>(user.Addresses);
        }

        public UserBL(int userID, string username, string email, string name, string phoneNumber) : this(userID)
        {
        }

        public UserBL(int userID, string v) : this(userID)
        {
            this.v = v;
        }

        // Properties with basic validation
        public int UserID
        {
            get => userID;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("UserID must be positive.");
                userID = value;
            }
        }

        public string UserName
        {
            get => userName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    //throw new ArgumentException("Username cannot be empty.");
                userName = value;
            }
        }

        public string PasswordHash
        {
            get => passwordHash;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    //throw new ArgumentException("Password hash cannot be empty.");
                passwordHash = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    //throw new ArgumentException("Invalid email address.");
                email = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    //throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //    throw new ArgumentException("Phone number cannot be empty.");
                phoneNumber = value;
            }
        }

        public DateTime CreatedDate
        {
            get => createdDate;
            set => createdDate = value;
        }

        public LookupBL Role
        {
            get => role;
            set => role = value;
            //?? throw new ArgumentNullException(nameof(Role), "Role cannot be null.");
        }

        // 🔁 POLYMORPHIC METHODS
        public virtual string GetUserType()
        {
            return "User";
        }

        public virtual List<OrderBL> GetOrders()
        {
            return null; // Default for generic users
        }

        // Allows derived classes to override this
        public virtual void SetUserID(int id)
        {
            UserID = id;
        }
    }
}
