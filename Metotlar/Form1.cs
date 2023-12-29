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

        public void UzayanMesajGoster(string mesaj) //Recursion / Yineleme
        {
            MessageBox.Show(mesaj);
            if (mesaj.Length<10)
            {
                UzayanMesajGoster(mesaj + "1");
            }
        }


        public int Factorial(int sayi)
        {
            //x! = x * (x-1)!
            //3! = 3 * (2)! = 3 * 2 * 1! = 3 * 2* 1

            if (sayi==0)
            {
                return 1;
            }
            return sayi * Factorial(sayi - 1);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int girilenDeger = int.Parse(txtDeger1.Text);

            int faktoriyel = Factorial(girilenDeger);
            MessageBox.Show("Sonuç:  " + faktoriyel);
        }

        private void btnAyir_Click(object sender, EventArgs e)
        {
            string[] kelimeler = txtDeger1.Text.Split(' ');

            char[] karakterler = txtDeger1.Text.ToCharArray();

            string boslukSuzKelime = txtDeger1.Text.Replace(" ", "");

            string buyukHarfler = txtDeger1.Text.ToUpper();
            string kucukHarfler = txtDeger1.Text.ToLower();
            string kirpilmisYazi = txtDeger1.Text.Trim();

            int[] array = new int[5];

            //string yazi = txtDeger1.Text;
            //int sayi = 0;
            //if (int.TryParse(yazi, out int x))
            //{
            //    sayi = x;
            //}

            char[] harfler = "ABCDEFGH".ToCharArray();
            char[] harfler2 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            MessageBox.Show(boslukSuzKelime);


            Bolme(10, 3, out int a, out int b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MesajYaz(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
        public void MesajYaz() //Overloading
        {
            MessageBox.Show("Hiçbir Mesaj Girilmedi!");
        }
        public void MesajYaz(int sayi)
        {

        }
        private void btnOverload_Click(object sender, EventArgs e)
        {
            
        }

        public void Bolme(int bolunen,int bolen, out int bolum, out int kalan)
        {
            bolum = bolunen / bolen;
            kalan = bolunen % bolen;
        }

    }


}
