namespace Donguler
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
            this.btnLoop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(219, 20);
            this.txtDeger.TabIndex = 0;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(59, 38);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(120, 55);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "Döngü";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 121);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(123, 99);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(56, 121);
            this.btnWhile.TabIndex = 3;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(59, 226);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(120, 51);
            this.btnFactorial.TabIndex = 4;
            this.btnFactorial.Text = "Faktöriyel";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 356);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFactorial;
    }
}

