namespace FSMS_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnDashboard = new Button();
            btnSaveAndExit = new Button();
            btnAddItem = new Button();
            btnAllItems = new Button();
            lblWelcome = new Label();
            panelNav = new Panel();
            panelMain = new Panel();
            btnAccountSettings = new Button();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(btnDashboard);
            panelHeader.Controls.Add(btnSaveAndExit);
            panelHeader.Controls.Add(btnAddItem);
            panelHeader.Controls.Add(btnAllItems);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDashboard.Location = new Point(3, 69);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(115, 25);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSaveAndExit
            // 
            btnSaveAndExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAndExit.Location = new Point(682, 69);
            btnSaveAndExit.Name = "btnSaveAndExit";
            btnSaveAndExit.Size = new Size(115, 25);
            btnSaveAndExit.TabIndex = 3;
            btnSaveAndExit.Text = "Save and Exit";
            btnSaveAndExit.UseVisualStyleBackColor = true;
            btnSaveAndExit.Click += btnSaveAndExit_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddItem.Location = new Point(245, 69);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(115, 25);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add New Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnAllItems
            // 
            btnAllItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAllItems.Location = new Point(124, 69);
            btnAllItems.Name = "btnAllItems";
            btnAllItems.Size = new Size(115, 25);
            btnAllItems.TabIndex = 1;
            btnAllItems.Text = "View All Items\n\n";
            btnAllItems.UseVisualStyleBackColor = true;
            btnAllItems.Click += btnAllItems_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Window;
            lblWelcome.Location = new Point(10, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 30);
            lblWelcome.TabIndex = 0;
            // 
            // panelNav
            // 
            panelNav.BackColor = SystemColors.ControlLight;
            panelNav.Controls.Add(btnAccountSettings);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 100);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(200, 350);
            panelNav.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 100);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 350);
            panelMain.TabIndex = 2;
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.Location = new Point(3, 6);
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(115, 25);
            btnAccountSettings.TabIndex = 0;
            btnAccountSettings.Text = "Account Settings";
            btnAccountSettings.UseVisualStyleBackColor = true;
            btnAccountSettings.Click += btnAccountSettings_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Name = "MainForm";
            Text = "Food Storage Management System";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnAllItems;
        private Label lblWelcome;
        private Panel panelNav;
        private Panel panelMain;
        private Button btnAddItem;
        private Button btnSaveAndExit;
        private Button btnDashboard;
        private Button btnAccountSettings;
    }
}