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
    public partial class ViewInstructions : UserControl
    {
        public ViewInstructions()
        {
            InitializeComponent();

            this.Load += GiveInstructions_Load;

        }

        private void GiveInstructions_Load(object sender, EventArgs e)
        {
            
            LoadInstructionsByAdmin();
            txtManagerName.Text = LoginHelpers.currentuser.getname();
           
        }

        private void LoadInstructionsByAdmin()
        {
            try
            {
                int adminId = LoginHelpers.currentEmployee.getuserID(); // Assuming this gets UserID of admin
                List<InstructionBL> instructions = InstructionDL.LoadInstructionsByEmployeeId(adminId);

                dgvRequests.Rows.Clear();
                dgvRequests.Columns.Clear();

                dgvRequests.Columns.Add("InstructionID", "Instruction ID");
                dgvRequests.Columns.Add("AdminName", "From Admin");
                dgvRequests.Columns.Add("Text", "Instruction Text");
                dgvRequests.Columns.Add("Date", "Sent Date");

                foreach (var instruction in instructions)
                {
                    dgvRequests.Rows.Add(
                        instruction.getInstructionId(),
                        instruction.getAdmin()?.getname() ?? "Unknown",
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

        private void DgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvRequests.RowCount) return;
            try
            {
                var row = dgvRequests.Rows[e.RowIndex];
               string orderId = (row.Cells["Text"].Value).ToString();
                guna2TextBox1.Text = orderId;
            }
            catch
            {
                MessageBox.Show("('_')! FUCK YOU!");
            }
                
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
