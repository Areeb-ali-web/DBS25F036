using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DL
{
    internal class EmployeeDL
    {
        public static List<EmployeesBL> LoadAllEmployees()
        {
            List<EmployeesBL> employees = new List<EmployeesBL>();

            string query = @"
                SELECT 
                    e.employeeID, e.positionID, e.hireDate, e.salary,
                    u.userID, u.username, u.passwordHash, u.email, u.name, u.phone_number, u.creationDate, u.roleID,
                    pos.lookupvalue AS positionName
                FROM 
                    Employee e
                INNER JOIN Users u ON e.userID = u.userID
                INNER JOIN Lookuptable pos ON e.positionID = pos.lookupID";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int employeeID = Convert.ToInt32(row["employeeID"]);
                int userID = Convert.ToInt32(row["userID"]);
                string username = row["username"].ToString();
                string passwordHash = row["passwordHash"].ToString();
                string email = row["email"].ToString();
                string name = row["name"].ToString();
                string phoneNumber = row["phone_number"].ToString();
                DateTime creationDate = Convert.ToDateTime(row["creationDate"]);
                DateTime hireDate = Convert.ToDateTime(row["hireDate"]);
                float salary = Convert.ToSingle(row["salary"]);

                int positionID = Convert.ToInt32(row["positionID"]);
                string positionName = row["positionName"].ToString();
                LookupBL position = new LookupBL(positionID, positionName);

                int roleID = Convert.ToInt32(row["roleID"]);
                LookupBL role = new LookupBL(roleID); // You can also fetch role name if needed

                EmployeesBL emp = new EmployeesBL(employeeID, position, hireDate, salary,
                                                  username, passwordHash, email, name, phoneNumber, creationDate, role);

                emp.setUserID(userID); // If needed to set userID manually
                employees.Add(emp);
            }

            return employees;
        }
    }
}
