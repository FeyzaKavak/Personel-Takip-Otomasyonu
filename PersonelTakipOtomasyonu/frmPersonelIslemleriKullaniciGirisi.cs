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
    public partial class frmPersonelIslemleriKullaniciGirisi : Form
    {
        public frmPersonelIslemleriKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            personelKullanicilari.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);

            if (personelKullanicilari.durum)
            {
                frmPersonelIslemSecimSayfası islemSayfasi = new frmPersonelIslemSecimSayfası();
                islemSayfasi.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı giriş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
