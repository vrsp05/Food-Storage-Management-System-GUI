using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class AddItemControl : UserControl
    {
        public FoodStorageManager? FoodManager { get; set; }
        public MainForm? MainForm { get; set; } // To call the new method

        public AddItemControl()
        {
            InitializeComponent();
            cmbLocation.Items.Add("Dry");
            cmbLocation.Items.Add("Freezer");
            cmbLocation.SelectedIndex = 0;
            numPrice.DecimalPlaces = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FoodManager == null || MainForm == null) return;

            string name = txtName.Text;
            string type = txtType.Text;
            // ... (other data gathering)

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please fill out all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FoodManager.AddNewFoodItem(name, type, dtpExpiration.Value, numPrice.Value, numQuantity.Value, cmbLocation.SelectedItem.ToString());

            // Raise the flag!
            MainForm.SetUnsavedChanges();

            MessageBox.Show("Item saved successfully to the current session!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear fields for next entry
            txtName.Clear();
            txtType.Clear();
        }
    }
}

