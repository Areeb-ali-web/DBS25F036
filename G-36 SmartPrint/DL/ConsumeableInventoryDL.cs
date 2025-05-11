using G_36_SmartPrint.BL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace G_36_SmartPrint.DL
{
    internal class ConsumeableInventoryDL
    {
        // Load all items
        public static List<ConsumeableInventoryBL> LoadAllItems()
        {
            List<ConsumeableInventoryBL> items = new List<ConsumeableInventoryBL>();
            string query = "SELECT Item_ID, Item_name, CurrentStock FROM consumableinventory";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Item_ID"]);
                string name = row["Item_name"].ToString();
                int stock = Convert.ToInt32(row["CurrentStock"]);

                items.Add(new ConsumeableInventoryBL(id, name, stock));
            }

            return items;
        }

        // Load single item by ID
        public static ConsumeableInventoryBL LoadItemById(int itemId)
        {
            string query = "SELECT Item_ID, Item_name, CurrentStock FROM consumableinventory WHERE Item_ID = @ItemID";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@ItemID", itemId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                int id = Convert.ToInt32(row["Item_ID"]);
                string name = row["Item_name"].ToString();
                int stock = Convert.ToInt32(row["CurrentStock"]);

                return new ConsumeableInventoryBL(id, name, stock);
            }

            return null; // Not found
        }
    }
}
