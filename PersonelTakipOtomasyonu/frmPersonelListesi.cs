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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboBoxDepartman);
            YenileListele();
        }

        private void YenileListele()
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi,p.Soyadi,p.Telefon_No,p.E_Posta,p.Egitim_Durumu,p.Okul,p.Not_Ortalamasi,p.Askerlik_Durumu,p.Dil,p.ise_baslama_Tarihi,p.Yakin_Adi,p.Yakin_Soyadi,p.Yakinin_Telefon_No,p.Yakinlik_Derecesi,p.Yakinin_Adresi,p.Adres_Baslik,p.il,p.ilce,p.Mahalle,p.Adres,p.Hesap_No,p.DepartmanID,p.Maas,p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID");
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefonNo.Text == "" || txtEPosta.Text == "" || txtHesapNo.Text == "" || txtMaas.Text == "" || txtAciklama.Text=="")
            {
                MessageBox.Show("* ile belirtilen yerleri boş bırakamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Personeller p = new Personeller();
                p.PERSONELID = int.Parse(txtPersonelID.Text);
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
                string sorgu = "update Personeller set Adi='" + p.Adi + "',Soyadi='" + p.Soyadi + "',Telefon_No='" + p.TelefonNo + "',E_Posta='" + p.EPosta + "',Egitim_Durumu='" + p.EgitimDurumu + "',Okul='" + p.Okul + "',Not_Ortalamasi='" + p.NotOrtalaması + "',Askerlik_Durumu='" + p.AskerlikDurumu + "',Dil='" + p.Dil + "',ise_baslama_Tarihi=@ise_baslama_Tarihi,Yakin_Adi='" + p.YakinAdi + "',Yakin_Soyadi='" + p.YakinSoyadi + "',Yakinin_Telefon_No='" + p.YakinSoyadi + "',Yakinlik_Derecesi='" + p.YakinlikDeerecesi + "',Yakinin_Adresi='" + p.YakininAdresi + "',Adres_Baslik='" + p.AdresBaslik + "',il='" + p.Il + "',ilce='" + p.Ilce + "',Mahalle='" + p.Mahalle + "',Adres='" + p.Adres + "',Hesap_No='" + p.HesapNo + "',DepartmanID='" + p.DepartmanID + "',Maas=@Maas,Aciklama='" + p.Aciklama + "' where PersonelID ='" + p.PERSONELID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("Maas", SqlDbType.Decimal).Value = p.Maas;
                komut.Parameters.Add("ise_baslama_Tarihi", SqlDbType.Date).Value = p.IseBaslamaTarihi;
                veritabani.ESG(komut, sorgu);
                Temizle();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YenileListele();
            }
        }


        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PERSONELID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sorgu = "delete from Personeller where PersonelID ='"+p.PERSONELID+"'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sorgu);
            Temizle();
            MessageBox.Show("Silme işlemi gerçekleştirildi", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefonNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEPosta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEgitimDurumu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOkul.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNotOrtalamasi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAskerlikDurumu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDil.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dateIseBaslamaTarihi.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            txtYakinAdi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtYakkinSoyadi.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtYakininTelefonNo.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtYakinlikDerecesi.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtYakininAdresi.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtAdresBaslik.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtIl.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtIlce.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtMahalle.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            txtHesapNo.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            comboBoxDepartman.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
        }

        private void txtPersonelIdAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi,p.Soyadi,p.Telefon_No,p.E_Posta,p.Egitim_Durumu,p.Okul,p.Not_Ortalamasi,p.Askerlik_Durumu,p.Dil,p.ise_baslama_Tarihi,p.Yakin_Adi,p.Yakin_Soyadi,p.Yakinin_Telefon_No,p.Yakinlik_Derecesi,p.Yakinin_Adresi,p.Adres_Baslik,p.il,p.ilce,p.Mahalle,p.Adres,p.Hesap_No,p.DepartmanID,p.Maas,p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and PersonelID like '%"+txtPersonelIdAra.Text+"%'");
        }

        private void txtPersonelAdiAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi,p.Soyadi,p.Telefon_No,p.E_Posta,p.Egitim_Durumu,p.Okul,p.Not_Ortalamasi,p.Askerlik_Durumu,p.Dil,p.ise_baslama_Tarihi,p.Yakin_Adi,p.Yakin_Soyadi,p.Yakinin_Telefon_No,p.Yakinlik_Derecesi,p.Yakinin_Adresi,p.Adres_Baslik,p.il,p.ilce,p.Mahalle,p.Adres,p.Hesap_No,p.DepartmanID,p.Maas,p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Adi like '%" + txtPersonelAdiAra.Text + "%'");
        }

        private void txtPersonelSoyadiAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi,p.Soyadi,p.Telefon_No,p.E_Posta,p.Egitim_Durumu,p.Okul,p.Not_Ortalamasi,p.Askerlik_Durumu,p.Dil,p.ise_baslama_Tarihi,p.Yakin_Adi,p.Yakin_Soyadi,p.Yakinin_Telefon_No,p.Yakinlik_Derecesi,p.Yakinin_Adresi,p.Adres_Baslik,p.il,p.ilce,p.Mahalle,p.Adres,p.Hesap_No,p.DepartmanID,p.Maas,p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Soyadi like '%" +txtPersonelSoyadiAra.Text+ "%'");
        }

        private void txtPersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi,p.Soyadi,p.Telefon_No,p.E_Posta,p.Egitim_Durumu,p.Okul,p.Not_Ortalamasi,p.Askerlik_Durumu,p.Dil,p.ise_baslama_Tarihi,p.Yakin_Adi,p.Yakin_Soyadi,p.Yakinin_Telefon_No,p.Yakinlik_Derecesi,p.Yakinin_Adresi,p.Adres_Baslik,p.il,p.ilce,p.Mahalle,p.Adres,p.Hesap_No,p.DepartmanID,p.Maas,p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Telefon_No like '%" + txtPersonelTelefonAra.Text + "%'");
        }

    }
}
