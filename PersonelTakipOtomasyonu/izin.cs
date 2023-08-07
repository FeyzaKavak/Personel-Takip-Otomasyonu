using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class izin:Personeller
    {
        public izin()
        {
            izin.sql = "select * from izinTurleri";
            izin.value = "izinTurID";
            izin.text = "izinTuru";
        }
        private int _izinHareketID;
        private int _PersonelID;
        private int _izinTurID;
        private string _izinTuru;
        private DateTime _izinBaslangic;
        private DateTime _izinBitis;
        private DateTime _Saat;
        private string _islem;
        private DateTime _Tarih;
        private string _Aciklama;
        
        public int IzinHareketID { get => _izinHareketID; set => _izinHareketID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public int IzinTurID { get => _izinTurID; set => _izinTurID = value; }
        public string IzinTuru { get => _izinTuru; set => _izinTuru = value; }
        public DateTime IzinBaslangic { get => _izinBaslangic; set => _izinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Saat { get => _Saat; set => _Saat = value; }
        public string Islem { get => _islem; set => _islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Aciklama1 { get => _Aciklama; set => _Aciklama = value; }

        public static SqlDataReader ListViewKayitGetir(ListView lst)
        {
            lst.Items.Clear();
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from izinTurleri",veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                lst.Items.Add(ekle);
            }
            veritabani.baglanti.Close();
            return dr;
        }
    }
}
