using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DAL
{
    internal class UserDL
    {
        public static bool UserSignIN(string username, string password, string email, int role)
        {
            // 1. Validate input
            if (!Validation.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            if (!Validation.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters and contain both uppercase and lowercase letters.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.");
                return false;
            }

            // 2. Check if email exists
            string checkQuery = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
            DataTable checkResult = SqlHelper.getDataTable(checkQuery);

            if (checkResult.Rows.Count > 0 && Convert.ToInt32(checkResult.Rows[0][0]) > 0)
            {
                MessageBox.Show("Email already exists. Please use a different email.");
                return false;
            }

            // 3. Insert into DB
            string insertQuery = $"INSERT INTO users (username, passwordhash, email, roleID, createdDate) " +
                                 $"VALUES ('{username}', '{password}', '{email}', {role}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";

            try
            {
                SqlHelper.executeDML(insertQuery);
                MessageBox.Show("Account created successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static bool ValidateUserCredentials(string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return false;
            }

            if (!Validation.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            string query = $"SELECT COUNT(*) FROM users WHERE username = '{username}' AND email = '{email}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No user found with the provided username and email.");
                return false;
            }
        }

        public static List<UserBL> LoadUsers()
        {
            List<UserBL> Users = new List<UserBL>();
            string query = "SELECT * FROM users";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dt.Rows)
            {
                int userID = Convert.ToInt32(dr["userid"]);
                string username = dr["username"].ToString();
                string password = dr["passwordhash"].ToString();
                string email = dr["email"].ToString();
                string name = dr["name"].ToString();
                string phone_number = dr["phone_number"].ToString();
                DateTime createdDate = Convert.ToDateTime(dr["createdDate"]);

                // Assuming 'role' is a string identifier and you can fetch LookupBL from it
                int role = Convert.ToInt32(dr["roleID"]);
                LookupBL roles = new LookupBL(role); // You may need to change this depending on how LookupBL works

                UserBL user = new UserBL(userID, username, password, email, name, phone_number, createdDate, roles);
                user.Addresses = AddressDAL.LoaduserAddress(user); 
                Users.Add(user);
            }

            return Users;
        }
        public static bool UpdateUserPassword(string username, string email, string newPassword)
        {
            if (!Validation.IsValidPassword(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain both uppercase and lowercase letters.");
                return false;
            }

            string query = $"UPDATE users SET passwordhash = '{newPassword}' WHERE username = '{username}' AND email = '{email}'";

            try
            {
                SqlHelper.executeDML(query);
                MessageBox.Show("Password updated successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating password: {ex.Message}");
                return false;
            }
        }

        public static UserBL UserLogin(string username, string email, string password)
        {
            // 1. Input validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return null;
            }

            if (!Validation.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return null;
            }

            // 2. Query the database
            string query = $"SELECT * FROM users WHERE username = '{username}' AND email = '{email}' AND passwordhash = '{password}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                int userID = Convert.ToInt32(dr["userid"]);
                string name = dr["name"]?.ToString() ?? "";
                string phone_number = dr["phone_number"]?.ToString() ?? "";
                DateTime createdDate = Convert.ToDateTime(dr["createdDate"]);
                int roleID = Convert.ToInt32(dr["roleID"]);
                LookupBL role = new LookupBL(roleID);

                UserBL user = new UserBL(userID, username, password, email, name, phone_number, createdDate, role);

                MessageBox.Show("Login successful!");
                return user;
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
                return null;
            }
        }

    }
}
