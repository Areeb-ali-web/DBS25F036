using System;
using System.Collections.Generic;
using G_36_SmartPrint.DL;
using G_36_SmartPrint.UI;
using Mysqlx.Datatypes;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace G_36_SmartPrint.BL
{
    internal class EmployeesBL : UserBL
    {
        // Private Fields
        private int employeeID;
        private LookupBL position;
        private DateTime hireDate;
        private float salary;
        private List<SalaryPaymentBL> salaryPayments = new List<SalaryPaymentBL>();

        // Constructors
        public EmployeesBL() { }

        public EmployeesBL(int employeeID, LookupBL position, DateTime hireDate, float salary)
        {
            EmployeeID = employeeID;
            Position = position;
            HireDate = hireDate;
            Salary = salary;
        }

        public EmployeesBL(int employeeID, LookupBL position, DateTime hireDate, float salary,
                           string userName, string passwordHash, string email, string name, string phoneNumber, LookupBL role)
            : base(userName, passwordHash, email, name, phoneNumber, role)
        {
            EmployeeID = employeeID;
            Position = position;
            HireDate = hireDate;
            Salary = salary;
        }

        public EmployeesBL(int employeeID, string employeeName)
        {
            EmployeeID = employeeID;
            UserName = employeeName;
        }

        public EmployeesBL(EmployeesBL other) : base(other)
        {
            EmployeeID = other.EmployeeID;
            Position = other.Position;
            HireDate = other.HireDate;
            Salary = other.Salary;
            salaryPayments = new List<SalaryPaymentBL>(other.salaryPayments);
        }

        public EmployeesBL(int employeeID, LookupBL position, int userID) : base(userID)
        {
            EmployeeID = employeeID;
            Position = position;
        }
        public EmployeesBL(int employeeID,LookupBL position,DateTime hireDate,float salary,List<SalaryPayment> salaryPayments)
        {
            EmployeeID = employeeID;
            Position = position;
            HireDate = hireDate;
            this.salary=salary;
            
           
        }
        // Properties
        public int EmployeeID
        {
            get => employeeID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("EmployeeID must be positive.");
                employeeID = value;
            }
        }

        public LookupBL Position
        {
            get => position;
            set => position = value ?? throw new ArgumentNullException(nameof(Position));
        }

        public DateTime HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }

        public float Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }

        public List<SalaryPaymentBL> SalaryPayments
        {
            get => salaryPayments;
            set => salaryPayments = value ?? new List<SalaryPaymentBL>();
        }

        // 🔁 OVERRIDDEN POLYMORPHIC METHOD
        public override string GetUserType()
        {
            return "Employee";
        }

        // Optional - to load employees (could also go in a service class)
        public virtual List<EmployeesBL> LoadAllEmployees()
        {
            return DL.EmployeeDL.LoadAllEmployees(); // Ensure DL class exists
        }
    }
}
