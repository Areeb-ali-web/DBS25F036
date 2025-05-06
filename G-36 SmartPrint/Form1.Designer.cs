namespace G_36_SmartPrint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rightPanel = new System.Windows.Forms.Panel();
            this.login = new G_36_SmartPrint.UI.Login();
            this.signup = new G_36_SmartPrint.UI.Signup();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.leftPanel = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
=======
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
>>>>>>> 99832090bcfaab0232d7475d3ad14fa87eb5dbad
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSwitchToLogin = new Guna.UI2.WinForms.Guna2Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.login);
            this.rightPanel.Controls.Add(this.signup);
            this.rightPanel.Location = new System.Drawing.Point(400, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(400, 500);
            this.rightPanel.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(400, 500);
            this.login.TabIndex = 0;
<<<<<<< HEAD
=======
            this.login.Load += new System.EventHandler(this.login_Load);
>>>>>>> 99832090bcfaab0232d7475d3ad14fa87eb5dbad
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup.BackgroundImage")));
            this.signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signup.Location = new System.Drawing.Point(0, 0);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(400, 500);
            this.signup.TabIndex = 1;
            this.signup.Visible = false;
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 10;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.leftPanel.BackgroundImage = global::G_36_SmartPrint.Properties.Resources.Sign;
            this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.guna2HtmlLabel1);
            this.leftPanel.Controls.Add(this.btnSwitchToLogin);
            this.leftPanel.Controls.Add(this.logoPictureBox);
            this.leftPanel.Controls.Add(this.lblWelcome);
            this.leftPanel.Controls.Add(this.lblMessage);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(400, 500);
            this.leftPanel.TabIndex = 0;
            // 
<<<<<<< HEAD
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(113, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Custom Design and Clothing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Smart Print";
=======
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Purple;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(96, 61);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(431, 47);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Custom Design and Clothing";
>>>>>>> 99832090bcfaab0232d7475d3ad14fa87eb5dbad
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Purple;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(147, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
<<<<<<< HEAD
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(133, 34);
=======
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(195, 50);
>>>>>>> 99832090bcfaab0232d7475d3ad14fa87eb5dbad
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Smart Print";
            // 
            // btnSwitchToLogin
            // 
            this.btnSwitchToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchToLogin.BorderRadius = 20;
            this.btnSwitchToLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSwitchToLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSwitchToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchToLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchToLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchToLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchToLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchToLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSwitchToLogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSwitchToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchToLogin.ForeColor = System.Drawing.Color.White;
            this.btnSwitchToLogin.Location = new System.Drawing.Point(132, 251);
            this.btnSwitchToLogin.Name = "btnSwitchToLogin";
            this.btnSwitchToLogin.PressedColor = System.Drawing.Color.Red;
            this.btnSwitchToLogin.Size = new System.Drawing.Size(138, 46);
            this.btnSwitchToLogin.TabIndex = 4;
            this.btnSwitchToLogin.Text = "SIGN UP";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::G_36_SmartPrint.Properties.Resources.log_removebg_preview;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(126, 124);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Purple;
            this.lblWelcome.Location = new System.Drawing.Point(88, 127);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(373, 65);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Purple;
            this.lblMessage.Location = new System.Drawing.Point(100, 208);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 40);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Don\'t have an account?";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to MyApp";
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private UI.Login login;
        private UI.Signup signup;
        private System.Windows.Forms.Timer slideTimer;
        private Guna.UI2.WinForms.Guna2Button btnSwitchToLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}