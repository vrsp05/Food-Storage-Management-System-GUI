using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FSMS_GUI
{
    public class ExpirationChecker
    {
        // This method takes a list of all food items and returns only the ones that are expiring soon.
        public List<FoodItemData> GetExpiringItems(List<FoodItemData> allItems, int daysUntilExpiration)
        {
            List<FoodItemData> expiringItems = new List<FoodItemData>();
            DateTime today = DateTime.Now.Date;

            foreach (var item in allItems)
            {
                if (DateTime.TryParse(item._expirationDate, out DateTime expirationDate))
                {
                    // Calculate the difference in days
                    int dayDifference = (expirationDate.Date - today).Days;

                    // Check if the item is not yet expired but will expire within the specified timeframe
                    if (dayDifference >= 0 && dayDifference <= daysUntilExpiration)
                    {
                        expiringItems.Add(item);
                    }
                }
            }
            return expiringItems;
        }

        // This method takes a list of all food items and returns only the ones that have already expired.
        public List<FoodItemData> GetExpiredItems(List<FoodItemData> allItems)
        {
            List<FoodItemData> expiredItems = new List<FoodItemData>();
            DateTime today = DateTime.Now.Date;

            foreach (var item in allItems)
            {
                if (DateTime.TryParse(item._expirationDate, out DateTime expirationDate))
                {
                    // Check if the expiration date is in the past
                    if (expirationDate.Date < today)
                    {
                        expiredItems.Add(item);
                    }
                }
            }
            return expiredItems;
        }
    }
}