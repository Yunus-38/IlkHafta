using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbxYayinYili.SelectedIndex < 0)
            {
                MessageBox.Show("Bir yayın yılı seçiniz");
                return;
            }
            string kitapIsmi = txtKitapIsmi.Text;
            int seciliIndis = cbxYayinYili.SelectedIndex;
            string yayinYili = (string)cbxYayinYili.Items[seciliIndis];
            
            string kitap = kitapIsmi + " | " + yayinYili;
            lstKitaplar.Items.Add(kitap);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kitapNumarasi = lstKitaplar.SelectedIndex;

            lstKitaplar.Items.RemoveAt(kitapNumarasi);
        }

        private void btnRastgeleKitap_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int indis = random.Next(0,lstKitaplar.Items.Count);

            string seciliKitap = (string)lstKitaplar.Items[indis];
            MessageBox.Show(seciliKitap);

        }
    }
}
