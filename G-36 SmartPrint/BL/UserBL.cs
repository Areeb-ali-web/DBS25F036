﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.I;

namespace G_36_SmartPrint.BL
{
    internal class UserBL: UserI
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
        public void UserSignin()
        {
            if (this.UserID != null && this.passwordHash != null && this.role != null && this.email != null)
            {
                UserDL.UserSignIN(UserName, PasswordHash, Email, Name, role.LookupID);
            }
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
                
                    //throw new ArgumentException("Username cannot be empty.");
                userName = value;
            }
        }

        public string PasswordHash
        {
            get => passwordHash;
            set
            {
                
                    //throw new ArgumentException("Password hash cannot be empty.");
                passwordHash = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
             
                    //throw new ArgumentException("Invalid email address.");
                email = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
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
        public bool IsValidEmail(string email)
        {
            // Basic email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Password Validation

        public bool IsValidPassword(string password)
        {
            // Must contain at least one letter and one number
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
        }


        // Name Validation: At least 2 words
        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            string[] parts = name.Trim().Split(' ');
            return parts.Length >= 2 && parts.All(p => p.Length > 0);

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
        public void UserLogin()
        {
            if (this.userName != null && this.passwordHash != null && this.Email != null)
            {
                UserDL.UserLogin(UserName,email,passwordHash);
            }
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
