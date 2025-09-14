namespace FSMS_GUI
{
    partial class PasswordConfirmForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtPasswordEntry = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 0;
            label1.Text = "Please enter your current password to continue:";
            // 
            // txtPasswordEntry
            // 
            txtPasswordEntry.Location = new Point(33, 63);
            txtPasswordEntry.Margin = new Padding(4, 3, 4, 3);
            txtPasswordEntry.Name = "txtPasswordEntry";
            txtPasswordEntry.Size = new Size(361, 23);
            txtPasswordEntry.TabIndex = 1;
            txtPasswordEntry.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(212, 115);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(88, 27);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(307, 115);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PasswordConfirmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(425, 186);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtPasswordEntry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PasswordConfirmForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Security Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordEntry;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
