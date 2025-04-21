using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class EmployeesBL : UserBL

    {
        private int employeeID;
        private LookupBL Position;
        private DateTime hiredate;
        private float salary;

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

        public EmployeesBL(int EmployeeId,LookupBL position,int userID): base(userID) {
            this.employeeID = EmployeeId;
            this.Position = position;
        }
    }
}