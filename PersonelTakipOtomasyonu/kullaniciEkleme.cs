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
    class kullaniciEkleme
    {
        private int _kullaniciID;
        private string _adi;
        private string _soyadi;
        private string _kullaniciAdi;
        private string _sifre;
        private int _yetkiID;

        public int KullaniciID { get => _kullaniciID; set => _kullaniciID = value; }
        public string Adi { get => _adi; set => _adi = value; }
        public string Soyadi { get => _soyadi; set => _soyadi = value; }
        public string KullaniciAdi { get => _kullaniciAdi; set => _kullaniciAdi = value; }
        public string Sifre { get => _sifre; set => _sifre = value; }
        public int YetkiID { get => _yetkiID; set => _yetkiID = value; }

        public static DataTable comboyaGorevGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Yetki", veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "yetkiID";
            combo.DisplayMember = "yetkisi";
            veritabani.baglanti.Close();
            return tbl;
        }
    } 
}


