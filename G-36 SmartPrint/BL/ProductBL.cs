using System;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.I;

namespace G_36_SmartPrint.BL
{
    internal class ProductBL : IProduct
    {
        public int ProductID { get; private set; }

        private string _productName;
        private string _description;
        private decimal _price;
        private int _quantityInStock;

        // Properties with encapsulation
        public string ProductName
        {
            get => _productName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Product name cannot be empty.");
                _productName = value.Trim();
            }
        }

        public string Description
        {
            get => _description;
            set => _description = value?.Trim() ?? string.Empty;
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        public int QuantityInStock
        {
            get => _quantityInStock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock quantity cannot be negative.");
                _quantityInStock = value;
            }
        }

        // Constructors
        public ProductBL() { }

        public ProductBL(string name, string description, decimal price, int quantityInStock)
        {
            ProductName = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public ProductBL(int productId, string name, string description, decimal price, int quantityInStock)
            : this(name, description, price, quantityInStock)
        {
            ProductID = productId;
        }
        public void UpdateProductStocks()
        {
            ProductDL.UpdateProductStock(this.ProductName, this._quantityInStock);
        }

        // Validation method
        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                message = "Product name is required.";
                return false;
            }

            if (Price < 0)
            {
                message = "Price must be non-negative.";
                return false;
            }

            if (QuantityInStock < 0)
            {
                message = "Stock quantity cannot be negative.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        // Utility methods
        public bool IsInStock()
        {
            return QuantityInStock > 0;
        }

        public void ReduceStock(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (quantity > QuantityInStock)
                throw new InvalidOperationException("Not enough stock available.");

            QuantityInStock -= quantity;
        }

        public void IncreaseStock(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            QuantityInStock += quantity;
        }

        public override string ToString()
        {
            return $"{ProductName} - {Description} (${Price}) - Stock: {QuantityInStock}";
        }
    }
}
