namespace IlkHafta
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
            this.btnMesaj = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(12, 65);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(189, 44);
            this.btnMesaj.TabIndex = 0;
            this.btnMesaj.Text = "BUTON";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(55, 23);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(100, 20);
            this.txtDeger.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 275);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.btnMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesaj;
        private System.Windows.Forms.TextBox txtDeger;
    }
}

