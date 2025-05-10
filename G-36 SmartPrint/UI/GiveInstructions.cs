using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;



namespace G_36_SmartPrint.UI
{
    public partial class GiveInstructions : UserControl
    {
        public GiveInstructions()
        {
            InitializeComponent();

            List<EmployeesBL> list = EmployeeDL.LoadEmployeesByPosition(3);
            cmbManagerName.Items.Clear();
            cmbManagerName.DataSource = list;
            cmbManagerName.DisplayMember = "userName";
            cmbManagerName.SelectedIndex = 0;
            cmbManagerName.ValueMember = "Employeeid";

        }

        private void cmbManagerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Load += GiveInstructions_Load;
        }

        private void GiveInstructions_Load(object sender, EventArgs e)
        {
            LoadManagerComboBox();
            LoadInstructionsByAdmin();
        }

        private void LoadInstructionsByAdmin()
        {
            try
            {
                int adminId = LoginHelpers.currentEmployee.getuserID(); // Assuming this gets UserID of admin
                List<InstructionBL> instructions = InstructionDL.LoadInstructionsByAdminId(adminId);

                dgvInstructions.Rows.Clear();
                dgvInstructions.Columns.Clear();

                dgvInstructions.Columns.Add("InstructionID", "Instruction ID");
                dgvInstructions.Columns.Add("EmployeeName", "Employee");
                dgvInstructions.Columns.Add("Text", "Instruction Text");
                dgvInstructions.Columns.Add("Date", "Sent Date");

                foreach (var instruction in instructions)
                {
                    dgvInstructions.Rows.Add(
                        instruction.getInstructionId(),
                        instruction.getEmployee()?.getName() ?? "Unknown",
                        instruction.getInstructionText(),
                        instruction.getSentDate().ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructions: " + ex.Message);
            }
        }

        private void LoadManagerComboBox()
        {
            try
            {
                List<EmployeesBL> managers = EmployeeDL.LoadEmployeesByPosition(3); // 3 = Manager

                cmbManagerName.DataSource = null;
                cmbManagerName.DisplayMember = "name";
                cmbManagerName.ValueMember = "employeeID";
                cmbManagerName.DataSource = managers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading managers: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbManagerName.SelectedItem == null || string.IsNullOrWhiteSpace(txtInstructions.Text))
                {
                    MessageBox.Show("Please select a manager and enter instruction text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int adminId = LoginHelpers.currentuser.getuserID(); // Admin userID
                EmployeesBL selectedEmployee = (EmployeesBL)cmbManagerName.SelectedItem;
                string instructionText = txtInstructions.Text.Trim();
                DateTime sentDate = DateTime.Now;

                InstructionBL newInstruction = new InstructionBL(
                    0,
                    new UserBL(adminId),
                    selectedEmployee,
                    instructionText,
                    sentDate
                );

                InstructionDL.InsertInstruction(newInstruction);

                LoadInstructionsByAdmin();
                txtInstructions.Clear();

                MessageBox.Show("Instruction sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending instruction: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInstructions.Clear();
            cmbManagerName.SelectedIndex = -1;
        }

        private void dgvInstructions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: implement if you want to allow interaction with grid
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom paint logic

        }
    }
}
