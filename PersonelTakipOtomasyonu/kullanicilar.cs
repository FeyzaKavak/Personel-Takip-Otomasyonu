using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class kullanicilar
    {
        public static int YetkiID = 0;
        public static bool durum = true;
        public static SqlDataReader kullaniciGirisi(TextBox kullaniciAdi, TextBox sifre )
        {
            veritabani.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanicilar where kullaniciAdi='" + kullaniciAdi.Text + "' and sifre='" + sifre.Text + "'",veritabani.baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                YetkiID =int.Parse(dr["yetkiID"].ToString());
            }
            else
            {
                durum = false;
            }
            veritabani.baglanti.Close();
            return dr;
        }
    }
}
