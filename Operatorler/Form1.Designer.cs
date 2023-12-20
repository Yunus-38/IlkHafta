namespace Operatorler
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
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(59, 12);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(163, 20);
            this.txtDeger1.TabIndex = 0;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(59, 38);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(163, 20);
            this.txtDeger2.TabIndex = 1;
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(59, 64);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(163, 41);
            this.btnToplama.TabIndex = 2;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(59, 111);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(163, 44);
            this.btnCikarma.TabIndex = 3;
            this.btnCikarma.Text = "Çıkarma";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(59, 161);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(160, 43);
            this.btnCarpma.TabIndex = 4;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(59, 210);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(160, 46);
            this.btnBolme.TabIndex = 5;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(59, 262);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(163, 44);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 380);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnMod;
    }
}

