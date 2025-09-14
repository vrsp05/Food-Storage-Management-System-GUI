using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class MainForm : Form
    {
        private AccountManager _currentAccountManager;
        private FoodStorageManager _foodStorageManager;
        private ExpirationChecker _expirationChecker;
        private EmailService? _emailService;

        // --- FIX: Re-adding the 'unsaved changes' flag ---
        private bool _hasUnsavedChanges = false;

        private AllItemsControl? _allItemsControl;
        private AddItemControl? _addItemControl;
        private EditItemControl? _editItemControl;
        private DashboardControl? _dashboardControl;
        private AccountSettingsControl? _accountSettingsControl;

        public MainForm(AccountManager accountManager)
        {
            InitializeComponent();
            _currentAccountManager = accountManager;
            UpdateUserInfo();

            _foodStorageManager = new FoodStorageManager();
            _expirationChecker = new ExpirationChecker();
            _foodStorageManager.LoadFoodItemsForUser(_currentAccountManager._loggedInUserName);

            _emailService = new EmailService();

            ShowDashboard();

            // Connect our unsaved changes logic to the form's closing event
            this.FormClosing += MainForm_FormClosing;
        }

        // --- HELPER METHODS ---

        // --- FIX: Re-adding the public method to set the flag ---
        public void SetUnsavedChanges()
        {
            _hasUnsavedChanges = true;
        }

        public void UpdateUserInfo()
        {
            lblWelcome.Text = $"Welcome, {_currentAccountManager._loggedInUserName}!";
        }

        public void RefreshDataGrid()
        {
            if (_allItemsControl != null)
            {
                _allItemsControl.SetFullFoodList(_foodStorageManager.GetFoodItemData());
            }
        }

        public bool RemoveFoodItemByCode(string itemCode)
        {
            return _foodStorageManager.RemoveFoodItem(itemCode);
        }

        public void ShowAllItems()
        {
            if (_allItemsControl != null)
            {
                _allItemsControl.BringToFront();
            }
        }

        public void ShowEditItem(FoodItemData itemToEdit)
        {
            if (_editItemControl == null)
            {
                _editItemControl = new EditItemControl();
                _editItemControl.Dock = DockStyle.Fill;
                _editItemControl.FoodManager = _foodStorageManager;
                _editItemControl.MainForm = this;
                panelMain.Controls.Add(_editItemControl);
            }
            _editItemControl.LoadItemData(itemToEdit);
            _editItemControl.BringToFront();
        }

        public void ShowDashboard()
        {
            if (_dashboardControl == null)
            {
                _dashboardControl = new DashboardControl();
                _dashboardControl.Dock = DockStyle.Fill;
                panelMain.Controls.Add(_dashboardControl);
            }
            _dashboardControl.LoadDashboardData(_foodStorageManager);
            // --- FIX: Correcting the typo ---
            _dashboardControl.BringToFront();
        }

        private void ShowAccountSettings()
        {
            if (_accountSettingsControl == null)
            {
                _accountSettingsControl = new AccountSettingsControl();
                _accountSettingsControl.Dock = DockStyle.Fill;
                _accountSettingsControl.MainForm = this;
                panelMain.Controls.Add(_accountSettingsControl);
            }
            _accountSettingsControl.SetAccountManager(_currentAccountManager);
            _accountSettingsControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            using (var confirmForm = new PasswordConfirmForm())
            {
                var result = confirmForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (confirmForm.EnteredPassword == _currentAccountManager._loggedInPassword)
                    {
                        ShowAccountSettings();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAllItems_Click(object? sender, EventArgs e)
        {
            if (_allItemsControl == null)
            {
                _allItemsControl = new AllItemsControl();
                _allItemsControl.Dock = DockStyle.Fill;
                panelMain.Controls.Add(_allItemsControl);
            }
            RefreshDataGrid();
            _allItemsControl.BringToFront();
        }

        private void btnAddItem_Click(object? sender, EventArgs e)
        {
            if (_addItemControl == null)
            {
                _addItemControl = new AddItemControl();
                _addItemControl.Dock = DockStyle.Fill;
                _addItemControl.FoodManager = _foodStorageManager;
                _addItemControl.MainForm = this;
                panelMain.Controls.Add(_addItemControl);
            }
            _addItemControl.BringToFront();
        }

        private void btnSaveAndExit_Click(object? sender, EventArgs e)
        {
            if (_emailService == null)
            {
                MessageBox.Show("Email service is not configured.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var allItems = _foodStorageManager.GetFoodItemData();
                var expiring = _expirationChecker.GetExpiringItems(allItems, 7);
                var expired = _expirationChecker.GetExpiredItems(allItems);
                string body = _emailService.GenerateEmailBody(expiring, expired, _currentAccountManager._loggedInUserName);
                var emailResult = _emailService.SendEmail("Your Food Storage Summary", body, _currentAccountManager._loggedInEmail);
                MessageBox.Show(emailResult.message, emailResult.success ? "Email Sent" : "Email Error", MessageBoxButtons.OK, emailResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }

            _foodStorageManager.SaveFoodItemsForUser(_currentAccountManager._loggedInUserName);
            _hasUnsavedChanges = false; // Reset the flag after saving
            MessageBox.Show("Your data has been saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // --- FIX: Re-adding the FormClosing event handler ---
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasUnsavedChanges)
            {
                var result = MessageBox.Show(
                    "You have unsaved changes. Would you like to save them before exiting?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        _foodStorageManager.SaveFoodItemsForUser(_currentAccountManager._loggedInUserName);
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}


