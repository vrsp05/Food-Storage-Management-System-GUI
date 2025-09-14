using System.Linq;
using System.Text.RegularExpressions;

namespace FSMS_GUI
{
    public static class ValidationService
    {
        public static (bool IsValid, string ErrorMessage) ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return (false, "Email cannot be blank.");
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address == email)
                {
                    return (true, string.Empty);
                }
            }
            catch { }
            return (false, "Invalid email format. Please enter a valid email address.");
        }

        // --- NEW VALIDATION METHOD ---
        // This method checks rules that involve both the username and email.
        public static (bool IsValid, string ErrorMessage) ValidateUsernameAndEmail(string username, string email)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email))
            {
                if (email.ToLower().Contains(username.ToLower()))
                {
                    return (false, "For security, your email address cannot contain your username.");
                }
            }
            return (true, string.Empty); // Success
        }

        public static (bool IsValid, string ErrorMessage) ValidatePasswordStrength(string password, string username = "", string email = "")
        {
            if (string.IsNullOrWhiteSpace(password)) return (false, "Password cannot be blank.");
            if (password.Length < 8) return (false, "Password must be at least 8 characters long.");
            if (!password.Any(char.IsUpper)) return (false, "Password must contain at least one uppercase letter.");
            if (!password.Any(char.IsLower)) return (false, "Password must contain at least one lowercase letter.");
            if (!password.Any(char.IsDigit)) return (false, "Password must contain at least one digit.");
            if (!password.Any(ch => !char.IsLetterOrDigit(ch))) return (false, "Password must contain at least one special character.");
            if (password.Contains(" ")) return (false, "Password cannot contain spaces.");
            if (!string.IsNullOrEmpty(username) && password.ToLower().Contains(username.ToLower())) return (false, "Password cannot contain your username.");
            if (!string.IsNullOrEmpty(email) && password.ToLower().Contains(email.ToLower())) return (false, "Password cannot contain your email.");

            return (true, string.Empty);
        }
    }
}

