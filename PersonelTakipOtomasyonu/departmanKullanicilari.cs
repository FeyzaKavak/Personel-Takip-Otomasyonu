using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    class departmanKullanicilari
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }

        public static bool durum = false;
        public static SqlDataReader KullaniciGirisi(string KullaniciAdi, string Sifre)
        {
            yöneticiKullanicilari k = new yöneticiKullanicilari();
            k.KullaniciAdi = KullaniciAdi;
            k.Sifre = Sifre;
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from DepartmanKullanicilari where KullaniciAdi='" + k.KullaniciAdi + "' and sifre='" + k.Sifre + "'", veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                k.KullaniciID = int.Parse(dr[0].ToString());

            }
            else
            {
                durum = false;
            }
            dr.Close();
            veritabani.baglanti.Close();
            return dr;

        }
    }
}
