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
        private string Designdescription;

        public Order_DetailsBL(int orderdetailID, ProductBL product, int quantity, LookupBL orderStatus, string designdescription)
        {
            this.orderdetailID = orderdetailID;
            this.product = product;
            this.quantity = quantity;
            this.orderStatus = orderStatus;
            Designdescription = designdescription;
        }
        public Order_DetailsBL(ProductBL product,int quantity, LookupBL orderStatus, string designdescription)
        {
            this.quantity=quantity;
            this.orderStatus = orderStatus;
            this.Designdescription = designdescription;
            this.product=product;
        }

        public int getOrderDetailID()
        {
            return orderdetailID;
        }
        public string getdesignDescription()
        {
            return Designdescription;

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
            this.Designdescription = description;
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
