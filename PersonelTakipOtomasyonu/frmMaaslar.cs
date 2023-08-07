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
    public partial class frmMaaslar : Form
    {
        public frmMaaslar()
        {
            InitializeComponent();
            comboPersoneller.SelectedIndex = 0;
            radioBtnFiyataGore.Checked = true;

        }

        private void frmMaaslar_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil-5); i--)
            {
                comboYil.Items.Add(i);
            }
            yapilanZamlar.ComboyaPersonelGetir(comboPersoneller);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnFiyataGore_CheckedChanged(object sender, EventArgs e)
        {
            txtYuzde.Enabled = false;
            txtFiyat.Enabled = true;
        }

        private void radioBtnYuzdeyeGore_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = false;
            txtYuzde.Enabled = true;

        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersoneller.SelectedIndex==0)
            {
                lblPersonelID.Text = "0";
                return;
            }
            yapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersoneller, lblPersonelID);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            yapilanZamlar y = new yapilanZamlar();
            y.Personel = comboPersoneller.Text;
            y.Donem = comboAy.Text + "/" + comboYil.Text;
            y.Aciklama = txtAciklama.Text;
            y.Tarih = DateTime.Now;
            if (radioBtnYuzdeyeGore.Checked)
            {
                y.Yuzde = decimal.Parse(txtYuzde.Text);
                //decimal yuzde = decimal.Parse(txtYuzde.Text);
                if (comboPersoneller.SelectedIndex==0)
                {
                    string sql = "update Personeller set Maas = Maas+(Maas*'" +y.Yuzde + "') /100 ";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm personellerin maaşına yüzde "+y.Yuzde+" zam yapıldı","Maaş",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maas = Maas+(Maas*'" + y.Yuzde + "') /100 where PersonelID='"+lblPersonelID.Text+"'";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show(""+comboPersoneller.Text+"personelin maaşına yüzde " + y.Yuzde + " zam yapıldı", "Maaş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(PersonelID,Donem,Personeller,Yuzde,Aciklama,Tarih) values('"+p.PERSONELID+ "','" + y.Donem + "','" + y.Personel+ "',@Yuzde,'" + y.Aciklama + "',@Tarih) ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = y.Yuzde;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                veritabani.ESG(komut2, sql2);
            }
            if (radioBtnFiyataGore.Checked)
            {
                y.Fiyat = decimal.Parse(txtFiyat.Text);
                //decimal fiyat = decimal.Parse(txtFiyat.Text);
                if (comboPersoneller.SelectedIndex == 0)
                {
                    string sql = "update Personeller set Maas = Maas+'" + y.Fiyat + "' ";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm personellerin maaşına " +y.Fiyat + " TL zam yapıldı", "Maaş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maas = Maas+" + y.Fiyat + " where PersonelID=" + lblPersonelID.Text + "";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show(""+comboPersoneller.Text+" personelin maaşına " + y.Fiyat + " TL zam yapıldı", "Maaş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(PersonelID,Donem,Personeller,Fiyat,Aciklama,Tarih) values('" + p.PERSONELID + "','" + y.Donem + "','" + y.Personel + "',@Fiyat,'" + y.Aciklama + "',@Tarih) ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = y.Fiyat;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                veritabani.ESG(komut2, sql2);
            }
        }
    }
}
