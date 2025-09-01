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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptBx = new System.Windows.Forms.PictureBox();
            this.myPgBar = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptBx)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(154, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // ptBx
            // 
            this.ptBx.Image = ((System.Drawing.Image)(resources.GetObject("ptBx.Image")));
            this.ptBx.Location = new System.Drawing.Point(230, 121);
            this.ptBx.Name = "ptBx";
            this.ptBx.Size = new System.Drawing.Size(384, 284);
            this.ptBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBx.TabIndex = 2;
            this.ptBx.TabStop = false;
            // 
            // myPgBar
            // 
            this.myPgBar.Location = new System.Drawing.Point(1, 500);
            this.myPgBar.Name = "myPgBar";
            this.myPgBar.Size = new System.Drawing.Size(863, 19);
            this.myPgBar.TabIndex = 3;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(413, 440);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(44, 42);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(865, 518);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.myPgBar);
            this.Controls.Add(this.ptBx);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptBx;
        private System.Windows.Forms.ProgressBar myPgBar;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Timer timer1;
    }
}

