using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmPersonelIslemSecimSayfası : Form
    {
        public frmPersonelIslemSecimSayfası()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle personelEkle = new frmPersonelEkle();
            personelEkle.ShowDialog();
        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            frmPersonelListesi personelListe = new frmPersonelListesi();
            personelListe.ShowDialog();
        }

        private void btnIzinler_Click(object sender, EventArgs e)
        {
            frmIzinHareketListele izin = new frmIzinHareketListele();
            izin.ShowDialog();
        }
    }
}
