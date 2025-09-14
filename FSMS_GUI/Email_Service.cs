using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace FSMS_GUI
{
    public class EmailService
    {
        // --- IMPORTANT ---
        // Replace these placeholder values with your actual standard Gmail account and app password.
        private readonly string _senderEmail = "fsmsapp.service@gmail.com";
        private readonly string _senderPassword = "ejrewwhziwwendip";
        // --- END OF IMPORTANT SECTION ---

        private const string _smtpServer = "smtp.gmail.com";
        private const int _smtpPort = 587;

        // The constructor is now empty because the credentials are part of the class.
        public EmailService() { }

        public (bool success, string message) SendEmail(string subject, string body, string recipientEmail)
        {
            // First, check if the credentials have been set.
            if (_senderEmail == "your-standard-email@gmail.com" || _senderPassword == "your-google-app-password")
            {
                return (false, "Email service has not been configured by the developer.");
            }

            try
            {
                using (var client = new SmtpClient(_smtpServer, _smtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(_senderEmail, _senderPassword);

                    using (var mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(_senderEmail);
                        mailMessage.To.Add(recipientEmail);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;
                        client.Send(mailMessage);
                    }
                }
                return (true, "Expiration summary email sent successfully!");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to send email: {ex.Message}");
            }
        }

        public string GenerateEmailBody(List<FoodItemData> expiringItems, List<FoodItemData> expiredItems, string recipientUsername)
        {
            if (expiringItems.Count == 0 && expiredItems.Count == 0)
            {
                return $"Dear {recipientUsername},\n\nYou have no items that are expired or nearing expiration. Great job!\n\nSincerely,\nThe Food Storage Management System";
            }

            string body = $"Dear {recipientUsername},\n\nHere is your food storage summary:\n";

            if (expiringItems.Count > 0)
            {
                body += "\n--- ITEMS EXPIRING SOON ---\n";
                foreach (var item in expiringItems)
                {
                    body += $"\n- {item._name} (Code: {item._code}) expires on {item._expirationDate}.";
                }
            }

            if (expiredItems.Count > 0)
            {
                body += "\n\n--- EXPIRED ITEMS ---\n";
                foreach (var item in expiredItems)
                {
                    body += $"\n- {item._name} (Code: {item._code}) expired on {item._expirationDate}.";
                }
            }

            body += "\n\nSincerely,\nThe Food Storage Management System";
            return body;
        }
    }
}
