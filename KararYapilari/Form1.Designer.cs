namespace KararYapilari
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSayiKontrol = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnHarfNotu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(77, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(100, 20);
            this.txtDeger.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(77, 38);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 47);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "button1";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSayiKontrol
            // 
            this.btnSayiKontrol.Location = new System.Drawing.Point(77, 91);
            this.btnSayiKontrol.Name = "btnSayiKontrol";
            this.btnSayiKontrol.Size = new System.Drawing.Size(100, 49);
            this.btnSayiKontrol.TabIndex = 2;
            this.btnSayiKontrol.Text = "Sayı Kontrol";
            this.btnSayiKontrol.UseVisualStyleBackColor = true;
            this.btnSayiKontrol.Click += new System.EventHandler(this.btnSayiKontrol_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(77, 146);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(100, 44);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnHarfNotu
            // 
            this.btnHarfNotu.Location = new System.Drawing.Point(77, 196);
            this.btnHarfNotu.Name = "btnHarfNotu";
            this.btnHarfNotu.Size = new System.Drawing.Size(100, 39);
            this.btnHarfNotu.TabIndex = 4;
            this.btnHarfNotu.Text = "Harf Notu";
            this.btnHarfNotu.UseVisualStyleBackColor = true;
            this.btnHarfNotu.Click += new System.EventHandler(this.btnHarfNotu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 276);
            this.Controls.Add(this.btnHarfNotu);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnSayiKontrol);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSayiKontrol;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnHarfNotu;
    }
}

