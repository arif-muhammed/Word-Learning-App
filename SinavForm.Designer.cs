namespace odev2
{
    partial class SinavForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblProgress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKelime.Location = new System.Drawing.Point(30, 20);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(440, 40);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Text = "KELİME";
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(50, 80);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(180, 40);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Seçenek A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(290, 80);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(180, 40);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "Seçenek B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(50, 140);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(180, 40);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Seçenek C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(290, 140);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(180, 40);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "Seçenek D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.Option_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(50, 200);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 16);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Puan: 0";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(350, 200);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(62, 16);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Soru 0 / 0";
            // 
            // SinavForm
            // 
            this.ClientSize = new System.Drawing.Size(536, 267);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SinavForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.SinavForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}