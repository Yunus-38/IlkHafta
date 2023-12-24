using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            //EkranaMesajYaz("Merhaba!", 5);
            ////MessageBox.Show("MESAJ :  " + "Merhaba!" + " | " + 5);


            //string m = "ABC";

            //EkranaMesajYaz(m, 0);
            ////MessageBox.Show("MESAJ :  " + m + " | " + 0);
            //double x = double.Parse(txtDeger1.Text);
            //double sonuc = KaresiniAl(x);
            //MessageBox.Show("Bu sayinin karesi:  " + KaresiniAl(x));

            double sayi = double.Parse(txtDeger1.Text);
            int kuvvet = int.Parse(txtDeger2.Text);

            //double sonuc = KuvvetAl(sayi, kuvvet);

            //double kareninKaresi = KaresiniAl(KaresiniAl(sayi));
            //MessageBox.Show("Karenin Karesi:  " + kareninKaresi);

            //double kuvvetinKuvveti = KuvvetAl(KuvvetAl(sayi, kuvvet), kuvvet);
            //MessageBox.Show("Kuvvetin Kuvveti:  " + kuvvetinKuvveti);

            //Recursion

        }


        public void EkranaMesajYaz(string mesaj, int a)
        {
            MessageBox.Show("MESAJ :  " + mesaj + " | " + a);
        }

        private double KaresiniAl(double sayi)
        {
            double kare = sayi * sayi;

            return kare;
        }

        private double KuvvetAl(double taban, int us)
        {
            double sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc = taban * sonuc;
            }
            return sonuc;
        }

        private void btnRecursion_Click(object sender, EventArgs e)
        {
            string mesaj = txtDeger1.Text;

            UzayanMesajGoster(mesaj);


            MessageBox.Show("Tamam");
        }

        public void UzayanMesajGoster(string mesaj)
        {
            MessageBox.Show(mesaj);
            if (mesaj.Length<10)
            {
                UzayanMesajGoster(mesaj + "1");
            }
        }

        
    }


}
