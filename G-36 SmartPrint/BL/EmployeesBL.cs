using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class EmployeesBL : UserBL

    {
        protected int employeeID;
        protected LookupBL Position;
        protected DateTime hiredate;
        protected float salary;
        protected List<SalaryPaymentBL> salaryPayment;
        public EmployeesBL() { }
        public EmployeesBL(int employeeID, LookupBL position, DateTime hiredate, float salary)
        {
            this.employeeID = employeeID;
            Position = position;
            this.hiredate = hiredate;
            this.salary = salary;
        }
        public EmployeesBL(int employeeID, LookupBL position, DateTime hiredate, float salary, string username, string passwordHash, string email, string name, string phone_number, DateTime date, LookupBL role) : base(username, passwordHash, email, name, phone_number, date, role)
        {

            this.employeeID = employeeID;
            Position = position;
            this.hiredate = hiredate;
            this.salary = salary;

        }
        public virtual string getName()
        {
            return name;
        }
               
        public EmployeesBL(int employeeID, LookupBL position, DateTime hiredate, float salary, List<SalaryPaymentBL> salaryPayment) : this(employeeID, position, hiredate, salary)
        {
            this.salaryPayment = salaryPayment;
        }

        public EmployeesBL(int EmployeeId,LookupBL position,int userID): base(userID) {
            this.employeeID = EmployeeId;
            this.Position = position;
        }

        public override void setuserID(int userID)
        {
            base.setuserID(userID);
        }
    }
}