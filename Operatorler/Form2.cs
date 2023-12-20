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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Dışarıdan ggelen 2 sayının toplamı ile farkının birbirine bölümünden kalanı bbulun
            int sayi1 = int.Parse(txtDeger1.Text);
            int sayi2 = int.Parse(txtDeger2.Text);
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int sonuc = toplam % fark;

            MessageBox.Show("işlem sonucu:  " + sonuc);

        }
    }
}
