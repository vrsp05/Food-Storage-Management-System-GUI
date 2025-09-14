using System;
using System.IO;
using System.Collections.Generic;
using FSMS_GUI;
using System.Linq;

namespace FSMS_GUI
{
    public class AccountManager
    {
        private const string _accountFile = "accounts.txt";

        public string _loggedInUserName { get; private set; }
        public string _loggedInEmail { get; private set; }
        public string _loggedInPassword { get; private set; }

        public (bool success, string username, string email) Login(string inputEmail, string inputPassword)
        {
            if (!File.Exists(_accountFile)) return (false, null, null);

            string[] lines = File.ReadAllLines(_accountFile);
            string username = "", email = "", password = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Username:")) username = lines[i].Split(new[] { ": " }, StringSplitOptions.None)[1];
                else if (lines[i].StartsWith("Email:")) email = lines[i].Split(new[] { ": " }, StringSplitOptions.None)[1];
                else if (lines[i].StartsWith("Password:")) password = lines[i].Split(new[] { ": " }, StringSplitOptions.None)[1];

                if (lines[i] == "---")
                {
                    if (inputEmail == email && inputPassword == password)
                    {
                        _loggedInUserName = username;
                        _loggedInEmail = email;
                        _loggedInPassword = password;
                        return (true, username, email);
                    }
                    username = email = password = "";
                }
            }
            return (false, null, null);
        }

        public bool CreateAccount(string newUsername, string newEmail, string newPassword)
        {
            if (!File.Exists(_accountFile)) File.Create(_accountFile).Close();

            string[] lines = File.ReadAllLines(_accountFile);
            if (lines.Any(line => line.Equals("Username: " + newUsername, StringComparison.OrdinalIgnoreCase) || line.Equals("Email: " + newEmail, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            string accountData = $"\nAccount Data:\nUsername: {newUsername}\nEmail: {newEmail}\nPassword: {newPassword}\n---";
            File.AppendAllText(_accountFile, accountData);
            return true;
        }
    }