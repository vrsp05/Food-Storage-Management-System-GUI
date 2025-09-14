using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class AccountSettingsControl : UserControl
    {
        private AccountManager? _accountManager;
        public MainForm? MainForm { get; set; }

        public AccountSettingsControl()
        {
            InitializeComponent();
        }

        public void SetAccountManager(AccountManager manager)
        {
            _accountManager = manager;
            if (_accountManager != null)
            {
                lblCurrentUsername.Text = _accountManager._loggedInUserName;
                lblCurrentEmail.Text = _accountManager._loggedInEmail;
            }
        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            if (_accountManager == null || MainForm == null) return;
            string newUsername = txtNewUsername.Text;

            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("New username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- NEW CHECK ---
            var usernameEmailCheck = ValidationService.ValidateUsernameAndEmail(newUsername, _accountManager._loggedInEmail);
            if (!usernameEmailCheck.IsValid)
            {
                MessageBox.Show(usernameEmailCheck.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _accountManager.ChangeUsername(newUsername);
            if (result.success)
            {
                lblCurrentUsername.Text = _accountManager._loggedInUserName;
                MainForm.UpdateUserInfo();
                MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewUsername.Clear();
                MainForm.ShowDashboard();
            }
            else
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            if (_accountManager == null || MainForm == null) return;
            string newEmail = txtNewEmail.Text;

            var emailValidation = ValidationService.ValidateEmail(newEmail);
            if (!emailValidation.IsValid)
            {
                MessageBox.Show(emailValidation.ErrorMessage, "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // We also need to check the new email against the CURRENT username
            var usernameEmailCheck = ValidationService.ValidateUsernameAndEmail(_accountManager._loggedInUserName, newEmail);
            if (!usernameEmailCheck.IsValid)
            {
                MessageBox.Show(usernameEmailCheck.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _accountManager.ChangeEmail(newEmail);
            if (result.success)
            {
                lblCurrentEmail.Text = _accountManager._loggedInEmail;
                MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewEmail.Clear();
                MainForm.ShowDashboard();
            }
            else
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ... rest of the code is unchanged ...
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (_accountManager == null || MainForm == null) return;

            string currentPass = txtCurrentPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPass) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Please fill in all password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordValidation = ValidationService.ValidatePasswordStrength(newPass, _accountManager._loggedInUserName, _accountManager._loggedInEmail);
            if (!passwordValidation.IsValid)
            {
                MessageBox.Show(passwordValidation.ErrorMessage, "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _accountManager.ChangePassword(currentPass, newPass, confirmPass);
            MessageBox.Show(result.message, result.success ? "Success" : "Error", MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            if (result.success)
            {
                MainForm.ShowDashboard();
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (_accountManager == null) return;

            DialogResult confirmation = MessageBox.Show(
                "Are you absolutely sure you want to permanently delete your account?\n\n" +
                "All of your account information and saved food data will be lost forever. This action cannot be undone.",
                "Confirm Permanent Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                var result = _accountManager.DeleteAccount();
                MessageBox.Show(result.message, "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}




