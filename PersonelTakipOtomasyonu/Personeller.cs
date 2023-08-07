using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _TelefonNo;
        private string _ePosta;
        private string _egitimDurumu;
        private string _Okul;
        private string _NotOrtalaması;
        private string _AskerlikDurumu;
        private string _Dil;
        private DateTime _iseBaslamaTarihi;
        private string _YakinAdi;
        private string _YakinSoyadi;
        private string _YakininTelefonNo;
        private string _YakinlikDeerecesi;
        private string _YakininAdresi;
        private string _AdresBaslik;
        private string _il;
        private string _ilce;
        private string _Mahalle;
        private string _Adres;
        private string _HesapNo;
        private int _DepartmanID;
        private decimal _Maas;
        private string _Aciklama;

        public int PERSONELID{ get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string TelefonNo { get => _TelefonNo; set => _TelefonNo = value; }
        public string EPosta { get => _ePosta; set => _ePosta = value; }
        public string EgitimDurumu { get => _egitimDurumu; set => _egitimDurumu = value; }
        public string Okul { get => _Okul; set => _Okul = value; }
        public string NotOrtalaması { get => _NotOrtalaması; set => _NotOrtalaması = value; }
        public string AskerlikDurumu { get => _AskerlikDurumu; set => _AskerlikDurumu = value; }
        public string Dil { get => _Dil; set => _Dil = value; }
        public DateTime IseBaslamaTarihi { get => _iseBaslamaTarihi; set => _iseBaslamaTarihi = value; }
        public string YakinAdi { get => _YakinAdi; set => _YakinAdi = value; }
        public string YakinSoyadi { get => _YakinSoyadi; set => _YakinSoyadi = value; }
        public string YakininTelefonNo { get => _YakininTelefonNo; set => _YakininTelefonNo = value; }
        public string YakinlikDeerecesi { get => _YakinlikDeerecesi; set => _YakinlikDeerecesi = value; }
        public string YakininAdresi { get => _YakininAdresi; set => _YakininAdresi = value; }
        public string AdresBaslik { get => _AdresBaslik; set => _AdresBaslik = value; }
        public string Il { get => _il; set => _il = value; }
        public string Ilce { get => _ilce; set => _ilce = value; }
        public string Mahalle { get => _Mahalle; set => _Mahalle = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string HesapNo { get => _HesapNo; set => _HesapNo = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maas { get => _Maas; set => _Maas = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Departmanlar ",veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";
            combo.DisplayMember = "Departman";
            veritabani.baglanti.Close();
            return tbl;
        }
        public static string sql = "select * from Departmanlar";
        public static string value = "DepartmanID";
        public static string text = "Departman";

        public static DataTable ComboyaKayitGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = value;
            combo.DisplayMember = text;
            veritabani.baglanti.Close();
            return tbl;
        }
    }
}
