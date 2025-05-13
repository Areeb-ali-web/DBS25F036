using System;
using System.Collections.Generic;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.BL
{
    internal class ManagerBL : EmployeesBL
    {
        public ManagerBL() { }

        public ManagerBL(int employeeID, LookupBL position, DateTime hireDate, float salary)
            : base(employeeID, position, hireDate, salary)
        {
            this.Position.SetLookupValue("manager");
        }

        public ManagerBL(EmployeesBL employee)
            : base(employee)
        {
            this.Position.SetLookupValue("manager");
        }

        public ManagerBL(int employeeID, LookupBL position, DateTime hireDate, float salary,
                         string username, string passwordHash, string email, string name,
                         string phoneNumber, DateTime createdDate, LookupBL role)
            : base(employeeID, position, hireDate, salary, username, passwordHash, email, name, phoneNumber, role)
        {
            this.Position.SetLookupValue("manager");
        }

        public ManagerBL(int employeeID, LookupBL position, DateTime hireDate, float salary, List<SalaryPaymentBL> salaryPayments): base(employeeID, position, hireDate, salary)
        {
            this.Position.SetLookupValue("manager");
        }

        public ManagerBL(int employeeID, LookupBL position, int userID)
            : base(employeeID, position, userID)
        {
            this.Position.SetLookupValue("manager");
        }

        public ManagerBL(int managerId, string username)
            : base(managerId, username)
        {
            this.Position?.SetLookupValue("manager");
        }

        public static ManagerBL GetManagerByID(int id)
        {
            EmployeesBL employee = EmployeeDL.LoadEmployeeById(id);
            return new ManagerBL(employee);
        }

        public ManagerBL getManagerById(int id)
        {
            EmployeesBL employee = EmployeeDL.LoadEmployeeById(id);
            return new ManagerBL(employee);
        }

        public override List<EmployeesBL> LoadAllEmployees()
        {
            return EmployeeDL.LoadEmployeesByPosition(3); // Assuming 4 = Manager
        }


    }
}
