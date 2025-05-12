using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.BL
{
    internal class ManagerBL:EmployeesBL
    {

        public int getdesignerId()
        {
            return employeeID;
        }
        public override string getName()
        {
            return name;
        }

        public ManagerBL(int employeeID, LookupBL position, DateTime hiredate, float salary)
        {
            this.employeeID = employeeID;
            Position = position;
            this.hiredate = hiredate;
            this.salary = salary;
        }
        public ManagerBL(EmployeesBL employee) : base(employee)
        {

        }
        public ManagerBL(int employeeID, LookupBL position, DateTime hiredate, float salary, string username, string passwordHash, string email, string name, string phone_number, DateTime date, LookupBL role)
        {

            this.employeeID = employeeID;
            Position = position;
            Position.setLookupValue("manager");
            this.hiredate = hiredate;
            this.salary = salary;

        }
        public ManagerBL(int employeeID, LookupBL position, DateTime hiredate, float salary, List<SalaryPaymentBL> salaryPayment) : this(employeeID, position, hiredate, salary)
        {
            this.salaryPayment = salaryPayment;
        }

        public ManagerBL(int EmployeeId, LookupBL position, int userID)
        {
            this.employeeID = EmployeeId;
            this.Position = position;
        }
        public ManagerBL(int designerid, string username)
        {
            this.employeeID = designerid;
            this.setname(username);
        }
        public override void setuserID(int userID)
        {
            base.setuserID(userID);
        }
        public static ManagerBL getManagerByID(int id)
        {
            EmployeesBL employee = EmployeeDL.LoadEmployeeById(id);
            ManagerBL manager = new ManagerBL(employee);
            return manager;
        }
 
        public override List<EmployeesBL> loademployee()
        {
            List<EmployeesBL> employees = EmployeeDL.LoadEmployeesByPosition(4);
            return employees;
        }
    }
}
