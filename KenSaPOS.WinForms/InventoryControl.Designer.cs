namespace KenSaPOS.WinForms
{
    partial class InventoryControl
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.pnlAdjust = new System.Windows.Forms.Panel();
            this.lblAdjustProduct = new System.Windows.Forms.Label();
            this.lblAdjustHint = new System.Windows.Forms.Label();
            this.nudChange = new System.Windows.Forms.NumericUpDown();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkLowOnly = new System.Windows.Forms.CheckBox();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange)).BeginInit();
            this.pnlAdjust.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 52);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(990, 340);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProducts_DataBindingComplete);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogTitle.Location = new System.Drawing.Point(0, 392);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(990, 26);
            this.lblLogTitle.TabIndex = 1;
            this.lblLogTitle.Text = "  Stock history of the selected product";
            this.lblLogTitle.BackColor = System.Drawing.Color.FromArgb(232, 236, 244);
            this.lblLogTitle.AutoSize = false;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.MultiSelect = false;
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLog.Location = new System.Drawing.Point(0, 418);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(990, 150);
            this.dgvLog.TabIndex = 2;
            // 
            // pnlAdjust
            // 
            this.pnlAdjust.Controls.Add(this.lblAdjustProduct);
            this.pnlAdjust.Controls.Add(this.lblAdjustHint);
            this.pnlAdjust.Controls.Add(this.nudChange);
            this.pnlAdjust.Controls.Add(this.cboReason);
            this.pnlAdjust.Controls.Add(this.btnApply);
            this.pnlAdjust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdjust.Location = new System.Drawing.Point(0, 626);
            this.pnlAdjust.Name = "pnlAdjust";
            this.pnlAdjust.Size = new System.Drawing.Size(990, 74);
            this.pnlAdjust.TabIndex = 3;
            this.pnlAdjust.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblAdjustProduct
            // 
            this.lblAdjustProduct.AutoSize = true;
            this.lblAdjustProduct.Location = new System.Drawing.Point(14, 10);
            this.lblAdjustProduct.Name = "lblAdjustProduct";
            this.lblAdjustProduct.TabIndex = 0;
            this.lblAdjustProduct.Text = "Select a product to adjust stock";
            this.lblAdjustProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblAdjustHint
            // 
            this.lblAdjustHint.AutoSize = true;
            this.lblAdjustHint.Location = new System.Drawing.Point(330, 11);
            this.lblAdjustHint.Name = "lblAdjustHint";
            this.lblAdjustHint.TabIndex = 1;
            this.lblAdjustHint.Text = "Use positive numbers to add stock, negative to remove.";
            this.lblAdjustHint.ForeColor = System.Drawing.Color.FromArgb(110, 118, 130);
            // 
            // nudChange
            // 
            this.nudChange.Location = new System.Drawing.Point(14, 38);
            this.nudChange.Name = "nudChange";
            this.nudChange.Size = new System.Drawing.Size(90, 23);
            this.nudChange.TabIndex = 2;
            this.nudChange.Minimum = new decimal(new int[] {100000, 0, 0, -2147483648});
            this.nudChange.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.nudChange.Value = new decimal(new int[] {0, 0, 0, 0});
            // 
            // cboReason
            // 
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Items.AddRange(new object[] {
            "Stock received",
            "Stock count correction",
            "Damaged / expired",
            "Returned to supplier",
            "Other"});
            this.cboReason.Location = new System.Drawing.Point(112, 38);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(260, 23);
            this.cboReason.TabIndex = 3;
            this.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(384, 36);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 28);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply adjustment";
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.chkLowOnly);
            this.pnlTop.Controls.Add(this.chkInactive);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(990, 52);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkLowOnly
            // 
            this.chkLowOnly.AutoSize = true;
            this.chkLowOnly.UseVisualStyleBackColor = true;
            this.chkLowOnly.Location = new System.Drawing.Point(398, 18);
            this.chkLowOnly.Name = "chkLowOnly";
            this.chkLowOnly.TabIndex = 3;
            this.chkLowOnly.Text = "Low stock only";
            this.chkLowOnly.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.UseVisualStyleBackColor = true;
            this.chkInactive.Location = new System.Drawing.Point(512, 18);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.TabIndex = 4;
            this.chkInactive.Text = "Show inactive";
            this.chkInactive.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAdd.Location = new System.Drawing.Point(684, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add product";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnEdit.Location = new System.Drawing.Point(796, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnDelete.Location = new System.Drawing.Point(884, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblLogTitle);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.pnlAdjust);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlAdjust.ResumeLayout(false);
            this.pnlAdjust.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Panel pnlAdjust;
        private System.Windows.Forms.Label lblAdjustProduct;
        private System.Windows.Forms.Label lblAdjustHint;
        private System.Windows.Forms.NumericUpDown nudChange;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkLowOnly;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
