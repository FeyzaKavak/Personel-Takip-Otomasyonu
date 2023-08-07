using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmYoneticiIslemleriKullaniciGirisi : Form
    {
        public frmYoneticiIslemleriKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullanicilar.kullaniciGirisi(txtKullaniciAdi,txtSifre);
            if (kullanicilar.durum==true)
            {
                Anasayfa ans = new Anasayfa();
                ans.ShowDialog();
                this.Hide();
            }
            else if (kullanicilar.durum==false)
            {
                MessageBox.Show("Hatalı giriş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboYetkiID_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void frmYoneticiIslemleriKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
