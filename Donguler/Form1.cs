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
    }
}
