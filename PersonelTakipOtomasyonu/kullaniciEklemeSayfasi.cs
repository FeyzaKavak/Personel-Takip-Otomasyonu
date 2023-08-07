using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class kullaniciEklemeSayfasi : Form
    {
        public kullaniciEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void kullaniciEklemeSayfasi_Load(object sender, EventArgs e)
        {
            kullaniciEkleme.comboyaGorevGetir(comboGorev);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            comboGorev.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                kullaniciEkleme k = new kullaniciEkleme();
                k.Adi = txtAdi.Text;
                k.Soyadi = txtSoyadi.Text;
                k.KullaniciAdi = txtKullaniciAdi.Text;
                k.Sifre = txtSifre.Text;
                k.YetkiID = (int)comboGorev.SelectedValue;
                string sorgu = "insert into kullanicilar(adi,soyadi,kullaniciAdi,sifre,yetkiID) values('" + k.Adi + "','" + k.Soyadi + "','" + k.KullaniciAdi + "','" + k.Sifre + "','" + k.YetkiID + "')";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sorgu);
                Temizle();
                MessageBox.Show("İşlem başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void comboGorev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
