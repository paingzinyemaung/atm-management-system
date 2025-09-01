namespace ATM_MS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bnfTbDeposit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTbMs = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTbBl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTbChangePin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTbFastCash = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfTbWithdraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
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
            this.titlePanel.TabIndex = 4;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1086, 4);
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
            this.lblTitle.Location = new System.Drawing.Point(277, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Select Your Translation Please";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // bnfTbDeposit
            // 
            this.bnfTbDeposit.ActiveBorderThickness = 1;
            this.bnfTbDeposit.ActiveCornerRadius = 20;
            this.bnfTbDeposit.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbDeposit.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbDeposit.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbDeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbDeposit.BackgroundImage")));
            this.bnfTbDeposit.ButtonText = "DEPOSIT";
            this.bnfTbDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbDeposit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbDeposit.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbDeposit.IdleBorderThickness = 1;
            this.bnfTbDeposit.IdleCornerRadius = 20;
            this.bnfTbDeposit.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbDeposit.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbDeposit.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbDeposit.Location = new System.Drawing.Point(234, 306);
            this.bnfTbDeposit.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbDeposit.Name = "bnfTbDeposit";
            this.bnfTbDeposit.Size = new System.Drawing.Size(209, 46);
            this.bnfTbDeposit.TabIndex = 10;
            this.bnfTbDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbDeposit.Click += new System.EventHandler(this.bnfTbDeposit_Click);
            // 
            // bnfTbMs
            // 
            this.bnfTbMs.ActiveBorderThickness = 1;
            this.bnfTbMs.ActiveCornerRadius = 20;
            this.bnfTbMs.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbMs.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbMs.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbMs.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbMs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbMs.BackgroundImage")));
            this.bnfTbMs.ButtonText = "MINI STATEMENT";
            this.bnfTbMs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbMs.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbMs.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbMs.IdleBorderThickness = 1;
            this.bnfTbMs.IdleCornerRadius = 20;
            this.bnfTbMs.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbMs.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbMs.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbMs.Location = new System.Drawing.Point(678, 437);
            this.bnfTbMs.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbMs.Name = "bnfTbMs";
            this.bnfTbMs.Size = new System.Drawing.Size(209, 46);
            this.bnfTbMs.TabIndex = 11;
            this.bnfTbMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbMs.Click += new System.EventHandler(this.bnfTbMs_Click);
            // 
            // bnfTbBl
            // 
            this.bnfTbBl.ActiveBorderThickness = 1;
            this.bnfTbBl.ActiveCornerRadius = 20;
            this.bnfTbBl.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbBl.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbBl.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbBl.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbBl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbBl.BackgroundImage")));
            this.bnfTbBl.ButtonText = "BALANCE";
            this.bnfTbBl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbBl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbBl.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbBl.IdleBorderThickness = 1;
            this.bnfTbBl.IdleCornerRadius = 20;
            this.bnfTbBl.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbBl.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbBl.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbBl.Location = new System.Drawing.Point(678, 570);
            this.bnfTbBl.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbBl.Name = "bnfTbBl";
            this.bnfTbBl.Size = new System.Drawing.Size(209, 46);
            this.bnfTbBl.TabIndex = 12;
            this.bnfTbBl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbBl.Click += new System.EventHandler(this.bnfTbBl_Click);
            // 
            // bnfTbChangePin
            // 
            this.bnfTbChangePin.ActiveBorderThickness = 1;
            this.bnfTbChangePin.ActiveCornerRadius = 20;
            this.bnfTbChangePin.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbChangePin.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbChangePin.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbChangePin.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbChangePin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbChangePin.BackgroundImage")));
            this.bnfTbChangePin.ButtonText = "CHANGE PIN";
            this.bnfTbChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbChangePin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbChangePin.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbChangePin.IdleBorderThickness = 1;
            this.bnfTbChangePin.IdleCornerRadius = 20;
            this.bnfTbChangePin.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbChangePin.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbChangePin.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbChangePin.Location = new System.Drawing.Point(234, 570);
            this.bnfTbChangePin.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbChangePin.Name = "bnfTbChangePin";
            this.bnfTbChangePin.Size = new System.Drawing.Size(209, 46);
            this.bnfTbChangePin.TabIndex = 13;
            this.bnfTbChangePin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbChangePin.Click += new System.EventHandler(this.bnfTbChangePin_Click);
            // 
            // bnfTbFastCash
            // 
            this.bnfTbFastCash.ActiveBorderThickness = 1;
            this.bnfTbFastCash.ActiveCornerRadius = 20;
            this.bnfTbFastCash.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbFastCash.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbFastCash.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbFastCash.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbFastCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbFastCash.BackgroundImage")));
            this.bnfTbFastCash.ButtonText = "FAST CASH";
            this.bnfTbFastCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbFastCash.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbFastCash.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbFastCash.IdleBorderThickness = 1;
            this.bnfTbFastCash.IdleCornerRadius = 20;
            this.bnfTbFastCash.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbFastCash.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbFastCash.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbFastCash.Location = new System.Drawing.Point(234, 437);
            this.bnfTbFastCash.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbFastCash.Name = "bnfTbFastCash";
            this.bnfTbFastCash.Size = new System.Drawing.Size(209, 46);
            this.bnfTbFastCash.TabIndex = 14;
            this.bnfTbFastCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbFastCash.Click += new System.EventHandler(this.bnfTbFastCash_Click);
            // 
            // bnfTbWithdraw
            // 
            this.bnfTbWithdraw.ActiveBorderThickness = 1;
            this.bnfTbWithdraw.ActiveCornerRadius = 20;
            this.bnfTbWithdraw.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbWithdraw.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbWithdraw.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbWithdraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbWithdraw.BackgroundImage")));
            this.bnfTbWithdraw.ButtonText = "WITHDRAW";
            this.bnfTbWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbWithdraw.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbWithdraw.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbWithdraw.IdleBorderThickness = 1;
            this.bnfTbWithdraw.IdleCornerRadius = 20;
            this.bnfTbWithdraw.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbWithdraw.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbWithdraw.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbWithdraw.Location = new System.Drawing.Point(678, 306);
            this.bnfTbWithdraw.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbWithdraw.Name = "bnfTbWithdraw";
            this.bnfTbWithdraw.Size = new System.Drawing.Size(209, 46);
            this.bnfTbWithdraw.TabIndex = 15;
            this.bnfTbWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbWithdraw.Click += new System.EventHandler(this.bnfTbWithdraw_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 790);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1126, 17);
            this.footerPanel.TabIndex = 16;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogOut.Location = new System.Drawing.Point(526, 710);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(96, 23);
            this.lblLogOut.TabIndex = 9;
            this.lblLogOut.Text = "LOGOUT";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccNumber.Location = new System.Drawing.Point(336, 208);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(266, 34);
            this.lblAccNumber.TabIndex = 17;
            this.lblAccNumber.Text = "Account Number";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHome.Location = new System.Drawing.Point(520, 135);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(102, 34);
            this.lblHome.TabIndex = 18;
            this.lblHome.Text = "Home";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 807);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.bnfTbWithdraw);
            this.Controls.Add(this.bnfTbFastCash);
            this.Controls.Add(this.bnfTbChangePin);
            this.Controls.Add(this.bnfTbBl);
            this.Controls.Add(this.bnfTbMs);
            this.Controls.Add(this.bnfTbDeposit);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbDeposit;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbMs;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbBl;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbChangePin;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbFastCash;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbWithdraw;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Label lblHome;
    }
}