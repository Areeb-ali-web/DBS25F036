using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DAL
{
    internal class AddressDAL
    {
        public static List<AddressBL> LoaduserAddress(UserBL user)
        {
            List<AddressBL> addressBLs = new List<AddressBL>();
            string query = $"SELECT * FROM useraddress WHERE userid = {user.getuserID()}";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dt.Rows)
            {
                AddressBL address = new AddressBL
                {
                    AddressID = Convert.ToInt32(dr["addressid"])
                };

                // Optional: check if columns are not null before assignment
                if (dr["address_detail"] != DBNull.Value)
                    address.setaddressdetail(dr["address_detail"].ToString());

                if (dr["city"] != DBNull.Value)
                    address.setCity(dr["city"].ToString());

                if (dr["postalcode"] != DBNull.Value)
                    address.setpostalcode(dr["postalcode"].ToString());

                if (dr["country"] != DBNull.Value)
                    address.setcountry(dr["country"].ToString());

                addressBLs.Add(address);
            }

            return addressBLs;
        }
        public static bool AddAddressIfNotExists(int userId, AddressBL address)
        {
            // 1. Check if the address already exists for the user
            string checkQuery = $"SELECT COUNT(*) FROM useraddress WHERE userid = {userId} " +
                                $"AND address_detail = '{address.getaddressDetail()}' " +
                                $"AND city = '{address.getcity()}' " +
                                $"AND postalcode = '{address.getpostalcode()}' " +
                                $"AND country = '{address.getcountry()}'";

            DataTable result = SqlHelper.getDataTable(checkQuery);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                // Address already exists
                MessageBox.Show("This address already exists.");
                return false;
            }

            // 2. Insert the address if it doesn't exist
            string insertQuery = $"INSERT INTO useraddress (userid, address_detail, city, postalcode, country) " +
                                 $"VALUES ({userId}, '{address.getaddressDetail()}', '{address.getcity()}', '{address.getpostalcode()}', '{address.getcountry()}')";

            try
            {
                SqlHelper.executeDML(insertQuery);
                MessageBox.Show("Address added successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding address: {ex.Message}");
                return false;
            }
        }
        public static int? GetAddressIdFromAddress(AddressBL address)
        {
            // Sanitize and format query to match all address fields
            string query = $"SELECT addressid FROM useraddress " +
                           $"WHERE address_Detail = '{address.getaddressDetail()}' " +
                           $"AND city = '{address.getcity()}' " +
                           $"AND postalCode = '{address.getpostalcode()}' " +
                           $"AND country = '{address.getcountry()}' " +
                           $"LIMIT 1";

            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["addressid"]);
            }

            return null;
        }
        public static int? GetLastAddressIdOfUser(int userId)
        {
            string query = $"SELECT addressid FROM useraddress WHERE userid = {userId} ORDER BY addressid DESC LIMIT 1";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["addressid"]);
            }
            else
            {
                // No address found for user
                return null;
            }
        }

    }
}
