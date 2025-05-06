using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class DesignerBL:EmployeesBL
    {
        public int getdesignerId()
        {
            return employeeID;
        }
        public override string getName() 
        {
            return name;    
        }
        
        public DesignerBL(int employeeID, LookupBL position, DateTime hiredate, float salary)
        {
            this.employeeID = employeeID;
            Position = position;
            this.hiredate = hiredate;
            this.salary = salary;
        }
        public DesignerBL(int employeeID, LookupBL position, DateTime hiredate, float salary, string username, string passwordHash, string email, string name, string phone_number, DateTime date, LookupBL role) 
        {

            this.employeeID = employeeID;
            Position = position;
            Position.setLookupValue("designer");
            this.hiredate = hiredate;
            this.salary = salary;

        }
        public DesignerBL(int employeeID, LookupBL position, DateTime hiredate, float salary, List<SalaryPaymentBL> salaryPayment) : this(employeeID, position, hiredate, salary)
        {
            this.salaryPayment = salaryPayment;
        }

        public DesignerBL(int EmployeeId, LookupBL position, int userID)
        {
            this.employeeID = EmployeeId;
            this.Position = position;
        }
    }
}
