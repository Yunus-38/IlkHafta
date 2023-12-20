using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin" )
            {
                MessageBox.Show("Giriş Başarılı!");
            }
            else
            {
                MessageBox.Show("G,iriş Başarıız!");
            }
        }

        private void btnSayiKontrol_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(txtDeger.Text);

            if (sayi == 0)
            {
                MessageBox.Show("Sayı sıfırdır");
            }
            else if (sayi > 0)
            {
                MessageBox.Show("Sayı pozitiftir");
            }
            else
            {
                MessageBox.Show("Sayı negatiftir");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string kontrol = txtDeger.Text;

            switch (kontrol)
            {
                case "A":
                    MessageBox.Show("A harfini Girdiniz");
                    break;
                case "B":
                    MessageBox.Show("B harfini Girdiniz");
                    break;
                default:
                    MessageBox.Show("Başka bir harf girdiniz");
                    break;
            }
        }

        private void btnHarfNotu_Click(object sender, EventArgs e)
        {
            int ortalama = int.Parse(txtDeger.Text);
            int bolum = ortalama / 10;
            char harfNotu;
            switch (bolum)
            {
                case 10:
                    harfNotu = 'A';
                    break;
                case 9:
                    harfNotu = 'A';
                    break;
                case 8:
                    harfNotu = 'B';
                    break;
                case 7:
                    harfNotu = 'C';
                    break;
                case 6:
                    harfNotu = 'D';
                    break;
                case 5:
                    harfNotu = 'E';
                    break;
                default:
                    harfNotu = 'F';
                    break;
            }

            MessageBox.Show("Harf Notunuz: " + harfNotu);
        }
    }
}
