using System;
using System.Globalization;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class EditItemControl : UserControl
    {
        public FoodStorageManager? FoodManager { get; set; }
        public MainForm? MainForm { get; set; }

        public EditItemControl()
        {
            InitializeComponent();
            cmbLocation.Items.Add("Dry");
            cmbLocation.Items.Add("Freezer");
            numPrice.DecimalPlaces = 2;
        }

        public void LoadItemData(FoodItemData item)
        {
            ItemCodelbl.Text = item._code;
            txtName.Text = item._name;
            txtType.Text = item._type;

            if (DateTime.TryParse(item._expirationDate, out DateTime expDate))
            {
                dtpExpiration.Value = expDate;
            }

            numPrice.Value = (decimal)item._price;
            numQuantity.Value = item._quantity;
            cmbLocation.SelectedItem = item._storageLocation;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (FoodManager == null || MainForm == null) return;

            if (string.IsNullOrWhiteSpace(ItemCodelbl.Text))
            {
                MessageBox.Show("Could not find the original item's code. Cannot save.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ... (gather data) ...
            string code = ItemCodelbl.Text;
            string name = txtName.Text;
            // ... etc.

            bool success = FoodManager.UpdateFoodItem(code, name, txtType.Text, dtpExpiration.Value, numPrice.Value, numQuantity.Value, cmbLocation.SelectedItem.ToString());

            if (success)
            {
                // Raise the flag!
                MainForm.SetUnsavedChanges();

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.RefreshDataGrid();
                MainForm.ShowAllItems();
            }
            else
            {
                MessageBox.Show("Could not find the item to update in the main list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}