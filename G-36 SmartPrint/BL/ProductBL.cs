using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class ProductBL
    {
        public int ProductID { get; set; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Name must be at least 3 characters long.");
                name = value;
            }
        }

        public string Description { get; set; }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price must be non-negative.");
                price = value;
            }
        }

        private int quantityInStock;
        public int QuantityInStock
        {
            get => quantityInStock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity in stock cannot be negative.");
                quantityInStock = value;
            }
        }

        // Optional: Constructor
        public ProductBL(string name, string description, decimal price, int quantityInStock)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public ProductBL() { } // Parameterless constructor if needed
    }
}
