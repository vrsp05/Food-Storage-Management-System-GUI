using System;
using System.Windows.Forms;

namespace FSMS_GUI
{
    public partial class PasswordConfirmForm : Form
    {
        public string EnteredPassword { get; private set; } = "";

        public PasswordConfirmForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            EnteredPassword = txtPasswordEntry.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


