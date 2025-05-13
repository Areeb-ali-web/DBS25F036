using G_36_SmartPrint.BL;
using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class ConsumeableInventoryDL
    {
        // Load all items
        public static List<ConsumableInventoryBL> LoadAllItems()
        {
            List<ConsumableInventoryBL> items = new List<ConsumableInventoryBL>();
            string query = "SELECT Item_ID, Item_name, CurrentStock FROM consumableinventory";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Item_ID"]);
                string name = row["Item_name"].ToString();
                int stock = Convert.ToInt32(row["CurrentStock"]);

                items.Add(new ConsumableInventoryBL(id, name, stock));
            }

            return items;
        }

        // Load item by ID
        public static ConsumableInventoryBL LoadItemById(int itemId)
        {
            string query = "SELECT Item_ID, Item_name, CurrentStock FROM consumableinventory WHERE Item_ID = @ItemID";
            MySqlParameter[] parameters = {
                new MySqlParameter("@ItemID", itemId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return new ConsumableInventoryBL(
                    Convert.ToInt32(row["Item_ID"]),
                    row["Item_name"].ToString(),
                    Convert.ToInt32(row["CurrentStock"])
                );
            }

            return null;
        }

        // Add a new item with validation
        public static bool AddItem(string itemName, int stock)
        {
            if (string.IsNullOrWhiteSpace(itemName))
                throw new ArgumentException("Item name cannot be empty.");

            if (stock < 0)
                throw new ArgumentException("Stock cannot be negative.");

            // Check if item already exists
            string checkQuery = "SELECT * FROM consumableinventory WHERE Item_name = @ItemName";
            MySqlParameter[] checkParams = {
                new MySqlParameter("@ItemName", itemName)
            };

            DataTable result = SqlHelper.getDataTable(checkQuery, checkParams);
            if (result.Rows.Count > 0)
                throw new InvalidOperationException("Item already exists.");

            // Insert new item
            string insertQuery = "INSERT INTO consumableinventory (Item_name, CurrentStock) VALUES (@ItemName, @Stock)";
            MySqlParameter[] insertParams = {
                new MySqlParameter("@ItemName", itemName),
                new MySqlParameter("@Stock", stock)
            };

            SqlHelper.executeDML(insertQuery, insertParams);
            return true;
        }

        // Update stock of an item
        public static bool UpdateStock(int itemId, int newStock)
        {
            if (newStock < 0)
                throw new ArgumentException("Stock cannot be negative.");

            string updateQuery = "UPDATE consumableinventory SET CurrentStock = @Stock WHERE Item_ID = @ItemID";
            MySqlParameter[] updateParams = {
                new MySqlParameter("@Stock", newStock),
                new MySqlParameter("@ItemID", itemId)
            };

            SqlHelper.executeDML(updateQuery, updateParams);
            return true;
        }
    }
}
