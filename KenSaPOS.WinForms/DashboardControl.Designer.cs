namespace KenSaPOS.WinForms
{
    partial class DashboardControl
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesCaption = new System.Windows.Forms.Label();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersCaption = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.pnlLow = new System.Windows.Forms.Panel();
            this.lblLowCaption = new System.Windows.Forms.Label();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblProductsCaption = new System.Windows.Forms.Label();
            this.lblProductsValue = new System.Windows.Forms.Label();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlLow.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(24, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.lblSalesCaption);
            this.pnlSales.Controls.Add(this.lblSalesValue);
            this.pnlSales.Location = new System.Drawing.Point(24, 60);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(230, 92);
            this.pnlSales.TabIndex = 1;
            this.pnlSales.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            // 
            // lblSalesCaption
            // 
            this.lblSalesCaption.AutoSize = true;
            this.lblSalesCaption.Location = new System.Drawing.Point(14, 12);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.TabIndex = 0;
            this.lblSalesCaption.Text = "Today's sales";
            this.lblSalesCaption.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Location = new System.Drawing.Point(14, 38);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.TabIndex = 1;
            this.lblSalesValue.Text = "-";
            this.lblSalesValue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.lblOrdersCaption);
            this.pnlOrders.Controls.Add(this.lblOrdersValue);
            this.pnlOrders.Location = new System.Drawing.Point(270, 60);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(230, 92);
            this.pnlOrders.TabIndex = 2;
            this.pnlOrders.BackColor = System.Drawing.Color.FromArgb(30, 58, 128);
            // 
            // lblOrdersCaption
            // 
            this.lblOrdersCaption.AutoSize = true;
            this.lblOrdersCaption.Location = new System.Drawing.Point(14, 12);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.TabIndex = 0;
            this.lblOrdersCaption.Text = "Orders today";
            this.lblOrdersCaption.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.AutoSize = true;
            this.lblOrdersValue.Location = new System.Drawing.Point(14, 38);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.TabIndex = 1;
            this.lblOrdersValue.Text = "-";
            this.lblOrdersValue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblOrdersValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlLow
            // 
            this.pnlLow.Controls.Add(this.lblLowCaption);
            this.pnlLow.Controls.Add(this.lblLowValue);
            this.pnlLow.Location = new System.Drawing.Point(516, 60);
            this.pnlLow.Name = "pnlLow";
            this.pnlLow.Size = new System.Drawing.Size(230, 92);
            this.pnlLow.TabIndex = 3;
            this.pnlLow.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            // 
            // lblLowCaption
            // 
            this.lblLowCaption.AutoSize = true;
            this.lblLowCaption.Location = new System.Drawing.Point(14, 12);
            this.lblLowCaption.Name = "lblLowCaption";
            this.lblLowCaption.TabIndex = 0;
            this.lblLowCaption.Text = "Low-stock items";
            this.lblLowCaption.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // lblLowValue
            // 
            this.lblLowValue.AutoSize = true;
            this.lblLowValue.Location = new System.Drawing.Point(14, 38);
            this.lblLowValue.Name = "lblLowValue";
            this.lblLowValue.TabIndex = 1;
            this.lblLowValue.Text = "-";
            this.lblLowValue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.lblProductsCaption);
            this.pnlProducts.Controls.Add(this.lblProductsValue);
            this.pnlProducts.Location = new System.Drawing.Point(762, 60);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(230, 92);
            this.pnlProducts.TabIndex = 4;
            this.pnlProducts.BackColor = System.Drawing.Color.FromArgb(94, 53, 177);
            // 
            // lblProductsCaption
            // 
            this.lblProductsCaption.AutoSize = true;
            this.lblProductsCaption.Location = new System.Drawing.Point(14, 12);
            this.lblProductsCaption.Name = "lblProductsCaption";
            this.lblProductsCaption.TabIndex = 0;
            this.lblProductsCaption.Text = "Active products";
            this.lblProductsCaption.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // lblProductsValue
            // 
            this.lblProductsValue.AutoSize = true;
            this.lblProductsValue.Location = new System.Drawing.Point(14, 38);
            this.lblProductsValue.Name = "lblProductsValue";
            this.lblProductsValue.TabIndex = 1;
            this.lblProductsValue.Text = "-";
            this.lblProductsValue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblProductsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblLowTitle
            // 
            this.lblLowTitle.AutoSize = true;
            this.lblLowTitle.Location = new System.Drawing.Point(24, 172);
            this.lblLowTitle.Name = "lblLowTitle";
            this.lblLowTitle.TabIndex = 5;
            this.lblLowTitle.Text = "Low-stock items";
            this.lblLowTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnRefresh.Location = new System.Drawing.Point(884, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 28);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.MultiSelect = false;
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvLowStock.Location = new System.Drawing.Point(24, 204);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.Size = new System.Drawing.Size(942, 470);
            this.dgvLowStock.TabIndex = 7;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlLow);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.lblLowTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLowStock);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.pnlLow.ResumeLayout(false);
            this.pnlLow.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesCaption;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersCaption;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Panel pnlLow;
        private System.Windows.Forms.Label lblLowCaption;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lblProductsCaption;
        private System.Windows.Forms.Label lblProductsValue;
        private System.Windows.Forms.Label lblLowTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvLowStock;
    }
}
