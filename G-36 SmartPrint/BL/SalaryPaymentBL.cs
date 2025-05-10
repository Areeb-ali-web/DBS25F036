using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class SalaryPaymentBL
    {
        public EmployeesBL employee;
        private int paymentid;
        private Decimal amount;
        private DateTime paymentdate;
        private LookupBL salary_status;

        public SalaryPaymentBL(int paymentid, Decimal amount, DateTime paymentdate, LookupBL salary_status)
        {
            this.paymentid = paymentid;
            this.amount = amount;
            this.paymentdate = paymentdate;
            this.salary_status = salary_status;
        }
        public int getPaymentid()
        {
            return paymentid;
        }
        public void setPaymentid(int paymentid)
        {
            this.paymentid = paymentid;
        }
        public Decimal getAmount()
        {
            return amount;
        }
        public void setAmount(Decimal amount)
        {
            this.amount = amount;
        }
        public DateTime getPaymentdate()
        {
            return paymentdate;
        }
        public void setPaymentdate(DateTime paymentdate)
        {
            this.paymentdate = paymentdate;
        }
        public LookupBL getSalary_status()
        {
            return salary_status;
        }
        public void setSalary_status(LookupBL salary_status)
        {
            this.salary_status = salary_status;
        }
        public override string ToString()

        {
            return "SalaryPaymentBL{" +
                "paymentid=" + paymentid +
                ", amount=" + amount +
                ", paymentdate=" + paymentdate +
                ", salary_status=" + salary_status +
                '}';
        }
        public SalaryPaymentBL()
        {
            // Default constructor
        }
        
    }
}
 