using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class LoginForm : Form
    {
        private AccountManager _accountManager;
        public AccountManager? LoggedInAccountManager { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            panelRegister.BringToFront();
            panelLogin.BringToFront();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var result = _accountManager.Login(email, password);
            if (result.success)
            {
                LoggedInAccountManager = result.manager;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMessage.Text = result.message;
            }
        }

        private void btnCreateAccount_Click(object? sender, EventArgs e)
        {
            string newName = txtNewName.Text;
            string newEmail = txtNewEmail.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emailValidation = ValidationService.ValidateEmail(newEmail);
            if (!emailValidation.IsValid)
            {
                MessageBox.Show(emailValidation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- NEW CHECK ---
            var usernameEmailCheck = ValidationService.ValidateUsernameAndEmail(newName, newEmail);
            if (!usernameEmailCheck.IsValid)
            {
                MessageBox.Show(usernameEmailCheck.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The passwords you entered do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordValidation = ValidationService.ValidatePasswordStrength(newPassword, newName, newEmail);
            if (!passwordValidation.IsValid)
            {
                MessageBox.Show(passwordValidation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _accountManager.CreateAccount(newName, newEmail, newPassword);

            if (result.success)
            {
                MessageBox.Show("Hooray! Your account was created! Please log in.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkLogin_LinkClicked(null, null);
            }
            else
            {
                MessageBox.Show(result.message, "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkCreateAccount_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegister.BringToFront();
            ClearAllFields();
            this.AcceptButton = btnCreateAccount;
        }

        private void linkLogin_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.BringToFront();
            ClearAllFields();
            this.AcceptButton = btnLogin;
        }

        private void ClearAllFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtNewName.Clear();
            txtNewEmail.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            lblMessage.Text = "";
        }
    }
}

