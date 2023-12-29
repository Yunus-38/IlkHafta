namespace KutuphaneSistemi
{
    partial class Form1
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKitapIsmi = new System.Windows.Forms.TextBox();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbxYayinYili = new System.Windows.Forms.ComboBox();
            this.btnRastgeleKitap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(13, 154);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKitapIsmi
            // 
            this.txtKitapIsmi.Location = new System.Drawing.Point(12, 84);
            this.txtKitapIsmi.Name = "txtKitapIsmi";
            this.txtKitapIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapIsmi.TabIndex = 1;
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(139, 12);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(162, 251);
            this.lstKitaplar.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(13, 183);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 29);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbxYayinYili
            // 
            this.cbxYayinYili.FormattingEnabled = true;
            this.cbxYayinYili.Items.AddRange(new object[] {
            "1800",
            "1801",
            "1900",
            "1995",
            "2000",
            "2015",
            "2023"});
            this.cbxYayinYili.Location = new System.Drawing.Point(12, 110);
            this.cbxYayinYili.Name = "cbxYayinYili";
            this.cbxYayinYili.Size = new System.Drawing.Size(100, 21);
            this.cbxYayinYili.TabIndex = 4;
            // 
            // btnRastgeleKitap
            // 
            this.btnRastgeleKitap.Location = new System.Drawing.Point(13, 218);
            this.btnRastgeleKitap.Name = "btnRastgeleKitap";
            this.btnRastgeleKitap.Size = new System.Drawing.Size(99, 26);
            this.btnRastgeleKitap.TabIndex = 5;
            this.btnRastgeleKitap.Text = "RastgeleKitap";
            this.btnRastgeleKitap.UseVisualStyleBackColor = true;
            this.btnRastgeleKitap.Click += new System.EventHandler(this.btnRastgeleKitap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 328);
            this.Controls.Add(this.btnRastgeleKitap);
            this.Controls.Add(this.cbxYayinYili);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.txtKitapIsmi);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKitapIsmi;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbxYayinYili;
        private System.Windows.Forms.Button btnRastgeleKitap;
    }
}

