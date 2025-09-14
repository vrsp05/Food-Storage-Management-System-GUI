namespace FSMS_GUI
{
    partial class AllItemsControl
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            pnlDelete = new Panel();
            btnEdit = new Button();
            searchByName = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlDelete.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 130);
            dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 25);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Selected Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlDelete
            // 
            pnlDelete.Controls.Add(txtSearch);
            pnlDelete.Controls.Add(searchByName);
            pnlDelete.Controls.Add(btnEdit);
            pnlDelete.Controls.Add(btnDelete);
            pnlDelete.Dock = DockStyle.Bottom;
            pnlDelete.Location = new Point(0, 130);
            pnlDelete.Name = "pnlDelete";
            pnlDelete.Size = new Size(696, 50);
            pnlDelete.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(442, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 25);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Selected Item";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // searchByName
            // 
            searchByName.AutoSize = true;
            searchByName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchByName.Location = new Point(0, 6);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(138, 21);
            searchByName.TabIndex = 3;
            searchByName.Text = "Search by Name:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(144, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 4;
            // 
            // AllItemsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(pnlDelete);
            Name = "AllItemsControl";
            Size = new Size(696, 180);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlDelete.ResumeLayout(false);
            pnlDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button btnDelete;
        private Panel pnlDelete;
        private Button btnEdit;
        private TextBox txtSearch;
        private Label searchByName;
    }
}
