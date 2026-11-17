namespace KenSaPOS.WinForms
{
    partial class PosControl
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.pnlTotals = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.lblTendered = new System.Windows.Forms.Label();
            this.nudTendered = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxCaption = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblChangeCaption = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlCartTools = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblScan = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTendered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.pnlCartTools.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvCart);
            this.pnlRight.Controls.Add(this.pnlTotals);
            this.pnlRight.Controls.Add(this.pnlCartTools);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(520, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(470, 700);
            this.pnlRight.TabIndex = 0;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.MultiSelect = false;
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 44);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(470, 290);
            this.dgvCart.TabIndex = 0;
            // 
            // pnlTotals
            // 
            this.pnlTotals.Controls.Add(this.lblCustomer);
            this.pnlTotals.Controls.Add(this.cboCustomer);
            this.pnlTotals.Controls.Add(this.btnAddCustomer);
            this.pnlTotals.Controls.Add(this.lblDiscount);
            this.pnlTotals.Controls.Add(this.nudDiscount);
            this.pnlTotals.Controls.Add(this.lblPayment);
            this.pnlTotals.Controls.Add(this.cboPayment);
            this.pnlTotals.Controls.Add(this.lblTendered);
            this.pnlTotals.Controls.Add(this.nudTendered);
            this.pnlTotals.Controls.Add(this.lblSubtotalCaption);
            this.pnlTotals.Controls.Add(this.lblSubtotal);
            this.pnlTotals.Controls.Add(this.lblTaxCaption);
            this.pnlTotals.Controls.Add(this.lblTax);
            this.pnlTotals.Controls.Add(this.lblDiscountCaption);
            this.pnlTotals.Controls.Add(this.lblDiscountValue);
            this.pnlTotals.Controls.Add(this.lblTotalCaption);
            this.pnlTotals.Controls.Add(this.lblTotal);
            this.pnlTotals.Controls.Add(this.lblChangeCaption);
            this.pnlTotals.Controls.Add(this.lblChange);
            this.pnlTotals.Controls.Add(this.btnCheckout);
            this.pnlTotals.Controls.Add(this.btnPreview);
            this.pnlTotals.Controls.Add(this.btnPrint);
            this.pnlTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotals.Location = new System.Drawing.Point(0, 334);
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Size = new System.Drawing.Size(470, 366);
            this.pnlTotals.TabIndex = 1;
            this.pnlTotals.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(14, 18);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.cboCustomer.Location = new System.Drawing.Point(96, 14);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(300, 23);
            this.cboCustomer.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddCustomer.Location = new System.Drawing.Point(402, 13);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(40, 27);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(14, 56);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(96, 52);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(110, 23);
            this.nudDiscount.TabIndex = 4;
            this.nudDiscount.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudDiscount.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudDiscount.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudDiscount.DecimalPlaces = 2;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(14, 94);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "Payment";
            // 
            // cboPayment
            // 
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile"});
            this.cboPayment.Location = new System.Drawing.Point(96, 90);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(110, 23);
            this.cboPayment.TabIndex = 6;
            this.cboPayment.SelectedIndexChanged += new System.EventHandler(this.cboPayment_SelectedIndexChanged);
            // 
            // lblTendered
            // 
            this.lblTendered.AutoSize = true;
            this.lblTendered.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblTendered.Location = new System.Drawing.Point(226, 94);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.TabIndex = 7;
            this.lblTendered.Text = "Tendered";
            // 
            // nudTendered
            // 
            this.nudTendered.Location = new System.Drawing.Point(296, 90);
            this.nudTendered.Name = "nudTendered";
            this.nudTendered.Size = new System.Drawing.Size(146, 23);
            this.nudTendered.TabIndex = 8;
            this.nudTendered.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudTendered.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.nudTendered.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudTendered.DecimalPlaces = 2;
            // 
            // lblSubtotalCaption
            // 
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Location = new System.Drawing.Point(14, 134);
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            this.lblSubtotalCaption.TabIndex = 9;
            this.lblSubtotalCaption.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblSubtotal.Location = new System.Drawing.Point(200, 132);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(242, 20);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "0.00";
            this.lblSubtotal.AutoSize = false;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxCaption
            // 
            this.lblTaxCaption.AutoSize = true;
            this.lblTaxCaption.Location = new System.Drawing.Point(14, 158);
            this.lblTaxCaption.Name = "lblTaxCaption";
            this.lblTaxCaption.TabIndex = 11;
            this.lblTaxCaption.Text = "Tax";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblTax.Location = new System.Drawing.Point(200, 156);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(242, 20);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "0.00";
            this.lblTax.AutoSize = false;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountCaption
            // 
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Location = new System.Drawing.Point(14, 182);
            this.lblDiscountCaption.Name = "lblDiscountCaption";
            this.lblDiscountCaption.TabIndex = 13;
            this.lblDiscountCaption.Text = "Discount";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblDiscountValue.Location = new System.Drawing.Point(200, 180);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(242, 20);
            this.lblDiscountValue.TabIndex = 14;
            this.lblDiscountValue.Text = "0.00";
            this.lblDiscountValue.AutoSize = false;
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(14, 214);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.TabIndex = 15;
            this.lblTotalCaption.Text = "TOTAL";
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotal.Location = new System.Drawing.Point(160, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(282, 34);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0.00";
            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeCaption
            // 
            this.lblChangeCaption.AutoSize = true;
            this.lblChangeCaption.Location = new System.Drawing.Point(14, 250);
            this.lblChangeCaption.Name = "lblChangeCaption";
            this.lblChangeCaption.TabIndex = 17;
            this.lblChangeCaption.Text = "Change";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblChange.Location = new System.Drawing.Point(200, 248);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(242, 20);
            this.lblChange.TabIndex = 18;
            this.lblChange.Text = "0.00";
            this.lblChange.AutoSize = false;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnCheckout.Location = new System.Drawing.Point(14, 280);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(428, 44);
            this.btnCheckout.TabIndex = 19;
            this.btnCheckout.Text = "CHECKOUT (F9)";
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(14, 330);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(210, 28);
            this.btnPreview.TabIndex = 20;
            this.btnPreview.Text = "Preview receipt";
            this.btnPreview.Enabled = false;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(232, 330);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(210, 28);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print receipt";
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlCartTools
            // 
            this.pnlCartTools.Controls.Add(this.btnPlus);
            this.pnlCartTools.Controls.Add(this.btnMinus);
            this.pnlCartTools.Controls.Add(this.btnRemove);
            this.pnlCartTools.Controls.Add(this.btnClear);
            this.pnlCartTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartTools.Location = new System.Drawing.Point(0, 0);
            this.pnlCartTools.Name = "pnlCartTools";
            this.pnlCartTools.Size = new System.Drawing.Size(470, 44);
            this.pnlCartTools.TabIndex = 2;
            this.pnlCartTools.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(8, 8);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 28);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(50, 8);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(36, 28);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(92, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(110, 118, 130);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear cart";
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblScan);
            this.pnlLeft.Controls.Add(this.txtScan);
            this.pnlLeft.Controls.Add(this.lblFind);
            this.pnlLeft.Controls.Add(this.txtFind);
            this.pnlLeft.Controls.Add(this.btnFind);
            this.pnlLeft.Controls.Add(this.lblQty);
            this.pnlLeft.Controls.Add(this.nudQty);
            this.pnlLeft.Controls.Add(this.btnAddToCart);
            this.pnlLeft.Controls.Add(this.dgvProducts);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(520, 700);
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Location = new System.Drawing.Point(14, 12);
            this.lblScan.Name = "lblScan";
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Scan barcode / enter SKU, then press Enter:";
            // 
            // txtScan
            // 
            this.txtScan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.txtScan.Location = new System.Drawing.Point(14, 34);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(492, 25);
            this.txtScan.TabIndex = 1;
            this.txtScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyDown);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(14, 76);
            this.lblFind.Name = "lblFind";
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(52, 72);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(170, 23);
            this.txtFind.TabIndex = 3;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(228, 70);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 27);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Search";
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(312, 76);
            this.lblQty.Name = "lblQty";
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Qty:";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(342, 72);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(56, 23);
            this.nudQty.TabIndex = 6;
            this.nudQty.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.Maximum = new decimal(new int[] {999, 0, 0, 0});
            this.nudQty.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddToCart.Location = new System.Drawing.Point(404, 70);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(102, 27);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
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
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvProducts.Location = new System.Drawing.Point(14, 108);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(492, 580);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // PosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PosControl";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.PosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTendered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlCartTools.ResumeLayout(false);
            this.pnlCartTools.PerformLayout();
            this.pnlTotals.ResumeLayout(false);
            this.pnlTotals.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlTotals;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.Label lblTendered;
        private System.Windows.Forms.NumericUpDown nudTendered;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxCaption;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblChangeCaption;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlCartTools;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}
