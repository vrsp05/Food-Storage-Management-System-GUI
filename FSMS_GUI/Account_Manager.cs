using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; // Required for the new method

namespace FSMS_GUI
{
    public class AccountManager
    {
        private const string _accountFile = "accounts.txt";

        public string _loggedInUserName { get; private set; } = "";
        public string _loggedInEmail { get; private set; } = "";
        public string _loggedInPassword { get; private set; } = "";

        // ... Login, CreateAccount, and other methods are unchanged ...
        public (bool success, string message, AccountManager? manager) Login(string email, string password)
        {
            var lines = File.Exists(_accountFile) ? File.ReadAllLines(_accountFile) : Array.Empty<string>();
            string currentUsername = "", currentEmail = "", currentPassword = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Username: ")) currentUsername = lines[i].Split(": ")[1].Trim();
                else if (lines[i].StartsWith("Email: ")) currentEmail = lines[i].Split(": ")[1].Trim();
                else if (lines[i].StartsWith("Password: ")) currentPassword = lines[i].Split(": ")[1].Trim();

                if (lines[i] == "---")
                {
                    if (email == currentEmail && password == currentPassword)
                    {
                        _loggedInUserName = currentUsername;
                        _loggedInEmail = currentEmail;
                        _loggedInPassword = currentPassword;
                        return (true, "Login successful!", this);
                    }
                    currentUsername = currentEmail = currentPassword = "";
                }
            }
            return (false, "Invalid email or password.", null);
        }

        public (bool success, string message) CreateAccount(string username, string email, string password)
        {
            var lines = File.Exists(_accountFile) ? File.ReadAllLines(_accountFile) : Array.Empty<string>();
            if (lines.Any(line => line.StartsWith($"Username: {username}"))) return (false, "That username is already taken.");
            if (lines.Any(line => line.StartsWith($"Email: {email}"))) return (false, "That email is already registered.");

            string accountData = $"\nAccount Data:\nUsername: {username}\nEmail: {email}\nPassword: {password}\n---";
            File.AppendAllText(_accountFile, accountData);
            return (true, "Account created successfully!");
        }

        public (bool success, string message) ChangeUsername(string newUsername)
        {
            var accounts = File.ReadAllLines(_accountFile).ToList();
            if (accounts.Any(line => line.StartsWith("Username: ") && line.Split(": ")[1].Trim() == newUsername))
            {
                return (false, "This username is already taken.");
            }

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].StartsWith("Username: ") && accounts[i].Split(": ")[1].Trim() == _loggedInUserName)
                {
                    string oldFoodFile = $"{_loggedInUserName}_foodDATA.txt";
                    if (File.Exists(oldFoodFile))
                    {
                        File.Move(oldFoodFile, $"{newUsername}_foodDATA.txt");
                    }

                    accounts[i] = $"Username: {newUsername}";
                    File.WriteAllLines(_accountFile, accounts);
                    _loggedInUserName = newUsername;
                    return (true, $"Username successfully changed to {newUsername}!");
                }
            }
            return (false, "Could not find original user account.");
        }

        public (bool success, string message) ChangeEmail(string newEmail)
        {
            if (!newEmail.Contains("@") || !newEmail.Contains("."))
            {
                return (false, "Invalid email format.");
            }

            var accounts = File.ReadAllLines(_accountFile).ToList();
            if (accounts.Any(line => line.StartsWith("Email: ") && line.Split(": ")[1].Trim() == newEmail))
            {
                return (false, "This email is already in use.");
            }

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].StartsWith("Email: ") && accounts[i].Split(": ")[1].Trim() == _loggedInEmail)
                {
                    accounts[i] = $"Email: {newEmail}";
                    File.WriteAllLines(_accountFile, accounts);
                    _loggedInEmail = newEmail;
                    return (true, $"Email successfully changed to {newEmail}!");
                }
            }
            return (false, "Could not find original user account.");
        }

        public (bool success, string message) ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            if (currentPassword != _loggedInPassword) return (false, "The current password you entered is incorrect.");
            if (newPassword != confirmPassword) return (false, "The new passwords do not match.");

            var accounts = File.ReadAllLines(_accountFile).ToList();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].StartsWith("Email: ") && accounts[i].Split(": ")[1].Trim() == _loggedInEmail)
                {
                    if (i + 1 < accounts.Count && accounts[i + 1].StartsWith("Password: "))
                    {
                        accounts[i + 1] = $"Password: {newPassword}";
                        File.WriteAllLines(_accountFile, accounts);
                        _loggedInPassword = newPassword;
                        return (true, "Password successfully changed!");
                    }
                }
            }
            return (false, "Could not find your account to update the password.");
        }

        // --- NEW AND IMPROVED DELETE METHOD ---
        public (bool success, string message) DeleteAccount()
        {
            try
            {
                // Read the entire file as one big string.
                string fileContent = File.ReadAllText(_accountFile);

                // Split the content into account blocks using "---" as the separator.
                string[] accountBlocks = fileContent.Split(new[] { "---" }, StringSplitOptions.RemoveEmptyEntries);

                // Use LINQ to find all blocks that DO NOT contain the user's email.
                var accountsToKeep = accountBlocks.Where(block => !block.Contains($"Email: {_loggedInEmail}")).ToList();

                // Join the blocks we want to keep back together.
                var newFileContent = new StringBuilder();
                foreach (var block in accountsToKeep)
                {
                    if (!string.IsNullOrWhiteSpace(block))
                    {
                        newFileContent.Append(block.Trim() + "\n---\n");
                    }
                }

                // Write the new content back to the file, overwriting the old content.
                File.WriteAllText(_accountFile, newFileContent.ToString());

                // Delete the associated food data file.
                string foodFile = $"{_loggedInUserName}_foodDATA.txt";
                if (File.Exists(foodFile))
                {
                    File.Delete(foodFile);
                }

                return (true, "Account and all associated data have been permanently deleted.");
            }
            catch (Exception ex)
            {
                return (false, $"An error occurred while deleting the account: {ex.Message}");
            }
        }
    }
}

