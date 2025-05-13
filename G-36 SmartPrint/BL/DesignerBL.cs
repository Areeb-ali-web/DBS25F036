using System;
using System.Collections.Generic;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.BL
{
    internal class DesignerBL : EmployeesBL
    {
        public DesignerBL() { }

        public DesignerBL(int employeeID, LookupBL position, DateTime hireDate, float salary)
            : base(employeeID, position, hireDate, salary)
        {
            this.Position.SetLookupValue("designer");
        }

        public DesignerBL(int employeeID, LookupBL position, DateTime hireDate, float salary,
                          string username, string passwordHash, string email, string name,
                          string phoneNumber, DateTime createdDate, LookupBL role)
            : base(employeeID, position, hireDate, salary, username, passwordHash, email, name, phoneNumber, role)
        {
            this.Position.SetLookupValue("designer");
        }

        public DesignerBL(int employeeID, LookupBL position, DateTime hireDate, float salary, List<SalaryPaymentBL> salaryPayments)
            : base(employeeID, position, hireDate, salary)
        {
            this.Position.SetLookupValue("designer");
        }

        public DesignerBL(int employeeID, LookupBL position, int userID)
            : base(employeeID, position, userID)
        {
            this.Position.SetLookupValue("designer");
        }

        public DesignerBL(int designerId, string username)
            : base(designerId, username)
        {
            this.Position?.SetLookupValue("designer");
        }

        public override List<EmployeesBL> LoadAllEmployees()
        {
            return EmployeeDL.LoadEmployeesByPosition(4); // Assuming 4 = Designer
        }

        
    }
}
