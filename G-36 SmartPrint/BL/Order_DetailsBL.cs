using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class Order_DetailsBL
    {
        private int orderdetailID;
        private ProductBL product;
        private int quantity;
        private LookupBL orderStatus;
     

        public Order_DetailsBL(int orderdetailID, ProductBL product, int quantity, LookupBL orderStatus)
        {
            this.orderdetailID = orderdetailID;
            this.product = product;
            this.quantity = quantity;
            this.orderStatus = orderStatus;
            
        }
        public Order_DetailsBL(ProductBL product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        public Order_DetailsBL(ProductBL product,int quantity, LookupBL orderStatus)
        {
            this.quantity=quantity;
            this.orderStatus = orderStatus;
        
            this.product=product;
        }

        public int getOrderDetailID()
        {
            return orderdetailID;
        }
       

        public LookupBL getOrderStatus() 
        {
            return orderStatus;
        }
        public void setproduct(ProductBL product)
        {
            this.product = product;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setDEscription(string description)
        {
        
        }
        public void setorderStatus(LookupBL orderStatus)
        {
            this.orderStatus = orderStatus;
        }
        public ProductBL getproduct()
        {
            return product;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public int getproductId()
        {
            return product.ProductID;
        }
    }
}
