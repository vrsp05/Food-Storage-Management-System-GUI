namespace FSMS_GUI
{
    partial class AccountSettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnUpdateUsername = new Button();
            txtNewUsername = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnUpdateEmail = new Button();
            txtNewEmail = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnUpdatePassword = new Button();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            txtCurrentPassword = new TextBox();
            label3 = new Label();
            groupAccountDetails = new GroupBox();
            lblCurrentEmail = new Label();
            lblCurrentUsername = new Label();
            label7 = new Label();
            label6 = new Label();
            groupDeleteAccount = new GroupBox();
            btnDeleteAccount = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupAccountDetails.SuspendLayout();
            groupDeleteAccount.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateUsername);
            groupBox1.Controls.Add(txtNewUsername);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 137);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(467, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Username";
            // 
            // btnUpdateUsername
            // 
            btnUpdateUsername.Location = new Point(140, 63);
            btnUpdateUsername.Margin = new Padding(4, 3, 4, 3);
            btnUpdateUsername.Name = "btnUpdateUsername";
            btnUpdateUsername.Size = new Size(140, 27);
            btnUpdateUsername.TabIndex = 2;
            btnUpdateUsername.Text = "Update Username";
            btnUpdateUsername.UseVisualStyleBackColor = true;
            btnUpdateUsername.Click += btnUpdateUsername_Click;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(140, 29);
            txtNewUsername.Margin = new Padding(4, 3, 4, 3);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(291, 23);
            txtNewUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "New Username:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdateEmail);
            groupBox2.Controls.Add(txtNewEmail);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(18, 271);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(467, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Change Email";
            // 
            // btnUpdateEmail
            // 
            btnUpdateEmail.Location = new Point(140, 63);
            btnUpdateEmail.Margin = new Padding(4, 3, 4, 3);
            btnUpdateEmail.Name = "btnUpdateEmail";
            btnUpdateEmail.Size = new Size(140, 27);
            btnUpdateEmail.TabIndex = 2;
            btnUpdateEmail.Text = "Update Email";
            btnUpdateEmail.UseVisualStyleBackColor = true;
            btnUpdateEmail.Click += btnUpdateEmail_Click;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(140, 29);
            txtNewEmail.Margin = new Padding(4, 3, 4, 3);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(291, 23);
            txtNewEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "New Email:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUpdatePassword);
            groupBox3.Controls.Add(txtConfirmPassword);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtNewPassword);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtCurrentPassword);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(18, 408);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(467, 173);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Change Password";
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Location = new Point(140, 133);
            btnUpdatePassword.Margin = new Padding(4, 3, 4, 3);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(140, 27);
            btnUpdatePassword.TabIndex = 6;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(140, 98);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(291, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 102);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(140, 63);
            txtNewPassword.Margin = new Padding(4, 3, 4, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(291, 23);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 2;
            label4.Text = "New Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(140, 29);
            txtCurrentPassword.Margin = new Padding(4, 3, 4, 3);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(291, 23);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 0;
            label3.Text = "Current Password:";
            // 
            // groupAccountDetails
            // 
            groupAccountDetails.Controls.Add(lblCurrentEmail);
            groupAccountDetails.Controls.Add(lblCurrentUsername);
            groupAccountDetails.Controls.Add(label7);
            groupAccountDetails.Controls.Add(label6);
            groupAccountDetails.Location = new Point(18, 19);
            groupAccountDetails.Name = "groupAccountDetails";
            groupAccountDetails.Size = new Size(467, 100);
            groupAccountDetails.TabIndex = 3;
            groupAccountDetails.TabStop = false;
            groupAccountDetails.Text = "My Account Details";
            // 
            // lblCurrentEmail
            // 
            lblCurrentEmail.AutoSize = true;
            lblCurrentEmail.Location = new Point(140, 57);
            lblCurrentEmail.Name = "lblCurrentEmail";
            lblCurrentEmail.Size = new Size(0, 15);
            lblCurrentEmail.TabIndex = 3;
            // 
            // lblCurrentUsername
            // 
            lblCurrentUsername.AutoSize = true;
            lblCurrentUsername.Location = new Point(140, 29);
            lblCurrentUsername.Name = "lblCurrentUsername";
            lblCurrentUsername.Size = new Size(0, 15);
            lblCurrentUsername.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 57);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 1;
            label7.Text = "Current Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 29);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 0;
            label6.Text = "Current Username:";
            // 
            // groupDeleteAccount
            // 
            groupDeleteAccount.Controls.Add(btnDeleteAccount);
            groupDeleteAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupDeleteAccount.ForeColor = Color.Red;
            groupDeleteAccount.Location = new Point(18, 608);
            groupDeleteAccount.Name = "groupDeleteAccount";
            groupDeleteAccount.Size = new Size(467, 100);
            groupDeleteAccount.TabIndex = 4;
            groupDeleteAccount.TabStop = false;
            groupDeleteAccount.Text = "Danger Zone";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.MistyRose;
            btnDeleteAccount.Location = new Point(108, 44);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(208, 25);
            btnDeleteAccount.TabIndex = 0;
            btnDeleteAccount.Text = "Permanently Delete My Account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // AccountSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(groupDeleteAccount);
            Controls.Add(groupAccountDetails);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AccountSettingsControl";
            Size = new Size(509, 737);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupAccountDetails.ResumeLayout(false);
            groupAccountDetails.PerformLayout();
            groupDeleteAccount.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label3;
        private GroupBox groupAccountDetails;
        private Label lblCurrentEmail;
        private Label lblCurrentUsername;
        private Label label7;
        private Label label6;
        private GroupBox groupDeleteAccount;
        private Button btnDeleteAccount;
    }
}
