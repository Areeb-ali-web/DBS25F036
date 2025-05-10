using System;

namespace G_36_SmartPrint.BL
{
    internal class InstructionBL
    {
        private int instructionId;
        private UserBL admin;
        private EmployeesBL employee;
        private string instructionText;
        private DateTime sentDate;

        public InstructionBL() { }

        public InstructionBL(int instructionId, UserBL admin, EmployeesBL employee, string instructionText, DateTime sentDate)
        {
            this.instructionId = instructionId;
            this.admin = admin;
            this.employee = employee;
            this.instructionText = instructionText;
            this.sentDate = sentDate;
        }

        // Getters and Setters
        public int getInstructionId()
        {
            return instructionId;
        }

        public void setInstructionId(int id)
        {
            this.instructionId = id;
        }

        public UserBL getAdmin()
        {
            return admin;
        }

        public void setAdmin(UserBL admin)
        {
            this.admin = admin;
        }

        public EmployeesBL getEmployee()
        {
            return employee;
        }

        public void setEmployee(EmployeesBL employee)
        {
            this.employee = employee;
        }

        public string getInstructionText()
        {
            return instructionText;
        }

        public void setInstructionText(string text)
        {
            this.instructionText = text;
        }

        public DateTime getSentDate()
        {
            return sentDate;
        }

        public void setSentDate(DateTime date)
        {
            this.sentDate = date;
        }

        public override string ToString()
        {
            return $"InstructionID: {instructionId}, Admin: {admin?.getUserName()}, Employee: {employee?.getUserName()}, Text: {instructionText}, SentDate: {sentDate}";
        }
    }
}
