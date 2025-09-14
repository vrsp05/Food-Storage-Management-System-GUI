namespace FSMS_GUI
{
    partial class AddItemControl
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
            txtName = new TextBox();
            txtType = new TextBox();
            dtpExpiration = new DateTimePicker();
            lblName = new Label();
            lblType = new Label();
            lblExperation = new Label();
            numPrice = new NumericUpDown();
            lplPrice = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbLocation = new ComboBox();
            lblStorageLocation = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 23);
            txtName.TabIndex = 0;
            // 
            // txtType
            // 
            txtType.Location = new Point(231, 32);
            txtType.Name = "txtType";
            txtType.Size = new Size(159, 23);
            txtType.TabIndex = 1;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(142, 61);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(248, 23);
            dtpExpiration.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Item Name:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(3, 30);
            lblType.Name = "lblType";
            lblType.Size = new Size(222, 21);
            lblType.TabIndex = 4;
            lblType.Text = "Item Type (e.g., Meat, Fruit):";
            // 
            // lblExperation
            // 
            lblExperation.AutoSize = true;
            lblExperation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExperation.Location = new Point(3, 61);
            lblExperation.Name = "lblExperation";
            lblExperation.Size = new Size(133, 21);
            lblExperation.TabIndex = 5;
            lblExperation.Text = "Expiration Date:";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(61, 90);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(329, 23);
            numPrice.TabIndex = 6;
            // 
            // lplPrice
            // 
            lplPrice.AutoSize = true;
            lplPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lplPrice.Location = new Point(3, 87);
            lplPrice.Name = "lplPrice";
            lplPrice.Size = new Size(52, 21);
            lplPrice.TabIndex = 7;
            lplPrice.Text = "Price:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(90, 119);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(300, 23);
            numQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(3, 116);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 21);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity:";
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(150, 147);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(240, 23);
            cmbLocation.TabIndex = 10;
            // 
            // lblStorageLocation
            // 
            lblStorageLocation.AutoSize = true;
            lblStorageLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorageLocation.Location = new Point(3, 145);
            lblStorageLocation.Name = "lblStorageLocation";
            lblStorageLocation.Size = new Size(143, 21);
            lblStorageLocation.TabIndex = 11;
            lblStorageLocation.Text = "Storage Location:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 25);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Item";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnSave);
            Controls.Add(lblStorageLocation);
            Controls.Add(cmbLocation);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(lplPrice);
            Controls.Add(numPrice);
            Controls.Add(lblExperation);
            Controls.Add(dtpExpiration);
            Controls.Add(lblType);
            Controls.Add(txtType);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "AddItemControl";
            Size = new Size(393, 288);
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtType;
        private DateTimePicker dtpExpiration;
        private Label lblName;
        private Label lblType;
        private Label lblExperation;
        private NumericUpDown numPrice;
        private Label lplPrice;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private ComboBox cmbLocation;
        private Label lblStorageLocation;
        private Button btnSave;
    }
}
