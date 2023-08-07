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
    public partial class frmMaliIslemleriKullaniciGirisi : Form
    {
        public frmMaliIslemleriKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            maliKullanicilari.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);

            if (maliKullanicilari.durum)
            {
                frmMaaslar maas = new frmMaaslar();
                maas.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı giriş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
