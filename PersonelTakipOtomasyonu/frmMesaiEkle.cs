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
    public partial class frmMesaiEkle : Form
    {
        
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LRNSS00;Initial Catalog=Personel_Takip;Integrated Security=True;Pooling=False");

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil-5; i--)
            {
                comboDonemYil.Items.Add(i);
            }
            yapilanZamlar.ComboyaPersonelGetir(comboPersonelAdiSoyadi);


            }

        /*DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Personeller",baglanti);
            DataTable tablo = new DataTable();
            baglanti.Close();
            return tablo;
        }*/

        Label lbl;

        private void comboPersonelAdiSoyadi_SelectedIndexChanged(object sender, EventArgs e)
        {
           lbl = new Label();
           yapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersonelAdiSoyadi,lbl);
           //MessageBox.Show(lbl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            dateTimeBaslangicSaati.Value = DateTime.Now;
            dateTimeBitisSaati.Value = DateTime.Now;
            comboPersonelAdiSoyadi.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (comboPersonelAdiSoyadi.SelectedIndex ==-1 || txtMesaiSaatUcreti.Text == "")
            {
                MessageBox.Show("Lütfen boş yerleri doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            else
            {
                Personeller p = new Personeller();
                mesai m = new mesai();
                p.PERSONELID = int.Parse(lbl.Text);
                m.BaslangicSaati = dateTimeBaslangicSaati.Text + " " + txtBaslangicSaati.Text;
                m.BitisSaati = dateTimeBitisSaati.Text + " " + txtBitisSaati.Text;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboDonemAy.Text + "/" + comboDonemYil.Text;
                m.Aciklama = txtAciklama.Text;
                m.Tarih = DateTime.Now;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                string sql = "insert into Mesailer( PersonelID, BaslangicSaati, BitisSaati, MesaiSaatUcreti, Tutar, Donem, Aciklama, Tarih) values ('" + p.PERSONELID + "','" + m.BaslangicSaati + "','" + m.BitisSaati + "',@MesaiSaatUcreti, @Tutar,'" + m.Donem + "','" + m.Aciklama + "', @Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("Tutar", SqlDbType.Decimal).Value = m.Tutar;
                komut.Parameters.Add("Tarih", SqlDbType.Date).Value = m.Tarih;
                veritabani.ESG(komut, sql);
                Temizle();
                MessageBox.Show("Mesai bilgileri eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        
        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangicSaati.Text + " " + txtBaslangicSaati.Text;
                string bitis = dateTimeBitisSaati.Text + " " + txtBitisSaati.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
                double saatCinsi = saatFarki.TotalHours;

                if (saatCinsi > 10)
                {
                    MessageBox.Show("Fazla mesai girdisi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnOnayla.Enabled = false;
                }
                else
                {
                    btnOnayla.Enabled = true;
                }


            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMesaiListele frm = new frmMesaiListele();
            frm.ShowDialog();

        }

        private void dateTimeBaslangicSaati_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBitisSaati_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
