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
    public partial class frmKullaniciSec : Form
    {
        public frmKullaniciSec()
        {
            InitializeComponent();
        }

        private void btnYoneticiIslemleri_Click(object sender, EventArgs e)
        {
            frmYoneticiIslemleriKullaniciGirisi Ygiris = new frmYoneticiIslemleriKullaniciGirisi();
            Ygiris.ShowDialog();
        }

        private void btnDepartmanKayitİslemleri_Click(object sender, EventArgs e)
        {
            frmDepartmanKayitIslemleriKullaniciGirisi Dgiris = new frmDepartmanKayitIslemleriKullaniciGirisi();
            Dgiris.ShowDialog();

        }

        private void btnMaliIslemler_Click(object sender, EventArgs e)
        {
            frmMaliIslemleriKullaniciGirisi Mgiris = new frmMaliIslemleriKullaniciGirisi();
            Mgiris.ShowDialog();
        }

        private void btnPersonelKayitIslemleri_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleriKullaniciGirisi Pgiris = new frmPersonelIslemleriKullaniciGirisi();
            Pgiris.ShowDialog();
        }
    }
}
