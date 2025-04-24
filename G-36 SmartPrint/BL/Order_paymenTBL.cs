using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class Order_paymenTBL:OrderBL
    {
        private int paymentID;
        private decimal amount;
        private string paymentMethod;
        private DateTime payment_date;
        private LookupBL payment_status;


        public Order_paymenTBL(int paymentID, decimal amount, string paymentMethod, DateTime payment_date, LookupBL payment_status)
        {
            this.paymentID = paymentID;
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.payment_date = payment_date;
            this.payment_status = payment_status;
        }
        public Order_paymenTBL( decimal amount, string paymentMethod, DateTime payment_date, LookupBL payment_status)
        {
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.payment_date = payment_date;
            this.payment_status = payment_status;
        }

        public int getPaymentID() { return paymentID; }
        public decimal getAmount() { return amount; }
        public string getPaymentMethod()
        {
            return paymentMethod;
        }
        public DateTime getPayment_date() { return payment_date; }
        public LookupBL getPayment_status() { return payment_status; }

        public void setPaymentStatus( LookupBL status ) { this.payment_status = status; }
        public void setAmount()
        {
            amount= gettotalamount();   
        }

        public virtual void setPaymentMethod( string paymentMethod ) { this.paymentMethod = paymentMethod; }

    }
}
