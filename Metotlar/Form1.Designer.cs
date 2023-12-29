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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnAyir = new System.Windows.Forms.Button();
            this.btnOverload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(74, 65);
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
            this.btnRecursion.Location = new System.Drawing.Point(74, 144);
            this.btnRecursion.Name = "btnRecursion";
            this.btnRecursion.Size = new System.Drawing.Size(122, 57);
            this.btnRecursion.TabIndex = 3;
            this.btnRecursion.Text = "Yinelemeli Mesaj";
            this.btnRecursion.UseVisualStyleBackColor = true;
            this.btnRecursion.Click += new System.EventHandler(this.btnRecursion_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(74, 207);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(119, 58);
            this.btnFactorial.TabIndex = 4;
            this.btnFactorial.Text = "Faktöriyel";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnAyir
            // 
            this.btnAyir.Location = new System.Drawing.Point(74, 271);
            this.btnAyir.Name = "btnAyir";
            this.btnAyir.Size = new System.Drawing.Size(119, 59);
            this.btnAyir.TabIndex = 5;
            this.btnAyir.Text = "Ayırıcı";
            this.btnAyir.UseVisualStyleBackColor = true;
            this.btnAyir.Click += new System.EventHandler(this.btnAyir_Click);
            // 
            // btnOverload
            // 
            this.btnOverload.Location = new System.Drawing.Point(74, 336);
            this.btnOverload.Name = "btnOverload";
            this.btnOverload.Size = new System.Drawing.Size(119, 54);
            this.btnOverload.TabIndex = 6;
            this.btnOverload.Text = "Overload";
            this.btnOverload.UseVisualStyleBackColor = true;
            this.btnOverload.Click += new System.EventHandler(this.btnOverload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 458);
            this.Controls.Add(this.btnOverload);
            this.Controls.Add(this.btnAyir);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnRecursion);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.btnPower);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnRecursion;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnAyir;
        private System.Windows.Forms.Button btnOverload;
    }
}

