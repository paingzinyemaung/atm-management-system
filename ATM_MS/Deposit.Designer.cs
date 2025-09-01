namespace ATM_MS
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.lblTitle = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnfTbDeposit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 204);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 42);
            this.lblTitle.TabIndex = 3;
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
            this.titlePanel.TabIndex = 8;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1000, 2);
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
            this.label1.Location = new System.Drawing.Point(251, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // bnfTbDeposit
            // 
            this.bnfTbDeposit.ActiveBorderThickness = 1;
            this.bnfTbDeposit.ActiveCornerRadius = 20;
            this.bnfTbDeposit.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bnfTbDeposit.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbDeposit.ActiveLineColor = System.Drawing.Color.SlateBlue;
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
            this.bnfTbDeposit.Location = new System.Drawing.Point(469, 418);
            this.bnfTbDeposit.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbDeposit.Name = "bnfTbDeposit";
            this.bnfTbDeposit.Size = new System.Drawing.Size(209, 46);
            this.bnfTbDeposit.TabIndex = 21;
            this.bnfTbDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbDeposit.Click += new System.EventHandler(this.bnfTbDeposit_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBack.Location = new System.Drawing.Point(543, 518);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(66, 23);
            this.lblBack.TabIndex = 20;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtAmount.Location = new System.Drawing.Point(469, 325);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(209, 35);
            this.txtAmount.TabIndex = 19;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAmount.Location = new System.Drawing.Point(266, 328);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(123, 26);
            this.lblAmount.TabIndex = 18;
            this.lblAmount.Text = "AMOUNT:";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 653);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1041, 16);
            this.bottomPanel.TabIndex = 22;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(448, 135);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(141, 34);
            this.lblDeposit.TabIndex = 11;
            this.lblDeposit.Text = "DEPOSIT";
            this.lblDeposit.Click += new System.EventHandler(this.lblDeposit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 669);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.bnfTbDeposit);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbDeposit;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblDeposit;
    }
}