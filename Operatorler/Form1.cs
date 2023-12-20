using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int gelenDeger1 = int.Parse(txtDeger1.Text);
            int gelenDeger2 = int.Parse(txtDeger2.Text);

            int sonuc = gelenDeger1 + gelenDeger2;
            MessageBox.Show("Sonuç = " + sonuc);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int gelenDeger1 = int.Parse(txtDeger1.Text);
            int gelenDeger2 = int.Parse(txtDeger2.Text);

            int sonuc = gelenDeger1 - gelenDeger2;
            MessageBox.Show("Sonuç = " + sonuc);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int gelenDeger1 = int.Parse(txtDeger1.Text);
            int gelenDeger2 = int.Parse(txtDeger2.Text);

            int sonuc = gelenDeger1 % gelenDeger2;
            MessageBox.Show("Sonuç = " + sonuc);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int gelenDeger1 = int.Parse(txtDeger1.Text);
            int gelenDeger2 = int.Parse(txtDeger2.Text);

            int sonuc = gelenDeger1 * gelenDeger2;
            MessageBox.Show("Sonuç = " + sonuc);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double gelenDeger1 = double.Parse(txtDeger1.Text);
            int gelenDeger2 = int.Parse(txtDeger2.Text);

            double sonuc = gelenDeger1 / gelenDeger2;
            MessageBox.Show("Sonuç = " + sonuc);
        }
    }
}
