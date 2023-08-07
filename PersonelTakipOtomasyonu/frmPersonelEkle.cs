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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboBoxDepartman);
        }

        private void btnPersonelCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        void Temizle()
        {
            dateIseBaslamaTarihi.Value = DateTime.Now;
            comboBoxDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefonNo.Text == "" || txtEPosta.Text == "" || txtHesapNo.Text == "" || txtMaas.Text == "" || txtAciklama.Text=="")
            {
                MessageBox.Show("* ile belirtilen yerleri doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else { 
                Personeller p = new Personeller();
                p.Adi = txtAd.Text;
                p.Soyadi = txtSoyad.Text;
                p.TelefonNo = txtTelefonNo.Text;
                p.EPosta = txtEPosta.Text;
                p.EgitimDurumu = txtEgitimDurumu.Text;
                p.Okul = txtOkul.Text;
                p.NotOrtalaması = txtNotOrtalamasi.Text;
                p.AskerlikDurumu = txtAskerlikDurumu.Text;
                p.Dil = txtDil.Text;
                p.IseBaslamaTarihi = dateIseBaslamaTarihi.Value;
                p.YakinAdi = txtYakinAdi.Text;
                p.YakinSoyadi = txtYakkinSoyadi.Text;
                p.YakininTelefonNo = txtYakininTelefonNo.Text;
                p.YakinlikDeerecesi = txtYakinlikDerecesi.Text;
                p.YakininAdresi = txtYakininAdresi.Text;
                p.AdresBaslik = txtAdresBaslik.Text;
                p.Il = txtIl.Text;
                p.Ilce = txtIlce.Text;
                p.Mahalle = txtMahalle.Text;
                p.Adres = txtAdres.Text;
                p.HesapNo = txtHesapNo.Text;
                p.DepartmanID = (int)comboBoxDepartman.SelectedValue;
                p.Maas = decimal.Parse(txtMaas.Text);
                p.Aciklama = txtAciklama.Text;
                string sorgu = "insert into Personeller(Adi,Soyadi,Telefon_No,E_Posta,Egitim_Durumu,Okul,Not_Ortalamasi,Askerlik_Durumu,Dil,ise_baslama_Tarihi,Yakin_Adi,Yakin_Soyadi,Yakinin_Telefon_No,Yakinlik_Derecesi,Yakinin_Adresi,Adres_Baslik,il,ilce,Mahalle,Adres,Hesap_No,DepartmanID,Maas,Aciklama) values('" + p.Adi + "','" + p.Soyadi + "','" + p.TelefonNo + "','" + p.EPosta + "','" + p.EgitimDurumu + "','" + p.Okul + "','" + p.NotOrtalaması + "','" + p.AskerlikDurumu + "','" + p.Dil + "',@ise_baslama_Tarihi,'" + p.YakinAdi + "','" + p.YakinSoyadi + "','" + p.YakininTelefonNo + "','" + p.YakinlikDeerecesi + "','" + p.YakininAdresi + "','" + p.AdresBaslik + "','" + p.Il + "','" + p.Ilce + "','" + p.Mahalle + "','" + p.Adres + "','" + p.HesapNo + "','" + p.DepartmanID + "',@Maas,'" + p.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Maas", SqlDbType.Decimal).Value = p.Maas;
                komut.Parameters.Add("@ise_baslama_Tarihi", SqlDbType.Date).Value = p.IseBaslamaTarihi;
                veritabani.ESG(komut, sorgu);
                Temizle();
                MessageBox.Show("Ekleme işlemi gerçekleştirildi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
            
        
              