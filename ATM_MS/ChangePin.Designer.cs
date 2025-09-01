namespace ATM_MS
{
    partial class ChangePin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePin));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblConfrimPin = new System.Windows.Forms.Label();
            this.lblNewPin = new System.Windows.Forms.Label();
            this.bnfTbChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtConfirmPin = new System.Windows.Forms.TextBox();
            this.txtNewPin = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.titlePanel.Size = new System.Drawing.Size(1041, 132);
            this.titlePanel.TabIndex = 7;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1002, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(240, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblConfrimPin
            // 
            this.lblConfrimPin.AutoSize = true;
            this.lblConfrimPin.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfrimPin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblConfrimPin.Location = new System.Drawing.Point(249, 385);
            this.lblConfrimPin.Name = "lblConfrimPin";
            this.lblConfrimPin.Size = new System.Drawing.Size(172, 26);
            this.lblConfrimPin.TabIndex = 13;
            this.lblConfrimPin.Text = "CONFIRM PIN:";
            // 
            // lblNewPin
            // 
            this.lblNewPin.AutoSize = true;
            this.lblNewPin.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNewPin.Location = new System.Drawing.Point(249, 294);
            this.lblNewPin.Name = "lblNewPin";
            this.lblNewPin.Size = new System.Drawing.Size(115, 26);
            this.lblNewPin.TabIndex = 12;
            this.lblNewPin.Text = "NEW PIN:";
            // 
            // bnfTbChange
            // 
            this.bnfTbChange.ActiveBorderThickness = 1;
            this.bnfTbChange.ActiveCornerRadius = 20;
            this.bnfTbChange.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bnfTbChange.ActiveForecolor = System.Drawing.Color.White;
            this.bnfTbChange.ActiveLineColor = System.Drawing.Color.SlateBlue;
            this.bnfTbChange.BackColor = System.Drawing.SystemColors.Control;
            this.bnfTbChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfTbChange.BackgroundImage")));
            this.bnfTbChange.ButtonText = "CHANGE";
            this.bnfTbChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTbChange.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfTbChange.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfTbChange.IdleBorderThickness = 1;
            this.bnfTbChange.IdleCornerRadius = 20;
            this.bnfTbChange.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbChange.IdleForecolor = System.Drawing.Color.White;
            this.bnfTbChange.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bnfTbChange.Location = new System.Drawing.Point(479, 459);
            this.bnfTbChange.Margin = new System.Windows.Forms.Padding(5);
            this.bnfTbChange.Name = "bnfTbChange";
            this.bnfTbChange.Size = new System.Drawing.Size(209, 46);
            this.bnfTbChange.TabIndex = 17;
            this.bnfTbChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfTbChange.Click += new System.EventHandler(this.bnfTbLogin_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBack.Location = new System.Drawing.Point(549, 551);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(66, 23);
            this.lblBack.TabIndex = 16;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // txtConfirmPin
            // 
            this.txtConfirmPin.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtConfirmPin.Location = new System.Drawing.Point(479, 382);
            this.txtConfirmPin.Name = "txtConfirmPin";
            this.txtConfirmPin.Size = new System.Drawing.Size(209, 35);
            this.txtConfirmPin.TabIndex = 15;
            // 
            // txtNewPin
            // 
            this.txtNewPin.Font = new System.Drawing.Font("Lucida Bright", 13.8F);
            this.txtNewPin.Location = new System.Drawing.Point(479, 291);
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.Size = new System.Drawing.Size(209, 35);
            this.txtNewPin.TabIndex = 14;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 659);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1041, 10);
            this.bottomPanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(425, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "CHANGE PIN";
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.bnfTbChange);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtConfirmPin);
            this.Controls.Add(this.txtNewPin);
            this.Controls.Add(this.lblConfrimPin);
            this.Controls.Add(this.lblNewPin);
            this.Controls.Add(this.titlePanel);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConfrimPin;
        private System.Windows.Forms.Label lblNewPin;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfTbChange;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtConfirmPin;
        private System.Windows.Forms.TextBox txtNewPin;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label1;
    }
}