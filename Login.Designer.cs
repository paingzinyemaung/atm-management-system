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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.ptBox = new System.Windows.Forms.PictureBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("YouYuan", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(138, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("YouYuan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogin.Location = new System.Drawing.Point(340, 103);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(93, 30);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // ptBox
            // 
            this.ptBox.Image = ((System.Drawing.Image)(resources.GetObject("ptBox.Image")));
            this.ptBox.Location = new System.Drawing.Point(25, 203);
            this.ptBox.Name = "ptBox";
            this.ptBox.Size = new System.Drawing.Size(158, 136);
            this.ptBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBox.TabIndex = 3;
            this.ptBox.TabStop = false;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("YouYuan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccName.Location = new System.Drawing.Point(213, 212);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(114, 24);
            this.lblAccName.TabIndex = 4;
            this.lblAccName.Text = "ACC NUM:";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("YouYuan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPinCode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPinCode.Location = new System.Drawing.Point(213, 297);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(127, 24);
            this.lblPinCode.TabIndex = 5;
            this.lblPinCode.Text = "PIN CODE:";
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("YouYuan", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAccName.Location = new System.Drawing.Point(385, 209);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(208, 33);
            this.txtAccName.TabIndex = 6;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("YouYuan", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtPinCode.Location = new System.Drawing.Point(385, 294);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(208, 33);
            this.txtPinCode.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Font = new System.Drawing.Font("YouYuan", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(385, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 33);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("YouYuan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignUp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSignUp.Location = new System.Drawing.Point(452, 399);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(75, 20);
            this.lblSignUp.TabIndex = 9;
            this.lblSignUp.Text = "SIGNUP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.ptBox);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox ptBox;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}