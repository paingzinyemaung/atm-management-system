namespace ATM_MS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptBx = new System.Windows.Forms.PictureBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblTtLogin = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.bnfTbLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBx)).BeginInit();
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
            this.titlePanel.TabIndex = 0;
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
            this.lblTitle.Location = new System.Drawing.Point(303, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // ptBx
            // 
            this.ptBx.Image = ((System.Drawing.Image)(resources.GetObject("ptBx.Image")));
            this.ptBx.Location = new System.Drawing.Point(85, 332);
            this.ptBx.Name = "ptBx";
            this.ptBx.Size = new System.Drawing.Size(190, 169);
            this.ptBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBx.TabIndex = 1;
            this.ptBx.TabStop = false;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccNum.Location = new System.Drawing.Point(374, 343);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(122, 26);
            this.lblAccNum.TabIndex = 2;
            this.lblAccNum.Text = "ACC NUM";
            // 
            // lblTtLogin
            // 
            this.lblTtLogin.AutoSize = true;
            this.lblTtLogin.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTtLogin.Location = new System.Drawing.Point(517, 135);
            this.lblTtLogin.Name = "lblTtLogin";
            this.lblTtLogin.Size = new System.Drawing.Size(110, 34);
            this.lblTtLogin.TabIndex = 3;
            this.lblTtLogin.Text = "LOGIN";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPinCode.Location = new System.Drawing.Point(374, 446);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(122, 26);
            this.lblPinCode.TabIndex = 4;
            this.lblPinCode.Text = "PIN CODE";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtAccNum.Location = new System.Drawing.Point(544, 340);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(209, 35);
            this.txtAccNum.TabIndex = 5;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtPinCode.Location = new System.Drawing.Point(544, 443);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '*';
            this.txtPinCode.Size = new System.Drawing.Size(209, 35);
            this.txtPinCode.TabIndex = 6;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSignUp.Location = new System.Drawing.Point(604, 634);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(86, 23);
            this.lblSignUp.TabIndex = 8;
            this.lblSignUp.Text = "SIGNUP";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // bnfTbLogin
            // 
            this.bnfTbLogin.ActiveBorderThickness = 1;
            this.bnfTbLogin.ActiveCornerRadius = 20;
            this.bnfTbLogin.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbLogin.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbLogin.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbLogin.BackgroundImage")));
            this.bnfTbLogin.ButtonText = "LOGIN";
            this.bnfTbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbLogin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbLogin.IdleBorderThickness = 1;
            this.bnfTbLogin.IdleCornerRadius = 20;
            this.bnfTbLogin.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbLogin.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbLogin.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbLogin.Location = new System.Drawing.Point(544, 528);
            this.bnfTbLogin.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbLogin.Name = "bnfTbLogin";
            this.bnfTbLogin.Size = new System.Drawing.Size(209, 46);
            this.bnfTbLogin.TabIndex = 9;
            this.bnfTbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbLogin.Click += new System.EventHandler(this.bnfTbLogin_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 790);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1126, 17);
            this.footerPanel.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 807);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.bnfTbLogin);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblTtLogin);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.ptBx);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptBx;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblTtLogin;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel footerPanel;
    }
}