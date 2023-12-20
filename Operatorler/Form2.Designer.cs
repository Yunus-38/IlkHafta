namespace Operatorler
{
    partial class Form2
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(75, 23);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(100, 20);
            this.txtDeger1.TabIndex = 0;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(75, 61);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(100, 20);
            this.txtDeger2.TabIndex = 1;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(90, 87);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek1.TabIndex = 2;
            this.btnOrnek1.Text = "button1";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 362);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnOrnek1;
    }
}