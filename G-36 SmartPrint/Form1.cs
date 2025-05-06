using System;
using System.Drawing;
using System.Windows.Forms;

namespace G_36_SmartPrint
{
    public partial class Form1 : Form
    {
        private bool isForgotPasswordVisible;
        private bool isLoginVisible;
        private int targetLeftPanelLeft;
        private int targetRightPanelLeft;
        private UI.ForgotPassword forgotPassword;

        public Form1()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            isLoginVisible = true;

            leftPanel.Left = 0;
            rightPanel.Left = 400;
            leftPanel.Visible = true;

            InitializeForgotPassword();
            SetupAnimation();
            UpdateWelcomeText();
            WireUpEvents();
        }

        private void InitializeForgotPassword()
        {
            forgotPassword = new UI.ForgotPassword();
            forgotPassword.Location = new Point(0, 0);
            forgotPassword.Size = new Size(400, 500);
            forgotPassword.Visible = false;
            //forgotPassword.BackToLoginLink.Click += BackToLoginLink_Click;
            rightPanel.Controls.Add(forgotPassword);
        }

        private void SetupAnimation()
        {
            slideTimer.Tick += SlideTimer_Tick;
            slideTimer.Interval = 1 ;
        }

        private void WireUpEvents()
        {
            btnSwitchToLogin.Click += BtnSwitchToLogin_Click;
            login.ForgotPasswordLink.Click += ForgotPasswordLink_Click;
        }

        private void BtnSwitchToLogin_Click(object sender, EventArgs e)
        {
            if (forgotPassword.Visible)
            {
                forgotPassword.Visible = false;
                login.Visible = true;
                signup.Visible = false;

                isLoginVisible = true;
                targetLeftPanelLeft = 0;
                targetRightPanelLeft = 400;

                leftPanel.Left = 0;
                rightPanel.Left = 400;

                UpdateControlsVisibility();
                UpdateWelcomeText();
                return;
            }

            TogglePanels();
        }

        private void TogglePanels()
        {
            if (forgotPassword.Visible)
            {
                forgotPassword.Visible = false;
                login.Visible = true;
                signup.Visible = false;
            }

            isLoginVisible = !isLoginVisible;

            targetLeftPanelLeft = isLoginVisible ? 0 : 400;
            targetRightPanelLeft = isLoginVisible ? 400 : 0;

            leftPanel.Visible = true;
            rightPanel.Visible = true;
            leftPanel.BringToFront();
            rightPanel.BringToFront();

            this.SuspendLayout();
            slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            bool leftDone = SlidePanelSmoothly(leftPanel, targetLeftPanelLeft);
            bool rightDone = SlidePanelSmoothly(rightPanel, targetRightPanelLeft);

            if (leftDone && rightDone)
            {
                slideTimer.Stop();

                if (!isLoginVisible)
                    leftPanel.Visible = false;

                UpdateControlsVisibility();
                UpdateWelcomeText();
                this.ResumeLayout();
            }
        }

        private bool SlidePanelSmoothly(Control panel, int target)
        {
            int current = panel.Left;
            int difference = target - current;

            int step = (int)(difference * 0.2);

            if (Math.Abs(step) < 1)
                step = difference > 0 ? 1 : -1;

            if (Math.Abs(difference) <= Math.Abs(step))
            {
                panel.Left = target;
                return true;
            }

            panel.Left += step;
            return false;
        }

        private int CalculateNewPosition(int current, int target)
        {
            int difference = target - current;

            // Apply easing for smoother animation
            int step = (int)(difference * 0.3);

            if (Math.Abs(step) < 5)
            {
                step = difference > 0 ? 5 : -5;
            }

            if (Math.Abs(difference) <= Math.Abs(step))
            {
                return target;
            }

            return current + step;
        }

        private void UpdateControlsVisibility()
        {
            if (forgotPassword.Visible) return;

            login.Visible = isLoginVisible;
            signup.Visible = !isLoginVisible;

            leftPanel.Visible = isLoginVisible || leftPanel.Left > -leftPanel.Width;
        }

        private void UpdateWelcomeText()
        {
            if (isLoginVisible)
            {
                lblWelcome.Text = "Welcome Back!";
                
                lblMessage.Text = "Don't have an account?";
                btnSwitchToLogin.Text = "SIGN UP";
            }
            else
            {
                lblWelcome.Text = "Hello, Friend! ";
                lblMessage.Text = "Already have an account?";
                btnSwitchToLogin.Text = "LOGIN";
            }
        }

        private void ForgotPasswordLink_Click(object sender, EventArgs e)
        {
            ShowForgotPassword();
        }

        private void ShowForgotPassword()
        {
            slideTimer.Stop();
            login.Visible = false;
            signup.Visible = false;
            forgotPassword.Visible = true;

            leftPanel.Visible = true;
            leftPanel.Left = 0;
            rightPanel.Left = 400;

            UpdateControlsVisibility();
            lblWelcome.Text = "Reset Password";
            lblMessage.Text = "We'll help you get back in";
            btnSwitchToLogin.Text = "LOGIN";
        }

        private void BackToLoginLink_Click(object sender, EventArgs e)
        {
            ShowLoginControl();
        }

        private void ShowLoginControl()
        {
            forgotPassword.Visible = false;
            isLoginVisible = true;

            targetLeftPanelLeft = 0;
            targetRightPanelLeft = 400;
            leftPanel.Left = 0;
            rightPanel.Left = 400;

            UpdateControlsVisibility();
            UpdateWelcomeText();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}