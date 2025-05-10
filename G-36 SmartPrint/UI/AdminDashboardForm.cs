using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace G_36_SmartPrint.UI
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();

            // Enable double buffering
            this.DoubleBuffered = true;
            SetDoubleBuffered(panelMain);

            InitializeDashboard();
            AssignButtonEvents();
        }

        // Helper method to enable double buffering for controls
        private static void SetDoubleBuffered(Control control)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo prop = typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            prop?.SetValue(control, true, null);
        }

        private void InitializeDashboard()
        {
            SetActiveButton(btnDashboard);
            // LoadUserControl(new DashboardControl());
        }

        private void AssignButtonEvents()
        {
            btnDashboard.Click += NavigationButton_Click;
            btnManager.Click += NavigationButton_Click;
            btnAddDesigner.Click += NavigationButton_Click;
            btnDelivery.Click += NavigationButton_Click;
            btnProducts.Click += NavigationButton_Click;
            btnManageSalary.Click += NavigationButton_Click;
            btnInstuctions.Click += NavigationButton_Click;
            btnFinancal.Click += NavigationButton_Click;
            btnViewFeedback.Click += NavigationButton_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Guna2Button;
            if (clickedButton == null) return;

            SetActiveButton(clickedButton);

            panelMain.SuspendLayout();
            try
            {
                switch (clickedButton.Name)
                {
                    case "btnDashboard":
                        // LoadUserControl(new DashboardControl());
                        break;
                    case "btnManager":
                        LoadUserControl(new ManageManager());
                        break;
                    case "btnAddDesigner":
                        LoadUserControl(new ManageDesigner());
                        break;
                    case "btnDelivery":
                        LoadUserControl(new ManageDeliveryMan());
                        break;
                    case "btnProducts":
                        LoadUserControl(new ManageProducts());
                        break;
                    case "btnManageSalary":
                        LoadUserControl(new SalaryPayment());
                        break;
                    case "btnInstuctions":
                        LoadUserControl(new GiveInstructions());
                        break;
                    case "btnFinancal":
                         LoadUserControl(new ViewFinancialReport());
                        break;
                    case "btnViewFeedback":
                        LoadUserControl(new ViewFeedback());
                        break;
                }
            }
            finally
            {
                panelMain.ResumeLayout(true);
            }
        }

        private void SetActiveButton(Guna2Button activeButton)
        {
            // Reset all buttons
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.FillColor = Color.FromArgb(0, 0, 192);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                    button.ForeColor = Color.White;
                }
            }

            // Set active button
            activeButton.FillColor = Color.FromArgb(41, 128, 185);
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

        private void LoadUserControl(UserControl userControl)
        {
            SetDoubleBuffered(userControl);
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
            panelMain.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.Width < 1000)
            {
                lblCompanyName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            }
            else
            {
                lblCompanyName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            }
        }
    }
}