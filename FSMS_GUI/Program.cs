using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show the login form as a dialog
            using (var loginForm = new LoginForm())
            {
                // This is the line that shows the login form and waits
                // for it to close.
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If the user logged in successfully (the form returned OK),
                    // then get the logged-in user and open the main form.
                    if (loginForm.LoggedInAccountManager != null)
                    {
                        Application.Run(new MainForm(loginForm.LoggedInAccountManager));
                    }
                }
                // If the login form is closed in any other way (e.g., clicking
                // the 'X' or cancel), the application will simply exit.
            }
        }
    }
}





