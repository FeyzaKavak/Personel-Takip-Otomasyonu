using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class yapilanZamlar
    {
        private int _ZamID;
        private string _Donem;
        private string _Personel;
        private decimal _Yuzde;
        private decimal _Fiyat;
        private string _Aciklama;
        private DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public decimal Yuzde { get => _Yuzde; set => _Yuzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }

        public static SqlDataReader personelAdSoyadGetir(TextBox txtPersonelID, TextBox txtAdSoyad)
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personeller where PersonelID='" + txtPersonelID.Text + "'", veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr[1] + " " + dr[2];
            }
            veritabani.baglanti.Close();
            return dr;
        }

        public static SqlDataReader ComboyaPersonelGetir(ComboBox cmb)
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr[0] + "." + dr[1] + " " + dr[2]);
            }
            veritabani.baglanti.Close();
            return dr;
        }

        public static SqlDataReader ComboSecilirsePersonelIDGetir(ComboBox combo, Label lbl_PersonelID)
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (combo.SelectedItem.ToString()== dr[0] + "." + dr[1] + " " + dr[2])
                {
                    lbl_PersonelID.Text = dr[0].ToString();
                }
            }
            veritabani.baglanti.Close();
            return dr;
        }
    }
}
