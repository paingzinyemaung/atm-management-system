namespace ATM_MS
{
    partial class FastCash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastCash));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.bnfTb30000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTb50000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTb300000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTb500000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTb100000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTb10000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblFastCash = new System.Windows.Forms.Label();
            this.lblAvailBal = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.titlePanel.Controls.Add(this.lblClose);
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1126, 132);
            this.titlePanel.TabIndex = 17;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1086, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 34);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(279, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBack.Location = new System.Drawing.Point(542, 715);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(66, 23);
            this.lblBack.TabIndex = 18;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 790);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1126, 17);
            this.footerPanel.TabIndex = 25;
            // 
            // bnfTb30000
            // 
            this.bnfTb30000.ActiveBorderThickness = 1;
            this.bnfTb30000.ActiveCornerRadius = 20;
            this.bnfTb30000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb30000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb30000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb30000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb30000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb30000.BackgroundImage")));
            this.bnfTb30000.ButtonText = "MMK 30000";
            this.bnfTb30000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb30000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb30000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb30000.IdleBorderThickness = 1;
            this.bnfTb30000.IdleCornerRadius = 20;
            this.bnfTb30000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb30000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb30000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb30000.Location = new System.Drawing.Point(682, 293);
            this.bnfTb30000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb30000.Name = "bnfTb30000";
            this.bnfTb30000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb30000.TabIndex = 24;
            this.bnfTb30000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb30000.Click += new System.EventHandler(this.bnfTb30000_Click);
            // 
            // bnfTb50000
            // 
            this.bnfTb50000.ActiveBorderThickness = 1;
            this.bnfTb50000.ActiveCornerRadius = 20;
            this.bnfTb50000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb50000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb50000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb50000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb50000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb50000.BackgroundImage")));
            this.bnfTb50000.ButtonText = "MMK 50000";
            this.bnfTb50000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb50000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb50000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb50000.IdleBorderThickness = 1;
            this.bnfTb50000.IdleCornerRadius = 20;
            this.bnfTb50000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb50000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb50000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb50000.Location = new System.Drawing.Point(233, 431);
            this.bnfTb50000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb50000.Name = "bnfTb50000";
            this.bnfTb50000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb50000.TabIndex = 23;
            this.bnfTb50000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb50000.Click += new System.EventHandler(this.bnfTb50000_Click);
            // 
            // bnfTb300000
            // 
            this.bnfTb300000.ActiveBorderThickness = 1;
            this.bnfTb300000.ActiveCornerRadius = 20;
            this.bnfTb300000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb300000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb300000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb300000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb300000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb300000.BackgroundImage")));
            this.bnfTb300000.ButtonText = "MMK 300000";
            this.bnfTb300000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb300000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb300000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb300000.IdleBorderThickness = 1;
            this.bnfTb300000.IdleCornerRadius = 20;
            this.bnfTb300000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb300000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb300000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb300000.Location = new System.Drawing.Point(233, 569);
            this.bnfTb300000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb300000.Name = "bnfTb300000";
            this.bnfTb300000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb300000.TabIndex = 22;
            this.bnfTb300000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb300000.Click += new System.EventHandler(this.bnfTb300000_Click);
            // 
            // bnfTb500000
            // 
            this.bnfTb500000.ActiveBorderThickness = 1;
            this.bnfTb500000.ActiveCornerRadius = 20;
            this.bnfTb500000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb500000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb500000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb500000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb500000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb500000.BackgroundImage")));
            this.bnfTb500000.ButtonText = "MMK 500000";
            this.bnfTb500000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb500000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb500000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb500000.IdleBorderThickness = 1;
            this.bnfTb500000.IdleCornerRadius = 20;
            this.bnfTb500000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb500000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb500000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb500000.Location = new System.Drawing.Point(682, 569);
            this.bnfTb500000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb500000.Name = "bnfTb500000";
            this.bnfTb500000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb500000.TabIndex = 21;
            this.bnfTb500000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb500000.Click += new System.EventHandler(this.bnfTb500000_Click);
            // 
            // bnfTb100000
            // 
            this.bnfTb100000.ActiveBorderThickness = 1;
            this.bnfTb100000.ActiveCornerRadius = 20;
            this.bnfTb100000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb100000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb100000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb100000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb100000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb100000.BackgroundImage")));
            this.bnfTb100000.ButtonText = "MMK 100000";
            this.bnfTb100000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb100000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb100000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb100000.IdleBorderThickness = 1;
            this.bnfTb100000.IdleCornerRadius = 20;
            this.bnfTb100000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb100000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb100000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb100000.Location = new System.Drawing.Point(682, 431);
            this.bnfTb100000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb100000.Name = "bnfTb100000";
            this.bnfTb100000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb100000.TabIndex = 20;
            this.bnfTb100000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb100000.Click += new System.EventHandler(this.bnfTb100000_Click);
            // 
            // bnfTb10000
            // 
            this.bnfTb10000.ActiveBorderThickness = 1;
            this.bnfTb10000.ActiveCornerRadius = 20;
            this.bnfTb10000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnfTb10000.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTb10000.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bnfTb10000.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTb10000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTb10000.BackgroundImage")));
            this.bnfTb10000.ButtonText = "MMK 10000";
            this.bnfTb10000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTb10000.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTb10000.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTb10000.IdleBorderThickness = 1;
            this.bnfTb10000.IdleCornerRadius = 20;
            this.bnfTb10000.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb10000.IdleForecolor = System.Drawing.Color.White;
            this.bnfTb10000.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTb10000.Location = new System.Drawing.Point(233, 293);
            this.bnfTb10000.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTb10000.Name = "bnfTb10000";
            this.bnfTb10000.Size = new System.Drawing.Size(209, 46);
            this.bnfTb10000.TabIndex = 19;
            this.bnfTb10000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTb10000.Click += new System.EventHandler(this.bnfTb10000_Click);
            // 
            // lblFastCash
            // 
            this.lblFastCash.AutoSize = true;
            this.lblFastCash.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastCash.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFastCash.Location = new System.Drawing.Point(469, 135);
            this.lblFastCash.Name = "lblFastCash";
            this.lblFastCash.Size = new System.Drawing.Size(173, 34);
            this.lblFastCash.TabIndex = 11;
            this.lblFastCash.Text = "FASTCASH";
            // 
            // lblAvailBal
            // 
            this.lblAvailBal.AutoSize = true;
            this.lblAvailBal.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAvailBal.Location = new System.Drawing.Point(392, 213);
            this.lblAvailBal.Name = "lblAvailBal";
            this.lblAvailBal.Size = new System.Drawing.Size(208, 26);
            this.lblAvailBal.TabIndex = 26;
            this.lblAvailBal.Text = "Available Balance";
            this.lblAvailBal.Click += new System.EventHandler(this.lblAvailBal_Click);
            // 
            // FastCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 807);
            this.Controls.Add(this.lblAvailBal);
            this.Controls.Add(this.lblFastCash);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.bnfTb30000);
            this.Controls.Add(this.bnfTb50000);
            this.Controls.Add(this.bnfTb300000);
            this.Controls.Add(this.bnfTb500000);
            this.Controls.Add(this.bnfTb100000);
            this.Controls.Add(this.bnfTb10000);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastCash";
            this.Load += new System.EventHandler(this.FastCash_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel footerPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb30000;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb50000;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb300000;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb500000;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb100000;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTb10000;
        private System.Windows.Forms.Label lblFastCash;
        private System.Windows.Forms.Label lblAvailBal;
    }
}