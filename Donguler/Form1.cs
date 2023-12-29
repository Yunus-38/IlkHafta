using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            for (int i = int.Parse(txtDeger.Text); i > 0; i--)
            {
                MessageBox.Show("Sayaç: " + i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 2;
            sayilar[1] = 4;
            sayilar[2] = 6;
            sayilar[3] = 8;
            sayilar[4] = 10;

            foreach (var sayi in sayilar)
            {
                MessageBox.Show("Sayınız:" + sayi);
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                MessageBox.Show("Sayınız:" + sayilar[i]);
            }

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {

            int i = 2;

            

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            //Girilen değerin faktöriyelini while döngüsü kullanarak alınız.

            ulong sayi = ulong.Parse(txtDeger.Text);
            ulong sonuc = 1;
            while (sayi > 0)
            {
                sonuc = sonuc * sayi;
                sonuc *= sayi;
                sayi--;
            }
            MessageBox.Show("Sonuç : " + sonuc);

            //int[] dizi = { 1, 2, 3, 4 };

            //int[,] matris =
            //{
            //    { 1, 2, 3, 4 },
            //    { 5, 6, 7, 8 },
            //    { 9, 10, 11, 12 }
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        MessageBox.Show("eleman: " + matris[i,j]);

            //    }
            //}

            //foreach (int sayi in matris)
            //{
            //    MessageBox.Show("eleman: " + sayi);

            //}

            for (int i = 0; i < 10; i++)
            {

            }

            int a = 10;
            int b = 5;
            while (a>5)
            {
                b++;

                if (b==7)
                {
                    break;
                }
            }

            int[] ints = { 1, 2, 10, 8, 2, 3, };
            foreach (int x in ints)
            {
                if (x==10)
                {
                    continue;
                }
                MessageBox.Show("Sayi: " + x);
            }

            int[] sayilar = new int[3];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = i+1;
            }

        }
    }
}
