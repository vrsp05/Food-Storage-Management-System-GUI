namespace FSMS_GUI
{
    partial class EditItemControl
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
            lblName = new Label();
            txtName = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            lblExpirationDate = new Label();
            dtpExpiration = new DateTimePicker();
            lplPrice = new Label();
            numPrice = new NumericUpDown();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblStorageLocation = new Label();
            cmbLocation = new ComboBox();
            btnSaveChanges = new Button();
            lblItemCode = new Label();
            ItemCodelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Item Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 23);
            txtName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(0, 28);
            lblType.Name = "lblType";
            lblType.Size = new Size(218, 21);
            lblType.TabIndex = 2;
            lblType.Text = "Item Type (e.g, Meat, Fruit):";
            // 
            // txtType
            // 
            txtType.Location = new Point(224, 30);
            txtType.Name = "txtType";
            txtType.Size = new Size(163, 23);
            txtType.TabIndex = 3;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpirationDate.Location = new Point(0, 57);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(133, 21);
            lblExpirationDate.TabIndex = 4;
            lblExpirationDate.Text = "Expiration Date:";
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(139, 56);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(248, 23);
            dtpExpiration.TabIndex = 5;
            // 
            // lplPrice
            // 
            lplPrice.AutoSize = true;
            lplPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lplPrice.Location = new Point(0, 83);
            lplPrice.Name = "lplPrice";
            lplPrice.Size = new Size(52, 21);
            lplPrice.TabIndex = 8;
            lplPrice.Text = "Price:";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(58, 81);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(329, 23);
            numPrice.TabIndex = 9;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(0, 107);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 21);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(87, 110);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(300, 23);
            numQuantity.TabIndex = 11;
            // 
            // lblStorageLocation
            // 
            lblStorageLocation.AutoSize = true;
            lblStorageLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorageLocation.Location = new Point(0, 136);
            lblStorageLocation.Name = "lblStorageLocation";
            lblStorageLocation.Size = new Size(143, 21);
            lblStorageLocation.TabIndex = 12;
            lblStorageLocation.Text = "Storage Location:";
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(149, 138);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(238, 23);
            cmbLocation.TabIndex = 13;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(272, 167);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 25);
            btnSaveChanges.TabIndex = 14;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemCode.Location = new Point(0, 164);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(92, 21);
            lblItemCode.TabIndex = 15;
            lblItemCode.Text = "Item Code:";
            // 
            // ItemCodelbl
            // 
            ItemCodelbl.AutoSize = true;
            ItemCodelbl.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ItemCodelbl.Location = new Point(98, 164);
            ItemCodelbl.Name = "ItemCodelbl";
            ItemCodelbl.Size = new Size(0, 21);
            ItemCodelbl.TabIndex = 16;
            // 
            // EditItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemCodelbl);
            Controls.Add(lblItemCode);
            Controls.Add(btnSaveChanges);
            Controls.Add(cmbLocation);
            Controls.Add(lblStorageLocation);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(numPrice);
            Controls.Add(lplPrice);
            Controls.Add(dtpExpiration);
            Controls.Add(lblExpirationDate);
            Controls.Add(txtType);
            Controls.Add(lblType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "EditItemControl";
            Size = new Size(393, 288);
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblType;
        private TextBox txtType;
        private Label lblExpirationDate;
        private DateTimePicker dtpExpiration;
        private Label lplPrice;
        private NumericUpDown numPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblStorageLocation;
        private ComboBox cmbLocation;
        private Button btnSaveChanges;
        private Label lblItemCode;
        private Label ItemCodelbl;
    }
}
