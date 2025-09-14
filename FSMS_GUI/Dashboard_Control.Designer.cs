namespace FSMS_GUI
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblExpiringSoon = new Label();
            dgvExpiringSoon = new DataGridView();
            lblExpired = new Label();
            dgvExpired = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvExpiringSoon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpired).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblExpiringSoon
            // 
            lblExpiringSoon.AutoSize = true;
            lblExpiringSoon.Dock = DockStyle.Top;
            lblExpiringSoon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiringSoon.Location = new Point(0, 0);
            lblExpiringSoon.Margin = new Padding(4, 0, 4, 0);
            lblExpiringSoon.Name = "lblExpiringSoon";
            lblExpiringSoon.Size = new Size(267, 25);
            lblExpiringSoon.TabIndex = 0;
            lblExpiringSoon.Text = "Items Expiring Within 7 Days";
            // 
            // dgvExpiringSoon
            // 
            dgvExpiringSoon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpiringSoon.Dock = DockStyle.Fill;
            dgvExpiringSoon.Location = new Point(0, 25);
            dgvExpiringSoon.Margin = new Padding(4, 3, 4, 3);
            dgvExpiringSoon.Name = "dgvExpiringSoon";
            dgvExpiringSoon.Size = new Size(500, 201);
            dgvExpiringSoon.TabIndex = 1;
            // 
            // lblExpired
            // 
            lblExpired.AutoSize = true;
            lblExpired.Dock = DockStyle.Top;
            lblExpired.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpired.Location = new Point(0, 0);
            lblExpired.Margin = new Padding(4, 0, 4, 0);
            lblExpired.Name = "lblExpired";
            lblExpired.Size = new Size(133, 25);
            lblExpired.TabIndex = 2;
            lblExpired.Text = "Expired Items";
            // 
            // dgvExpired
            // 
            dgvExpired.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpired.Dock = DockStyle.Fill;
            dgvExpired.Location = new Point(0, 25);
            dgvExpired.Margin = new Padding(4, 3, 4, 3);
            dgvExpired.Name = "dgvExpired";
            dgvExpired.Size = new Size(500, 245);
            dgvExpired.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Orange;
            splitContainer1.Panel1.Controls.Add(dgvExpiringSoon);
            splitContainer1.Panel1.Controls.Add(lblExpiringSoon);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.IndianRed;
            splitContainer1.Panel2.Controls.Add(dgvExpired);
            splitContainer1.Panel2.Controls.Add(lblExpired);
            splitContainer1.Size = new Size(500, 500);
            splitContainer1.SplitterDistance = 226;
            splitContainer1.TabIndex = 4;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardControl";
            Size = new Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)dgvExpiringSoon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpired).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblExpiringSoon;
        private System.Windows.Forms.DataGridView dgvExpiringSoon;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.DataGridView dgvExpired;
        private SplitContainer splitContainer1;
    }
}
