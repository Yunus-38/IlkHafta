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

            ////
            ////
            //string m = "ABC";

            //EkranaMesajYaz(m,0);
            ////MessageBox.Show("MESAJ :  " + m + " | " + 0);
            double x = double.Parse(txtDeger1.Text);
            double sonuc = KaresiniAl(x);
            MessageBox.Show("Bu sayinin karesi:  " + sonuc);
        }


        public void EkranaMesajYaz(string mesaj, int a)
        {
            MessageBox.Show("MESAJ :  " + mesaj + " | "+ a);
        }

        public double KaresiniAl(double sayi)
        {
            double kare = sayi * sayi;

            return kare;
        }
    }
}
