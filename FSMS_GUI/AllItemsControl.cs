using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class AllItemsControl : UserControl
    {
        private List<FoodItemData> _fullFoodList = new List<FoodItemData>();

        public AllItemsControl()
        {
            InitializeComponent();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        public void SetFullFoodList(List<FoodItemData> foodList)
        {
            _fullFoodList = foodList;
            dataGridView1.DataSource = _fullFoodList;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // ... (search logic is unchanged)
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dataGridView1.DataSource = _fullFoodList;
            }
            else
            {
                var filteredList = _fullFoodList.Where(item => item._name.ToLower().Contains(searchText)).ToList();
                dataGridView1.DataSource = filteredList;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FoodItemData selectedItem = dataGridView1.CurrentRow.DataBoundItem as FoodItemData;
            if (selectedItem == null) return;

            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete the item '{selectedItem._name}' (Code: {selectedItem._code})?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                {
                    bool success = mainForm.RemoveFoodItemByCode(selectedItem._code);
                    if (success)
                    {
                        // Raise the flag!
                        mainForm.SetUnsavedChanges();

                        mainForm.RefreshDataGrid();
                        MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Could not find the item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to edit.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MainForm mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                FoodItemData selectedItem = dataGridView1.CurrentRow.DataBoundItem as FoodItemData;
                if (selectedItem != null)
                {
                    mainForm.ShowEditItem(selectedItem);
                }
            }
        }
    }
}


