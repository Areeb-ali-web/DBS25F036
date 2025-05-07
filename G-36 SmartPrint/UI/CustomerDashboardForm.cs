using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace G_36_SmartPrint.UI
{
    public partial class CustomerDashboardForm : Form
    {
        private int currentCustomerId;

        public CustomerDashboardForm()
        {
            InitializeComponent();
            InitializeDashboard();
            AssignButtonEvents();
        }

        public void SetCurrentCustomer(int customerId)
        {
            this.currentCustomerId = customerId;
        }

        private void InitializeDashboard()
        {
            SetActiveButton(btnDashboard);
            LoadUserControl(new CustomerBoard(currentCustomerId));
        }

        private void AssignButtonEvents()
        {
            btnDashboard.Click += NavigationButton_Click;
            btnOrder.Click += NavigationButton_Click;
            btnApprove.Click += NavigationButton_Click;
            btnFeedback.Click += NavigationButton_Click;
            btnView.Click += NavigationButton_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Guna2Button;
            if (clickedButton == null) return;

            SetActiveButton(clickedButton);

            switch (clickedButton.Name)
            {
                case "btnDashboard":
                    LoadUserControl(new CustomerBoard(currentCustomerId));
                    break;
                case "btnOrder":
                    LoadUserControl(new Order());
                    break;
                case "btnApprove":
                    LoadUserControl(new DesignApproval());
                    break;
                case "btnFeedback":
                    LoadUserControl(new Feedback());
                    break;
                //case "btnView":
                //    LoadUserControl(new ViewOrders());
                //    break;
            }
        }

        private void SetActiveButton(Guna2Button activeButton)
        {
            // Reset all buttons
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.FillColor = Color.FromArgb(51, 51, 51);
                    button.Font = new Font(button.Font, FontStyle.Regular);
                }
            }

            // Set active button
            activeButton.FillColor = Color.FromArgb(41, 128, 185);
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

        private void LoadUserControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.ShowDialog();
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

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}