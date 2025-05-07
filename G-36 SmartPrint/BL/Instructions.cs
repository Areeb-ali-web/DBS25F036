using System;
using G_36_SmartPrint.DL;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
namespace G_36_SmartPrint.BL
{
    internal class Instructions
    {
        public int InstructionId { get; private set; }
        public UserBL Admin { get; private set; }
        public EmployeesBL Employee { get; private set; }
        public string InstructionText { get; private set; }
        public DateTime SentDate { get; private set; }

        // Default constructor
        public Instructions() { }

        // Constructor with all fields
        public Instructions(int instructionId, UserBL admin, EmployeesBL employee, string instructionText, DateTime sentDate)
        {
            InstructionId = instructionId;
            Admin = admin;
            Employee = employee;
            InstructionText = instructionText;
            SentDate = sentDate;
        }

        // Constructor without instructionId (for creating new instructions)
        public Instructions(UserBL admin, EmployeesBL employee, string instructionText, DateTime sentDate)
        {
            Admin = admin;
            Employee = employee;
            InstructionText = instructionText;
            SentDate = sentDate;
        }
    
        public override string ToString()
        {
            return $"Instruction [ID={InstructionId}] from Admin {Admin?.getname()} to Employee {Employee?.getName()} on {SentDate}: {InstructionText}";
        }
    }
}
