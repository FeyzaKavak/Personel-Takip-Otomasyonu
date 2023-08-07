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
    public partial class frmIzinHareketListele : Form
    {
        public frmIzinHareketListele()
        {
            InitializeComponent();
        }
        izin Izin = new izin();
        private void btnIzinTurleri_Click(object sender, EventArgs e)
        {
            frmIzinTurleri frm = new frmIzinTurleri();
            frm.ShowDialog();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIzinHareketListele_Load(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,Tur.izinTuru,izinBaslangic,izinBitis,islem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri Tur where i.izinTurID=Tur.izinTurID");
            Personeller.ComboyaKayitGetir(comboizinTurleri);
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            yapilanZamlar.personelAdSoyadGetir(txtPersonelID, txtAdiSoyadi);
            if (txtPersonelID.Text=="")
            {
                txtAdiSoyadi.Text = "";
            }
        }
        private void Temizle()
        {
            dateTimeizinBaslangic.Value = DateTime.Now;
            dateTimeizinBitis.Value = DateTime.Now;
            Personeller.ComboyaKayitGetir(comboizinTurleri);
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
            izin i = new izin();
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.IzinTurID = (int)comboizinTurleri.SelectedValue;
            i.IzinBaslangic = dateTimeizinBaslangic.Value;
            i.IzinBitis = dateTimeizinBitis.Value;
            i.Islem = i.PERSONELID + "-" + txtAdiSoyadi.Text + " için " + comboizinTurleri.Text + "oluşturuldu";
            i.Aciklama = textAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;

            string sql = "insert into izinHareketleri values('"+i.PERSONELID+ "','" + i.IzinTurID + "',@izinBaslangic,@izinBitis,'" + i.Islem + "','" + i.Aciklama + "',@Tarih,@Saat)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;

            try
            {
                veritabani.ESG(komut,sql);
                Temizle();
                MessageBox.Show("İzin kaydı oluşturuldu", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,Tur.izinTuru,izinBaslangic,izinBitis,islem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri Tur where i.izinTurID=Tur.izinTurID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIzinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboizinTurleri.Text = dataGridView1.CurrentRow.Cells["izinTuru"].Value.ToString();
            dateTimeizinBaslangic.Text= dataGridView1.CurrentRow.Cells["izinBaslangic"].Value.ToString();
            dateTimeizinBitis.Text= dataGridView1.CurrentRow.Cells["izinBitis"].Value.ToString();
            textAciklama.Text= dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(txtIzinHareketID.Text);
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.IzinTurID = (int)comboizinTurleri.SelectedValue;
            i.IzinBaslangic = dateTimeizinBaslangic.Value;
            i.IzinBitis = dateTimeizinBitis.Value;
            i.Aciklama = textAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Islem = i.IzinHareketID+" Numaralı izin bilgileri değiştirildi ";

            string sql = "update izinHareketleri set PersonelID='"+i.PERSONELID+"', izinTurID='"+i.IzinTurID+"',izinBaslangic=@izinBaslangic,izinBitis=@izinBitis,islem='"+i.Islem+"',Aciklama='"+i.Aciklama+"',Tarih=@Tarih,Saat=@Saat where izinHareketID='"+i.IzinHareketID+"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;

            try
            {
                veritabani.ESG(komut, sql);
                Temizle();
                MessageBox.Show("İzin bilgileri güncellendi", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,Tur.izinTuru,izinBaslangic,izinBitis,islem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri Tur where i.izinTurID=Tur.izinTurID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from izinHareketleri where izinHareketID='"+i.IzinHareketID+"'";
            SqlCommand komut = new SqlCommand();

            try
            {
                veritabani.ESG(komut, sql);
                Temizle();
                MessageBox.Show("İzin bilgileri silindi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,Tur.izinTuru,izinBaslangic,izinBitis,islem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri Tur where i.izinTurID=Tur.izinTurID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
