using G_36_SmartPrint.BL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace G_36_SmartPrint.DL
{
    internal class InstructionDL
    {
        // Load all instructions
        public static List<InstructionBL> LoadAllInstructions()
        {
            List<InstructionBL> instructions = new List<InstructionBL>();
            string query = @"SELECT i.InstructionID, i.AdminID, i.EmployeeID, i.InstructionText, i.SentDate,
                             u.UserName AS AdminName
                             FROM instruction i
                             JOIN users u ON i.AdminID = u.UserID
                             JOIN employee e ON i.EmployeeID = e.EmployeeID";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int employeeid = (Convert.ToInt32((row["EmployeeID"]).ToString()));
                EmployeesBL employee =EmployeeDL.LoadEmployeeById(employeeid);
                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    employee,
                    row["InstructionText"].ToString(),
                    Convert.ToDateTime(row["SentDate"])
                );
                instructions.Add(instruction);
            }
            return instructions;
        }

        // Load by AdminID
        public static List<InstructionBL> LoadInstructionsByAdminId(int adminId)
        {
            List<InstructionBL> instructions = new List<InstructionBL>();

            string query = @"SELECT i.InstructionID, i.AdminID, i.EmployeeID, i.InstructionText, i.SentDate,
                            u.UserName AS AdminName
                     FROM instruction i
                     JOIN users u ON i.AdminID = u.UserID
                     JOIN employee e ON i.EmployeeID = e.EmployeeID
                     WHERE i.AdminID = @adminId";

            MySqlParameter[] param = { new MySqlParameter("@adminId", adminId) };
            DataTable dt = SqlHelper.getDataTable(query, param);

            foreach (DataRow row in dt.Rows)
            {
                int employeeId = Convert.ToInt32(row["EmployeeID"]);
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(employeeId);

                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    employee,
                    row["InstructionText"].ToString(),
                    Convert.ToDateTime(row["SentDate"])
                );
                instructions.Add(instruction);
            }

            return instructions;
        }


        public static List<InstructionBL> LoadInstructionsByEmployeeId(int employeeId)
        {
            List<InstructionBL> instructions = new List<InstructionBL>();

            string query = @"SELECT i.InstructionID, i.AdminID, i.EmployeeID, i.InstructionText, i.SentDate,
                            u.UserName AS AdminName
                     FROM instruction i
                     JOIN users u ON i.AdminID = u.UserID
                     JOIN employee e ON i.EmployeeID = e.EmployeeID
                     WHERE i.EmployeeID = @employeeId";

            MySqlParameter[] param = { new MySqlParameter("@employeeId", employeeId) };
            DataTable dt = SqlHelper.getDataTable(query, param);

            foreach (DataRow row in dt.Rows)
            {
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(employeeId);

                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    employee,
                    row["InstructionText"].ToString(),
                    Convert.ToDateTime(row["SentDate"])
                );
                instructions.Add(instruction);
            }

            return instructions;
        }

        // Insert a new instruction
        public static void InsertInstruction(InstructionBL instruction)
        {
            string query = @"INSERT INTO instruction (AdminID, EmployeeID, InstructionText, SentDate)
                             VALUES (@adminId, @employeeId, @text, @date)";

            MySqlParameter[] param = {
                new MySqlParameter("@adminId", instruction.getAdmin().getUserID()),
                new MySqlParameter("@employeeId", instruction.getEmployee().getEmployeeID()),
                new MySqlParameter("@text", instruction.getInstructionText()),
                new MySqlParameter("@date", instruction.getSentDate())
            };

            SqlHelper.executeDML(query, param);
        }

        // Delete instruction by InstructionID
        public static void DeleteInstructionById(int instructionId)
        {
            string query = "DELETE FROM instruction WHERE InstructionID = @id";
            MySqlParameter[] param = { new MySqlParameter("@id", instructionId) };
            SqlHelper.executeDML(query, param);
        }
    }
}
