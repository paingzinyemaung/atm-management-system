namespace ATM_MS
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bnfTbWithdraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAvailableBalance = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.titlePanel.Controls.Add(this.lblClose);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1041, 132);
            this.titlePanel.TabIndex = 24;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1001, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 34);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 204);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 42);
            this.lblTitle.TabIndex = 23;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWithdraw.Location = new System.Drawing.Point(436, 135);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(188, 34);
            this.lblWithdraw.TabIndex = 25;
            this.lblWithdraw.Text = "WITHDRAW";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 653);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1041, 16);
            this.bottomPanel.TabIndex = 30;
            // 
            // bnfTbWithdraw
            // 
            this.bnfTbWithdraw.ActiveBorderThickness = 1;
            this.bnfTbWithdraw.ActiveCornerRadius = 20;
            this.bnfTbWithdraw.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bnfTbWithdraw.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbWithdraw.ActiveLineColor = System.Drawing.Color.SlateBlue;
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
            this.bnfTbWithdraw.Location = new System.Drawing.Point(479, 446);
            this.bnfTbWithdraw.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbWithdraw.Name = "bnfTbWithdraw";
            this.bnfTbWithdraw.Size = new System.Drawing.Size(209, 46);
            this.bnfTbWithdraw.TabIndex = 29;
            this.bnfTbWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbWithdraw.Click += new System.EventHandler(this.bnfTbWithdraw_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogOut.Location = new System.Drawing.Point(544, 547);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(66, 23);
            this.lblLogOut.TabIndex = 28;
            this.lblLogOut.Text = "BACK";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtAmount.Location = new System.Drawing.Point(479, 360);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(209, 35);
            this.txtAmount.TabIndex = 27;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAmount.Location = new System.Drawing.Point(268, 363);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(123, 26);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "AMOUNT:";
            // 
            // lblAvailableBalance
            // 
            this.lblAvailableBalance.AutoSize = true;
            this.lblAvailableBalance.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBalance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAvailableBalance.Location = new System.Drawing.Point(324, 243);
            this.lblAvailableBalance.Name = "lblAvailableBalance";
            this.lblAvailableBalance.Size = new System.Drawing.Size(269, 34);
            this.lblAvailableBalance.TabIndex = 31;
            this.lblAvailableBalance.Text = "Available Balance";
            this.lblAvailableBalance.Click += new System.EventHandler(this.lblAvailableBalance_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 669);
            this.Controls.Add(this.lblAvailableBalance);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.bnfTbWithdraw);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbWithdraw;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAvailableBalance;
    }
}