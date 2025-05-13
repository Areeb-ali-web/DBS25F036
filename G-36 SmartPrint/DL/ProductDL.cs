using System;
using System.Collections.Generic;
using System.Data;
using G_36_SmartPrint.BL;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class ProductDL
    {
        public static List<ProductBL> LoadProducts()
        {
            List<ProductBL> products = new List<ProductBL>();
            string query = "SELECT * FROM Products";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dt.Rows)
            {
                products.Add(ConvertToProduct(dr));
            }

            return products;
        }

        public static ProductBL GetProductById(int productId)
        {
            string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
            MySqlParameter[] parameters = { new MySqlParameter("@ProductID", productId) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);

            return dt.Rows.Count > 0 ? ConvertToProduct(dt.Rows[0]) : null;
        }

        public static ProductBL GetProductByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName)) return null;

            string query = "SELECT * FROM Products WHERE name = @Name";
            MySqlParameter[] parameters = { new MySqlParameter("@Name", productName.Trim()) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);

            return dt.Rows.Count > 0 ? ConvertToProduct(dt.Rows[0]) : null;
        }

        public static int? GetProductIdByName(string productName)
        {
            string query = "SELECT ProductID FROM Products WHERE name = @Name";
            MySqlParameter[] parameters = { new MySqlParameter("@Name", productName.Trim()) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);

            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["ProductID"]) : (int?)null;
        }

        public static bool IsProductExistByID(int productId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE ProductID = @ID";
            MySqlParameter[] parameters = { new MySqlParameter("@ID", productId) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public static bool IsProductExistByName(string productName)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE name = @Name";
            MySqlParameter[] parameters = { new MySqlParameter("@Name", productName.Trim()) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public static decimal GetProductPriceByName(string productName)
        {
            string query = "SELECT price FROM Products WHERE name = @Name";
            MySqlParameter[] parameters = { new MySqlParameter("@Name", productName.Trim()) };
            DataTable dt = SqlHelper.getDataTable(query, parameters);

            return dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0]["price"]) : -1;
        }

        public static void AddProduct(ProductBL product)
        {
            if (!product.IsValid(out string msg))
                throw new ArgumentException("Product validation failed: " + msg);

            string query = @"
                INSERT INTO Products (name, Description, price, quantityinstock)
                VALUES (@Name, @Description, @Price, @Quantity)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", product.ProductName),
                new MySqlParameter("@Description", product.Description),
                new MySqlParameter("@Price", product.Price),
                new MySqlParameter("@Quantity", product.QuantityInStock)
            };

            SqlHelper.executeDML(query, parameters);
        }

        public static bool UpdateProductStockByID(int productId, int newStock)
        {
            if (newStock < 0) return false;

            string query = "UPDATE Products SET quantityinstock = @Stock WHERE ProductID = @ID";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Stock", newStock),
                new MySqlParameter("@ID", productId)
            };

            SqlHelper.executeDML(query, parameters);
            return true;
        }

        public static bool UpdateProductPriceByID(int productId, decimal newPrice)
        {
            if (newPrice < 0) return false;

            string query = "UPDATE Products SET price = @Price WHERE ProductID = @ID";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Price", newPrice),
                new MySqlParameter("@ID", productId)
            };

            SqlHelper.executeDML(query, parameters);
            return true;
        }

        public static bool UpdateProductStock(string productName, int newStock)
        {
            if (newStock < 0) return false;

            string query = "UPDATE Products SET quantityinstock = @Stock WHERE name = @Name";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Stock", newStock),
                new MySqlParameter("@Name", productName.Trim())
            };

            SqlHelper.executeDML(query, parameters);
            return true;
        }

        public static bool UpdateProductPrice(string productName, decimal newPrice)
        {
            if (newPrice < 0) return false;

            string query = "UPDATE Products SET price = @Price WHERE name = @Name";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Price", newPrice),
                new MySqlParameter("@Name", productName.Trim())
            };

            SqlHelper.executeDML(query, parameters);
            return true;
        }

        public static bool DeleteProductByID(int productId)
        {
            string query = "DELETE FROM Products WHERE ProductID = @ID";
            MySqlParameter[] parameters = { new MySqlParameter("@ID", productId) };
            SqlHelper.executeDML(query, parameters);
            return true;
        }

        public static bool DeleteProductByName(string productName)
        {
            string query = "DELETE FROM Products WHERE name = @Name";
            MySqlParameter[] parameters = { new MySqlParameter("@Name", productName.Trim()) };
            SqlHelper.executeDML(query, parameters);
            return true;
        }

        // Converts a DataRow to a ProductBL object
        private static ProductBL ConvertToProduct(DataRow dr)
        {
            return new ProductBL(
                Convert.ToInt32(dr["ProductID"]),
                dr["name"].ToString(),
                dr["Description"].ToString(), // Ensure DB column is spelled correctly!
                Convert.ToDecimal(dr["price"]),
                Convert.ToInt32(dr["quantityinstock"])
            );
        }
    }
}
