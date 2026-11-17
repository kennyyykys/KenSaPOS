namespace KenSaPOS.WinForms
{
    partial class MainForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(210, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(990, 720);
            this.pnlContent.TabIndex = 0;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.flpNav);
            this.pnlSidebar.Controls.Add(this.lblUser);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 720);
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(210, 64);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "ENTERPRISE POS";
            this.lblBrand.AutoSize = false;
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.btnDashboard);
            this.flpNav.Controls.Add(this.btnPos);
            this.flpNav.Controls.Add(this.btnInventory);
            this.flpNav.Controls.Add(this.btnAnalytics);
            this.flpNav.Controls.Add(this.btnUsers);
            this.flpNav.Location = new System.Drawing.Point(0, 70);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(210, 300);
            this.flpNav.TabIndex = 1;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.WrapContents = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 44);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPos
            // 
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(210, 44);
            this.btnPos.TabIndex = 1;
            this.btnPos.Text = "Point of Sale (F2)";
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(210, 44);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(210, 44);
            this.btnAnalytics.TabIndex = 3;
            this.btnAnalytics.Text = "Sales Analytics";
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnalytics.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 44);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users && Roles";
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblUser.Location = new System.Drawing.Point(0, 630);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(210, 44);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "";
            this.lblUser.AutoSize = false;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(200, 212, 235);
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnLogout.Location = new System.Drawing.Point(0, 592);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "MainForm";
            this.Text = "Enterprise Store - POS and Inventory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.flpNav.ResumeLayout(false);
            this.flpNav.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
    }
}
