using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DAL
{
    internal class UserDAL
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
        public static List<UserBL> LoadUsers()
        {
            List<UserBL> Users = new List<UserBL>();
            string query = "SELECT * FROM users";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dt.Rows)
            {
                int userID = Convert.ToInt32(dr["userid"]);
                string username = dr["username"].ToString();
                string password = dr["password"].ToString();
                string email = dr["email"].ToString();
                string name = dr["name"].ToString();
                string phoneNumber = dr["phoneNumber"].ToString();
                DateTime createdDate = Convert.ToDateTime(dr["createdDate"]);

                // Assuming 'role' is a string identifier and you can fetch LookupBL from it
                int role = Convert.ToInt32(dr["role"]);
                LookupBL roles = new LookupBL(role); // You may need to change this depending on how LookupBL works

                UserBL user = new UserBL(userID, username, password, email, name, phoneNumber, createdDate, roles);
                Users.Add(user);
            }

            return Users;
        }

    }
}
