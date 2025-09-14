using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Added for parsing logic

namespace FSMS_GUI
{
    public class FoodStorageManager
    {
        private List<string> _allFoodItems = new List<string>();
        private DryItems _dryItems = new DryItems();
        private FreezerItems _freezerItems = new FreezerItems();

        public void LoadFoodItemsForUser(string username)
        {
            _allFoodItems.Clear();

            string filePath = $"{username}_foodDATA.txt";

            if (!File.Exists(filePath))
            {
                _allFoodItems.Add("D-1234,Apples,Fruit,12/25/2025,false,1.99,10,dry,09/10/2025");
                _allFoodItems.Add("F-5678,Chicken,Meat,10/15/2025,false,8.50,2,freezer,09/01/2025");
            }
            else
            {
                try
                {
                    var allLines = File.ReadAllLines(filePath);
                    for (int i = 0; i < allLines.Length; i++)
                    {
                        if (allLines[i].Contains(". Code:"))
                        {
                            try
                            {
                                string line1 = allLines[i];
                                string line2 = allLines[i + 1];
                                string line3 = allLines[i + 2];

                                string code = line1.Split('|')[0].Split(':')[1].Trim();
                                string name = line1.Split('|')[1].Split(':')[1].Trim();
                                string statusString = line1.Split('|')[2].Split(':')[1].Trim();
                                bool isExpired = statusString == "Expired";
                                string type = line2.Split('|')[0].Split(':')[1].Trim();
                                string expiration = line2.Split('|')[1].Split(':')[1].Trim();
                                string price = line2.Split('|')[2].Split(':')[1].Trim();
                                string quantity = line3.Split('|')[0].Split(':')[1].Trim();
                                string location = line3.Split('|')[1].Split(':')[1].Trim();
                                string dateAdded = line3.Split('|')[2].Split(':')[1].Trim();

                                string formattedItem = $"{code},{name},{type},{expiration},{isExpired},{price},{quantity},{location},{dateAdded}";
                                _allFoodItems.Add(formattedItem);
                                _dryItems.AddExistingUniqueCodes(code);
                            }
                            catch { }
                        }
                    }
                }
                catch { }
            }
        }

        public void SaveFoodItemsForUser(string username)
        {
            string filePath = $"{username}_foodDATA.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Here are your current saved items:");
                int listNumber = 1;
                foreach (string item in _allFoodItems)
                {
                    string[] foodParts = item.Split(',');
                    writer.WriteLine(@$"
__________________________________________________
{listNumber}. Code: {foodParts[0]} |Name: {foodParts[1]} |Status: {(bool.Parse(foodParts[4]) ? "Expired" : "Good")}
Type: {foodParts[2]} |Expiration: {foodParts[3]} |Price: {foodParts[5]}
Quantity: {foodParts[6]} |Location: {foodParts[7]} |Date Added: {foodParts[8]}
__________________________________________________");
                    listNumber++;
                }
                writer.WriteLine("\nEnd of the file.");
            }
        }

        public void AddNewFoodItem(string name, string type, DateTime expiration, decimal price, decimal quantity, string location)
        {
            string code = location.ToLower() == "dry" ? _dryItems.UniqueCodeGenerator() : _freezerItems.UniqueCodeGenerator();
            string expirationString = expiration.ToString("MM/dd/yyyy");
            float priceFloat = (float)price;
            int quantityInt = (int)quantity;
            var foodItem = _dryItems.BuildFoodItem(name, type, expirationString, priceFloat, quantityInt, location, code);
            _allFoodItems.Add(foodItem);
        }

        // --- RESTORED AND CORRECTED METHOD ---
        // This version works correctly with your GUI's "select and click" feature.
        public bool RemoveFoodItem(string itemCode)
        {
            // Find the item in the list using its unique code.
            var itemToRemove = _allFoodItems.Find(item => item.StartsWith(itemCode + ","));

            // If we found the item...
            if (itemToRemove != null)
            {
                // ...remove it from the list...
                _allFoodItems.Remove(itemToRemove);
                // ...and return 'true' to signal success.
                return true;
            }

            // If no item was found, return 'false' to signal failure.
            return false;
        }

        public bool UpdateFoodItem(string code, string name, string type, DateTime expiration, decimal price, decimal quantity, string location)
        {
            int itemIndex = _allFoodItems.FindIndex(item => item.StartsWith(code + ","));

            if (itemIndex != -1)
            {
                string[] oldParts = _allFoodItems[itemIndex].Split(',');
                string originalLocation = oldParts[7];
                string originalStatus = oldParts[4];
                string originalDateAdded = oldParts[8];

                string finalCode = code;

                if (location.ToLower() != originalLocation.ToLower())
                {
                    string numberPart = code.Split('-')[1];
                    string newPrefix = location.ToLower() == "dry" ? "D" : "F";
                    finalCode = $"{newPrefix}-{numberPart}";
                }

                string updatedItemString = $"{finalCode},{name},{type},{expiration:MM/dd/yyyy},{originalStatus},{(float)price},{(int)quantity},{location},{originalDateAdded}";
                _allFoodItems[itemIndex] = updatedItemString;
                return true;
            }
            return false;
        }

        public List<FoodItemData> GetFoodItemData()
        {
            var foodDataList = new List<FoodItemData>();
            foreach (var itemString in _allFoodItems)
            {
                string[] parts = itemString.Split(',');
                if (parts.Length == 9)
                {
                    foodDataList.Add(new FoodItemData
                    {
                        _code = parts[0],
                        _name = parts[1],
                        _type = parts[2],
                        _expirationDate = parts[3],
                        _status = bool.Parse(parts[4]) ? "Expired" : "Good",
                        _price = float.Parse(parts[5]),
                        _quantity = int.Parse(parts[6]),
                        _storageLocation = parts[7],
                        _dateAdded = parts[8]
                    });
                }
            }
            return foodDataList;
        }
    }
}


