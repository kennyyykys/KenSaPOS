namespace KenSaPOS.WinForms
{
    partial class ProductEditorForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>Required method for Designer support.</summary>
        private void InitializeComponent()
        {
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblStockNote = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.nudReorder = new System.Windows.Forms.NumericUpDown();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.lblImageHint = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(24, 28);
            this.lblSku.Name = "lblSku";
            this.lblSku.TabIndex = 0;
            this.lblSku.Text = "SKU *";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(130, 24);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(250, 23);
            this.txtSku.TabIndex = 1;
            this.txtSku.MaxLength = 30;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(24, 66);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(130, 62);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(250, 23);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.MaxLength = 50;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 104);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Product name *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 5;
            this.txtName.MaxLength = 150;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 142);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category *";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(130, 138);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 23);
            this.cboCategory.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(24, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Selling price *";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(130, 176);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 23);
            this.nudPrice.TabIndex = 9;
            this.nudPrice.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudPrice.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudPrice.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudPrice.DecimalPlaces = 2;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(24, 218);
            this.lblCost.Name = "lblCost";
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost price *";
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(130, 214);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(120, 23);
            this.nudCost.TabIndex = 11;
            this.nudCost.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudCost.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudCost.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudCost.DecimalPlaces = 2;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(24, 256);
            this.lblStock.Name = "lblStock";
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Opening stock";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(130, 252);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(100, 23);
            this.nudStock.TabIndex = 13;
            this.nudStock.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudStock.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudStock.Value = new decimal(new int[] {0, 0, 0, 0});
            // 
            // lblStockNote
            // 
            this.lblStockNote.AutoSize = true;
            this.lblStockNote.Location = new System.Drawing.Point(130, 278);
            this.lblStockNote.Name = "lblStockNote";
            this.lblStockNote.TabIndex = 14;
            this.lblStockNote.Text = "Use \"Apply adjustment\" on the Inventory page to change stock.";
            this.lblStockNote.ForeColor = System.Drawing.Color.FromArgb(110, 118, 130);
            this.lblStockNote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(24, 306);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.TabIndex = 15;
            this.lblReorder.Text = "Reorder level";
            // 
            // nudReorder
            // 
            this.nudReorder.Location = new System.Drawing.Point(130, 302);
            this.nudReorder.Name = "nudReorder";
            this.nudReorder.Size = new System.Drawing.Size(100, 23);
            this.nudReorder.TabIndex = 16;
            this.nudReorder.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudReorder.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudReorder.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.Location = new System.Drawing.Point(130, 342);
            this.chkActive.Name = "chkActive";
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "Active (visible in the product list)";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(410, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(130, 130);
            this.picImage.TabIndex = 18;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(410, 162);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(130, 28);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Choose image...";
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(410, 196);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(130, 28);
            this.btnClearImage.TabIndex = 20;
            this.btnClearImage.Text = "Remove image";
            this.btnClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImage.FlatAppearance.BorderSize = 0;
            this.btnClearImage.BackColor = System.Drawing.Color.FromArgb(110, 118, 130);
            this.btnClearImage.ForeColor = System.Drawing.Color.White;
            this.btnClearImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearImage.UseVisualStyleBackColor = false;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // lblImageHint
            // 
            this.lblImageHint.AutoSize = true;
            this.lblImageHint.Location = new System.Drawing.Point(410, 230);
            this.lblImageHint.Name = "lblImageHint";
            this.lblImageHint.TabIndex = 21;
            this.lblImageHint.Text = "JPG or PNG, max 1 MB";
            this.lblImageHint.ForeColor = System.Drawing.Color.FromArgb(110, 118, 130);
            this.lblImageHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(110, 118, 130);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 36);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.lblStockNote);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.nudReorder);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.lblImageHint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "ProductEditorForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblStockNote;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.NumericUpDown nudReorder;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label lblImageHint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
