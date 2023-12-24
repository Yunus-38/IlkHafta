namespace Metotlar
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
            this.btnPower = new System.Windows.Forms.Button();
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.btnRecursion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(74, 97);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(122, 72);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = "Kuvvet Alma";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(74, 12);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(122, 20);
            this.txtDeger1.TabIndex = 1;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(74, 39);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(122, 20);
            this.txtDeger2.TabIndex = 2;
            // 
            // btnRecursion
            // 
            this.btnRecursion.Location = new System.Drawing.Point(74, 176);
            this.btnRecursion.Name = "btnRecursion";
            this.btnRecursion.Size = new System.Drawing.Size(122, 57);
            this.btnRecursion.TabIndex = 3;
            this.btnRecursion.Text = "Yinelemeli Mesaj";
            this.btnRecursion.UseVisualStyleBackColor = true;
            this.btnRecursion.Click += new System.EventHandler(this.btnRecursion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 342);
            this.Controls.Add(this.btnRecursion);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.btnPower);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnRecursion;
    }
}

