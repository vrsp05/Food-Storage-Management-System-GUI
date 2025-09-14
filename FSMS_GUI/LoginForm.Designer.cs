namespace FSMS_GUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            lblMessage = new Label();
            linkCreateAccount = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblLoginTitle = new Label();
            panelRegister = new Panel();
            linkLogin = new LinkLabel();
            btnCreateAccount = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmReg = new Label();
            txtNewPassword = new TextBox();
            lblPasswordReg = new Label();
            txtNewEmail = new TextBox();
            lblEmailReg = new Label();
            txtNewName = new TextBox();
            lblNameReg = new Label();
            lblRegisterTitle = new Label();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblMessage);
            panelLogin.Controls.Add(linkCreateAccount);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(lblEmail);
            panelLogin.Controls.Add(lblLoginTitle);
            panelLogin.Location = new Point(12, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(560, 440);
            panelLogin.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(0, 419);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 7;
            // 
            // linkCreateAccount
            // 
            linkCreateAccount.AutoSize = true;
            linkCreateAccount.Location = new Point(162, 129);
            linkCreateAccount.Name = "linkCreateAccount";
            linkCreateAccount.Size = new Size(194, 15);
            linkCreateAccount.TabIndex = 6;
            linkCreateAccount.TabStop = true;
            linkCreateAccount.Text = "Don't have an account? Create one.";
            linkCreateAccount.LinkClicked += linkCreateAccount_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(162, 103);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(0, 67);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 30);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(0, 37);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(156, 30);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Address:";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(0, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(201, 37);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login to FSMS";
            lblLoginTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(linkLogin);
            panelRegister.Controls.Add(btnCreateAccount);
            panelRegister.Controls.Add(txtConfirmPassword);
            panelRegister.Controls.Add(lblConfirmReg);
            panelRegister.Controls.Add(txtNewPassword);
            panelRegister.Controls.Add(lblPasswordReg);
            panelRegister.Controls.Add(txtNewEmail);
            panelRegister.Controls.Add(lblEmailReg);
            panelRegister.Controls.Add(txtNewName);
            panelRegister.Controls.Add(lblNameReg);
            panelRegister.Controls.Add(lblRegisterTitle);
            panelRegister.Location = new Point(12, 12);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(560, 440);
            panelRegister.TabIndex = 1;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(203, 189);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(178, 15);
            linkLogin.TabIndex = 10;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Login.";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(203, 163);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(179, 23);
            btnCreateAccount.TabIndex = 9;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(203, 134);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(179, 23);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmReg
            // 
            lblConfirmReg.AutoSize = true;
            lblConfirmReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmReg.Location = new Point(0, 125);
            lblConfirmReg.Name = "lblConfirmReg";
            lblConfirmReg.Size = new Size(197, 30);
            lblConfirmReg.TabIndex = 7;
            lblConfirmReg.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(203, 104);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(179, 23);
            txtNewPassword.TabIndex = 6;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordReg
            // 
            lblPasswordReg.AutoSize = true;
            lblPasswordReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordReg.Location = new Point(0, 95);
            lblPasswordReg.Name = "lblPasswordReg";
            lblPasswordReg.Size = new Size(179, 30);
            lblPasswordReg.TabIndex = 5;
            lblPasswordReg.Text = "Create Password:";
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(203, 76);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(179, 23);
            txtNewEmail.TabIndex = 4;
            // 
            // lblEmailReg
            // 
            lblEmailReg.AutoSize = true;
            lblEmailReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailReg.Location = new Point(0, 67);
            lblEmailReg.Name = "lblEmailReg";
            lblEmailReg.Size = new Size(156, 30);
            lblEmailReg.TabIndex = 3;
            lblEmailReg.Text = "Email Address:";
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(203, 46);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(179, 23);
            txtNewName.TabIndex = 2;
            // 
            // lblNameReg
            // 
            lblNameReg.AutoSize = true;
            lblNameReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameReg.Location = new Point(0, 37);
            lblNameReg.Name = "lblNameReg";
            lblNameReg.Size = new Size(165, 30);
            lblNameReg.TabIndex = 1;
            lblNameReg.Text = "Your username:";
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterTitle.Location = new Point(0, 0);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(278, 37);
            lblRegisterTitle.TabIndex = 0;
            lblRegisterTitle.Text = "Create Your Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(584, 461);
            Controls.Add(panelLogin);
            Controls.Add(panelRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FSMS - Welcome!";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Panel panelRegister;
        private Label lblLoginTitle;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private LinkLabel linkCreateAccount;
        private Label lblMessage;
        private Label lblRegisterTitle;
        private Label lblEmailReg;
        private TextBox txtNewName;
        private Label lblNameReg;
        private Label lblPasswordReg;
        private TextBox txtNewEmail;
        private TextBox txtNewPassword;
        private Label lblConfirmReg;
        private LinkLabel linkLogin;
        private Button btnCreateAccount;
        private TextBox txtConfirmPassword;
    }
}
