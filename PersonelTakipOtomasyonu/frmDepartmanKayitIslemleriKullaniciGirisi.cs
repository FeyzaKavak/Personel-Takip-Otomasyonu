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
    public partial class frmDepartmanKayitIslemleriKullaniciGirisi : Form
    {
        public frmDepartmanKayitIslemleriKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            departmanKullanicilari.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);

            if (departmanKullanicilari.durum)
            {
                frmDepartmanEkleDuzenle dpd = new frmDepartmanEkleDuzenle();
                dpd.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı giriş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
