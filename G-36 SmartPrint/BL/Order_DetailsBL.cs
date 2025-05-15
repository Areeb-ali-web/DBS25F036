using System;
using G_36_SmartPrint.I;

namespace G_36_SmartPrint.BL
{
    internal class Order_DetailsBL:CartBL,IPrice
    {
        // Fields
        //private int _orderDetailID;
        //private ProductBL _product;
        //private int _quantity;
        //private LookupBL _orderStatus;

        // Properties
        public int OrderDetailID
        {
            get => _orderDetailID;
            set => _orderDetailID = value;
        }
        public override decimal CalculateTotal()
        {
            return _quantity*_product.Price;
        }
        public ProductBL Product
        {
            get => _product;
            set => _product = value ?? throw new ArgumentNullException(nameof(Product), "Product cannot be null");
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Quantity), "Quantity cannot be negative");
                _quantity = value;
            }
        }

        public LookupBL OrderStatus
        {
            get => _orderStatus;
            set => _orderStatus = value;
        }

        // Constructors
        public Order_DetailsBL(int orderDetailID, ProductBL product, int quantity, LookupBL orderStatus)
            : this(product, quantity, orderStatus)
        {
            OrderDetailID = orderDetailID;
        }

        public Order_DetailsBL(ProductBL product, int quantity)
            : this(product, quantity, null)
        {
        }

        public Order_DetailsBL(ProductBL product, int quantity, LookupBL orderStatus)
        {
            Product = product;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }

        // Read-only Helper Method
        public override int GetProductID()
        {
            return Product?.ProductID ?? -1;
        }
    }
}
