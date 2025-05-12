using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.BL;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class ProductDL
    {
        public static List<ProductBL> LoadProducts() 
        {
            List<ProductBL> Products = new List<ProductBL>();
            string query = "SELECT * FROM Products";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dt.Rows)
            {
                int ProductID = Convert.ToInt32(dr["Productid"]);
                string Productname = dr["name"].ToString();
                string Description = dr["Description"].ToString();
                decimal price = Convert.ToDecimal( dr["price"]);

             

                // Assuming 'role' is a string identifier and you can fetch LookupBL from it
                int quantityinstock = Convert.ToInt32(dr["quantityinstock"]);
                
                ProductBL product = new ProductBL(ProductID,Productname,Description,price,quantityinstock);
                Products.Add(product);

            }

            return Products;
        }
        public static int? GetProductIdByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return null;

            string query = $"SELECT ProductID FROM Products WHERE name = '{productName}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["ProductID"]);
            }

            return null; // Product not found
        }
        public static bool UpdateProductStock(string productName, int newStock)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name is required.");
                return false;
            }

            if (newStock < 0)
            {
                System.Windows.Forms.MessageBox.Show("Stock quantity cannot be negative.");
                return false;
            }

            string query = $"UPDATE Products SET quantityinstock = {newStock} WHERE name = '{productName}'";
            SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Updated successfully");
            return true;
        }

        public static bool UpdateProductPrice(string productName, decimal newPrice)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name is required.");
                return false;
            }

            if (newPrice < 0)
            {
                System.Windows.Forms.MessageBox.Show("Price must be non-negative.");
                return false;
            }

            string query = $"UPDATE Products SET price = {newPrice} WHERE name = '{productName}'";


              SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Updated successfully");
            return true ;
        }


        public static bool UpdateProductStockByID(int productId, int newStock)
        {
            if (productId <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Product ID.");
                return false;
            }

            if (newStock < 0)
            {
                System.Windows.Forms.MessageBox.Show("Stock cannot be negative.");
                return false;
            }

            string query = $"UPDATE Products SET quantityinstock = {newStock} WHERE productid = {productId}";
            SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Updated successfully");
            return true;
        }
        public static bool UpdateProductPriceByID(int productId, decimal newPrice)
        {
            if (productId <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Product ID.");
                return false;
            }

            if (newPrice < 0)
            {
                System.Windows.Forms.MessageBox.Show("Price must be non-negative.");
                return false;
            }

            string query = $"UPDATE Products SET price = {newPrice} WHERE productid = {productId}";
            SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Updated successfully");
            return true;

        }
        public static bool DeleteProductByID(int productId)
        {
            if (productId <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Product ID.");
                return false;
            }

            string query = $"DELETE FROM Products WHERE productid = {productId}";

            SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Deleted");
            return true;
        }

        public static bool DeleteProductByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name cannot be empty.");
                return false;
            }

            string query = $"DELETE FROM Products WHERE name = '{productName}'";
            SqlHelper.executeDML(query);
            System.Windows.Forms.MessageBox.Show("Product is Deleted");
            return true;
        }
        public static bool IsProductExistByID(int productId)
        {
            if (productId <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Product ID.");
                return false;
            }

            string query = $"SELECT COUNT(*) FROM Products WHERE productid = {productId}";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true;
            }

            return false;
        }
        public static bool IsProductExistByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name cannot be empty.");
                return false;
            }

            string query = $"SELECT COUNT(*) FROM Products WHERE name = '{productName}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true;
            }

            return false;
        }
        public static decimal GetProductPriceByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name cannot be empty.");
                return -1; // or throw an exception if preferred
            }

            string query = $"SELECT price FROM Products WHERE name = '{productName}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0]["price"]);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Product not found.");
                return -1; // Sentinel value indicating product not found
            }
        }

        public static ProductBL GetProductById(int productId)
        {
            string query = $"SELECT * FROM Products WHERE Productid = {productId}";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new ProductBL(
                    Convert.ToInt32(dr["Productid"]),
                    dr["name"].ToString(),
                    dr["Discription"].ToString(),
                    Convert.ToDecimal(dr["price"]),
                    Convert.ToInt32(dr["quantityinstock"])
                );
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Product not found.");
                return null;
            }
        }
        public static bool DeleteProduct(int productId)
        {
            string query = $"delete from products where ProductID ={productId}";
            try
            {
                SqlHelper.executeDML(query);
                return true;
            }
            catch { 
                return false;
            }
        }
        public static ProductBL GetProductByName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                System.Windows.Forms.MessageBox.Show("Product name cannot be empty.");
                return null;
            }

            string query = $"SELECT * FROM Products WHERE name = '{productName}'";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new ProductBL(
                    Convert.ToInt32(dr["Productid"]),
                    dr["name"].ToString(),
                    dr["Discription"].ToString(),
                    Convert.ToDecimal(dr["price"]),
                    Convert.ToInt32(dr["quantityinstock"])
                );
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Product not found.");
                return null;
            }
        }

        public static void AddProduct(ProductBL product)
        {
            try
            {
                // Parameterized query to prevent SQL injection
                string query = @"
            INSERT INTO Products (name, Description, price, quantityinstock)
            VALUES (@Name, @Description, @Price, @Quantity);
            SELECT LAST_INSERT_ID();"; // Get the auto-generated ID

                // Create parameters
                MySqlParameter[] parameters = new MySqlParameter[]
                {
            new MySqlParameter("@Name", product.getProductName()),
            new MySqlParameter("@Description", product.Description),
            new MySqlParameter("@Price", product.getPrice()),
            new MySqlParameter("@Quantity", product.getStocks())
                };

                // Execute the query and get the new ID
              SqlHelper.executeDML(query, parameters);

                
            }
            catch (Exception ex)
            {
                // Log the error (you might want to implement proper logging)
                System.Windows.Forms.MessageBox.Show($"Error adding product: {ex.Message}");
               
            }
        }

    }
}
