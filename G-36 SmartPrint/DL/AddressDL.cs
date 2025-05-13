using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class AddressDL
    {
        public static List<AddressBL> LoaduserAddress(UserBL user)
        {
            List<AddressBL> addressBLs = new List<AddressBL>();
            string query = $"SELECT * FROM useraddress WHERE userid = @userId";
            MySqlParameter[] parameters = {
                new MySqlParameter("@userId", user.UserID)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            foreach (DataRow dr in dt.Rows)
            {

                int AddressID = Convert.ToInt32(dr["addressid"]);
                string AddressDetail = dr["address_detail"]?.ToString();
                string City = dr["city"]?.ToString();
                string State = dr["state"]?.ToString();
                string PostalCode = dr["postalcode"]?.ToString();
                string Country = dr["country"]?.ToString();

                AddressBL address = new AddressBL(AddressID,AddressDetail,City,State,PostalCode,Country);
               

                addressBLs.Add(address);
            }

            return addressBLs;
        }

        public static bool AddAddressIfNotExists(int userId, AddressBL address)
        {
            if (!address.IsValid(out string validationMsg))
            {
                MessageBox.Show("Validation failed: " + validationMsg);
                return false;
            }

            string checkQuery = @"SELECT COUNT(*) FROM useraddress 
                                  WHERE userid = @userid 
                                  AND address_detail = @detail 
                                  AND city = @city 
                                  AND state = @state 
                                  AND postalcode = @postal 
                                  AND country = @country";

            MySqlParameter[] checkParams = {
                new MySqlParameter("@userid", userId),
                new MySqlParameter("@detail", address.AddressDetail),
                new MySqlParameter("@city", address.City),
                new MySqlParameter("@state", address.State),
                new MySqlParameter("@postal", address.PostalCode),
                new MySqlParameter("@country", address.Country)
            };

            DataTable result = SqlHelper.getDataTable(checkQuery, checkParams);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                MessageBox.Show("This address already exists.");
                return false;
            }

            string insertQuery = @"INSERT INTO useraddress 
                                   (userid, address_detail, city, state, postalcode, country)
                                   VALUES (@userid, @detail, @city, @state, @postal, @country)";

            MySqlParameter[] insertParams = {
                new MySqlParameter("@userid", userId),
                new MySqlParameter("@detail", address.AddressDetail),
                new MySqlParameter("@city", address.City),
                new MySqlParameter("@state", address.State),
                new MySqlParameter("@postal", address.PostalCode),
                new MySqlParameter("@country", address.Country)
            };

            try
            {
                SqlHelper.executeDML(insertQuery, insertParams);
                MessageBox.Show("Address added successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding address: {ex.Message}");
                return false;
            }
        }

        public static int GetAddressIdFromAddress(AddressBL address)
        {
            string query = @"SELECT addressid FROM useraddress 
                             WHERE address_detail = @detail 
                             AND city = @city 
                             AND postalcode = @postal 
                             AND country = @country 
                             LIMIT 1";

            MySqlParameter[] parameters = {
                new MySqlParameter("@detail", address.AddressDetail),
                new MySqlParameter("@city", address.City),
                new MySqlParameter("@postal", address.PostalCode),
                new MySqlParameter("@country", address.Country)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["addressid"]);
            }

            return -1;
        }

        public static int? GetLastAddressIdOfUser(int userId)
        {
            string query = "SELECT addressid FROM useraddress WHERE userid = @userId ORDER BY addressid DESC LIMIT 1";
            MySqlParameter[] parameters = {
                new MySqlParameter("@userId", userId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["addressid"]);
            }

            return null;
        }
    }
}
