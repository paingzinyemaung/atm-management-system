namespace ATM_MS
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptBox = new System.Windows.Forms.PictureBox();
            this.myPgBar = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("YouYuan", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(189, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // ptBox
            // 
            this.ptBox.Image = ((System.Drawing.Image)(resources.GetObject("ptBox.Image")));
            this.ptBox.Location = new System.Drawing.Point(227, 97);
            this.ptBox.Name = "ptBox";
            this.ptBox.Size = new System.Drawing.Size(359, 247);
            this.ptBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBox.TabIndex = 1;
            this.ptBox.TabStop = false;
            // 
            // myPgBar
            // 
            this.myPgBar.Location = new System.Drawing.Point(-1, 426);
            this.myPgBar.Name = "myPgBar";
            this.myPgBar.Size = new System.Drawing.Size(796, 17);
            this.myPgBar.TabIndex = 2;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("YouYuan", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPercent.ForeColor = System.Drawing.Color.White;
            this.lblPercent.Location = new System.Drawing.Point(381, 375);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(37, 38);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.myPgBar);
            this.Controls.Add(this.ptBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptBox;
        private System.Windows.Forms.ProgressBar myPgBar;
        private System.Windows.Forms.Label lblPercent;
    }
}

