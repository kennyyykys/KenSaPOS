namespace KenSaPOS.WinForms
{
    partial class AnalyticsControl
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
            this.pnlCharts = new System.Windows.Forms.Panel();
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDaily = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).BeginInit();
            this.pnlCharts.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCharts
            // 
            this.pnlCharts.Controls.Add(this.chartTop);
            this.pnlCharts.Controls.Add(this.chartCategory);
            this.pnlCharts.Controls.Add(this.chartDaily);
            this.pnlCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharts.Location = new System.Drawing.Point(0, 92);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.Size = new System.Drawing.Size(990, 608);
            this.pnlCharts.TabIndex = 0;
            // 
            // chartTop
            // 
            this.chartTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTop.Location = new System.Drawing.Point(0, 280);
            this.chartTop.Name = "chartTop";
            this.chartTop.Size = new System.Drawing.Size(590, 328);
            this.chartTop.TabIndex = 0;
            this.chartTop.BackColor = System.Drawing.Color.White;
            // 
            // chartCategory
            // 
            this.chartCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartCategory.Location = new System.Drawing.Point(590, 280);
            this.chartCategory.Name = "chartCategory";
            this.chartCategory.Size = new System.Drawing.Size(400, 328);
            this.chartCategory.TabIndex = 1;
            this.chartCategory.BackColor = System.Drawing.Color.White;
            // 
            // chartDaily
            // 
            this.chartDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartDaily.Location = new System.Drawing.Point(0, 0);
            this.chartDaily.Name = "chartDaily";
            this.chartDaily.Size = new System.Drawing.Size(990, 280);
            this.chartDaily.TabIndex = 2;
            this.chartDaily.BackColor = System.Drawing.Color.White;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.lblRevenue);
            this.pnlSummary.Controls.Add(this.lblOrders);
            this.pnlSummary.Controls.Add(this.lblAverage);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Location = new System.Drawing.Point(0, 52);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(990, 40);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(14, 11);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Revenue: -";
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(280, 11);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders: -";
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(480, 11);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "Avg order: -";
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblFrom);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.btnRun);
            this.pnlTop.Controls.Add(this.btnExport);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(990, 52);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(14, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(52, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 23);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(186, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(210, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 23);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(346, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 28);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run report";
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(0, 128, 107);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(454, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export CSV";
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(31, 56, 111);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // AnalyticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCharts);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnalyticsControl";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.AnalyticsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlCharts.ResumeLayout(false);
            this.pnlCharts.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDaily;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExport;
    }
}
