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
                             u.UserName AS AdminName, e.EmployeeName AS EmployeeName
                             FROM instructions i
                             JOIN users u ON i.AdminID = u.UserID
                             JOIN employees e ON i.EmployeeID = e.EmployeeID";

            DataTable dt = SqlHelper.getDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    new EmployeesBL(Convert.ToInt32(row["EmployeeID"]), row["EmployeeName"].ToString()),
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
            string query = @"SELECT i.*, u.UserName AS AdminName, e.EmployeeName AS EmployeeName
                             FROM instructions i
                             JOIN users u ON i.AdminID = u.UserID
                             JOIN employees e ON i.EmployeeID = e.EmployeeID
                             WHERE i.AdminID = @adminId";

            MySqlParameter[] param = { new MySqlParameter("@adminId", adminId) };
            DataTable dt = SqlHelper.getDataTable(query, param);

            List<InstructionBL> instructions = new List<InstructionBL>();
            foreach (DataRow row in dt.Rows)
            {
                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    new EmployeesBL(Convert.ToInt32(row["EmployeeID"]), row["EmployeeName"].ToString()),
                    row["InstructionText"].ToString(),
                    Convert.ToDateTime(row["SentDate"])
                );
                instructions.Add(instruction);
            }
            return instructions;
        }

        // Load by EmployeeID
        public static List<InstructionBL> LoadInstructionsByEmployeeId(int employeeId)
        {
            string query = @"SELECT i.*, u.UserName AS AdminName, e.EmployeeName AS EmployeeName
                             FROM instructions i
                             JOIN users u ON i.AdminID = u.UserID
                             JOIN employees e ON i.EmployeeID = e.EmployeeID
                             WHERE i.EmployeeID = @employeeId";

            MySqlParameter[] param = { new MySqlParameter("@employeeId", employeeId) };
            DataTable dt = SqlHelper.getDataTable(query, param);

            List<InstructionBL> instructions = new List<InstructionBL>();
            foreach (DataRow row in dt.Rows)
            {
                InstructionBL instruction = new InstructionBL(
                    Convert.ToInt32(row["InstructionID"]),
                    new UserBL(Convert.ToInt32(row["AdminID"]), row["AdminName"].ToString()),
                    new EmployeesBL(Convert.ToInt32(row["EmployeeID"]), row["EmployeeName"].ToString()),
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
            string query = @"INSERT INTO instructions (AdminID, EmployeeID, InstructionText, SentDate)
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
            string query = "DELETE FROM instructions WHERE InstructionID = @id";
            MySqlParameter[] param = { new MySqlParameter("@id", instructionId) };
            SqlHelper.executeDML(query, param);
        }
    }
}
