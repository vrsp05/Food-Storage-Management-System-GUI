using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        // A special method to load the data into our dashboard grids
        public void LoadDashboardData(FoodStorageManager foodManager)
        {
            // Create an instance of our checker
            var expirationChecker = new ExpirationChecker();

            // Get all food items from the manager
            var allItems = foodManager.GetFoodItemData();

            // Find and display the items that are expiring soon
            var expiringSoon = expirationChecker.GetExpiringItems(allItems, 7); // Check for items expiring in the next 7 days
            dgvExpiringSoon.DataSource = expiringSoon;

            // Find and display the items that have already expired
            var expired = expirationChecker.GetExpiredItems(allItems);
            dgvExpired.DataSource = expired;
        }
    }
}

