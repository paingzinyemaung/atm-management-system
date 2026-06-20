namespace ATM_MS
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFaName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.cboEducation = new System.Windows.Forms.ComboBox();
            this.dobDate = new System.Windows.Forms.DateTimePicker();
            this.bnfTbSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
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
            this.titlePanel.Size = new System.Drawing.Size(1193, 132);
            this.titlePanel.TabIndex = 5;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1153, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(318, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 783);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 17);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(641, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(641, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "PHONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(167, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(167, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "FNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(167, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(167, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "ACC NUM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(641, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "EDUCATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(641, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "OCCUPATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(641, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "DOB";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.Location = new System.Drawing.Point(305, 266);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(209, 31);
            this.txtAccNum.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(305, 336);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 31);
            this.txtName.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(305, 471);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 89);
            this.txtAddress.TabIndex = 20;
            // 
            // txtFaName
            // 
            this.txtFaName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaName.Location = new System.Drawing.Point(305, 401);
            this.txtFaName.Name = "txtFaName";
            this.txtFaName.Size = new System.Drawing.Size(209, 31);
            this.txtFaName.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(810, 471);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(209, 31);
            this.txtPhone.TabIndex = 21;
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(810, 261);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(209, 31);
            this.txtPin.TabIndex = 22;
            // 
            // cboEducation
            // 
            this.cboEducation.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.cboEducation.FormattingEnabled = true;
            this.cboEducation.Items.AddRange(new object[] {
            "Non Graduate",
            "Under Graduate",
            "Post Graduate"});
            this.cboEducation.Location = new System.Drawing.Point(810, 331);
            this.cboEducation.Name = "cboEducation";
            this.cboEducation.Size = new System.Drawing.Size(209, 31);
            this.cboEducation.TabIndex = 24;
            // 
            // dobDate
            // 
            this.dobDate.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.dobDate.Location = new System.Drawing.Point(810, 531);
            this.dobDate.Name = "dobDate";
            this.dobDate.Size = new System.Drawing.Size(209, 31);
            this.dobDate.TabIndex = 26;
            // 
            // bnfTbSignUp
            // 
            this.bnfTbSignUp.ActiveBorderThickness = 1;
            this.bnfTbSignUp.ActiveCornerRadius = 20;
            this.bnfTbSignUp.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bnfTbSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbSignUp.ActiveLineColor = System.Drawing.Color.Yellow;
            this.bnfTbSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbSignUp.BackgroundImage")));
            this.bnfTbSignUp.ButtonText = "SIGNUP";
            this.bnfTbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbSignUp.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbSignUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbSignUp.IdleBorderThickness = 1;
            this.bnfTbSignUp.IdleCornerRadius = 20;
            this.bnfTbSignUp.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbSignUp.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbSignUp.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbSignUp.Location = new System.Drawing.Point(478, 650);
            this.bnfTbSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbSignUp.Name = "bnfTbSignUp";
            this.bnfTbSignUp.Size = new System.Drawing.Size(209, 46);
            this.bnfTbSignUp.TabIndex = 11;
            this.bnfTbSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbSignUp.Click += new System.EventHandler(this.bnfTbSignUp_Click_1);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogOut.Location = new System.Drawing.Point(540, 715);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(77, 23);
            this.lblLogOut.TabIndex = 27;
            this.lblLogOut.Text = "LOGIN";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // txtOccupation
            // 
            this.txtOccupation.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupation.Location = new System.Drawing.Point(810, 401);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(209, 31);
            this.txtOccupation.TabIndex = 28;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 800);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.bnfTbSignUp);
            this.Controls.Add(this.dobDate);
            this.Controls.Add(this.cboEducation);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFaName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFaName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.ComboBox cboEducation;
        private System.Windows.Forms.DateTimePicker dobDate;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbSignUp;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.TextBox txtOccupation;
    }
}