using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnDepartmanEkleDuzenle_Click(object sender, EventArgs e)
        {
           
            if (kullanicilar.YetkiID==1 || kullanicilar.YetkiID==4){
                frmDepartmanEkleDuzenle dEkle = new frmDepartmanEkleDuzenle();
                dEkle.ShowDialog();
                
            }

           else
            {
               btnDepartmanEkleDuzenle.Enabled = false;
               MessageBox.Show("1Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if(kullanicilar.YetkiID==1 || kullanicilar.YetkiID==3){
                frmPersonelEkle pEkle = new frmPersonelEkle();
                pEkle.ShowDialog();
            }
            else
            {
                btnPersonelEkle.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            if (kullanicilar.YetkiID==1 || kullanicilar.YetkiID==3)
            {
                frmPersonelListesi pListe = new frmPersonelListesi();
                pListe.ShowDialog();
            }
            else
            {
                btnPersonelListesi.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaaslar_Click(object sender, EventArgs e)
        {
            if (kullanicilar.YetkiID==1 || kullanicilar.YetkiID==2) {
                frmMaaslar pMaaslar = new frmMaaslar();
                pMaaslar.ShowDialog();
            }
            else
            {
                btnMaaslar.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIzinler_Click(object sender, EventArgs e)
        {
            if (kullanicilar.YetkiID==1 || kullanicilar.YetkiID==3) {
                frmIzinHareketListele frm = new frmIzinHareketListele();
                frm.ShowDialog();
            }
            else
            {
                btnIzinler.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            DialogResult oturum = new DialogResult();
            oturum = MessageBox.Show(" Oturumu kapatmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oturum == DialogResult.Yes)
            {
                Application.Restart();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanicilar.YetkiID==1)
            {
                kullaniciEklemeSayfasi sf = new kullaniciEklemeSayfasi();
                sf.ShowDialog();
            }
            else
            {
                btnKullaniciEkle.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnMesai_Click(object sender, EventArgs e)
        {
            if (kullanicilar.YetkiID == 1 || kullanicilar.YetkiID == 3)
            {
                frmMesaiEkle mesai = new frmMesaiEkle();
                mesai.ShowDialog();
            }
            else
            {
                btnMesai.Enabled = false;
                MessageBox.Show("Bu sayfaya erişmek için yetkiniz yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
