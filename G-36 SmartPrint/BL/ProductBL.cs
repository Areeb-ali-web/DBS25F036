using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class ProductBL
    {
        public int ProductID { get; set; }

        private string name;
        
    
        public string Description { get; set; }

        private decimal price;
 
        private int quantityInStock;

        public  string getProductName()
        {
            return name;
        }
        public decimal getPrice()
        {
            return price;
        }
        public string ProductName
        {
            get { return name; }
            set { name = value; }
            }
 
        public int getStocks()
        {
            return quantityInStock; 
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public void setprice(decimal price)
        {
            this.price = price;
        }

        public void setQuantity(int quantity)
        {
            quantityInStock= quantity;
        }
        // Optional: Constructor
        public ProductBL(string name, string description, decimal price, int quantityInStock)
        {
            this.name = name;
            this.price = price;
            this.quantityInStock = quantityInStock; 
            this.Description = description;
        }

        public ProductBL(int productID, string name, string description, decimal price, int quantityInStock)
        {
            ProductID = productID;
            this.name = name;
            Description = description;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public ProductBL() { } // Parameterless constructor if needed
    }
}
