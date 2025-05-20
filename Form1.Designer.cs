namespace odev2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelSozluk;
        private System.Windows.Forms.ComboBox comboSozluk;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnCikis;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelSozluk = new System.Windows.Forms.Label();
            this.comboSozluk = new System.Windows.Forms.ComboBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSozluk
            // 
            this.labelSozluk.AutoSize = true;
            this.labelSozluk.Location = new System.Drawing.Point(201, 134);
            this.labelSozluk.Name = "labelSozluk";
            this.labelSozluk.Size = new System.Drawing.Size(50, 16);
            this.labelSozluk.TabIndex = 0;
            this.labelSozluk.Text = "Sözlük:";
            // 
            // comboSozluk
            // 
            this.comboSozluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSozluk.FormattingEnabled = true;
            this.comboSozluk.Location = new System.Drawing.Point(204, 164);
            this.comboSozluk.Name = "comboSozluk";
            this.comboSozluk.Size = new System.Drawing.Size(256, 24);
            this.comboSozluk.TabIndex = 1;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(204, 225);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 25);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Enabled = false;
            this.btnBaslat.Location = new System.Drawing.Point(295, 225);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 25);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(385, 225);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 25);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(732, 424);
            this.Controls.Add(this.labelSozluk);
            this.Controls.Add(this.comboSozluk);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Ezberleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

