
namespace PersonelTakipOtomasyonu
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepartmanEkleDuzenle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnMaaslar = new System.Windows.Forms.Button();
            this.btnIzinler = new System.Windows.Forms.Button();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnMesai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartmanEkleDuzenle
            // 
            this.btnDepartmanEkleDuzenle.BackColor = System.Drawing.Color.Thistle;
            this.btnDepartmanEkleDuzenle.Location = new System.Drawing.Point(34, 12);
            this.btnDepartmanEkleDuzenle.Name = "btnDepartmanEkleDuzenle";
            this.btnDepartmanEkleDuzenle.Size = new System.Drawing.Size(252, 70);
            this.btnDepartmanEkleDuzenle.TabIndex = 0;
            this.btnDepartmanEkleDuzenle.Text = "Departman Ekle/Düzenle";
            this.btnDepartmanEkleDuzenle.UseVisualStyleBackColor = false;
            this.btnDepartmanEkleDuzenle.Click += new System.EventHandler(this.btnDepartmanEkleDuzenle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.Thistle;
            this.btnPersonelEkle.Location = new System.Drawing.Point(306, 12);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(252, 70);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.Color.Thistle;
            this.btnPersonelListesi.Location = new System.Drawing.Point(34, 88);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Size = new System.Drawing.Size(252, 70);
            this.btnPersonelListesi.TabIndex = 2;
            this.btnPersonelListesi.Text = "Personel Listele/Düzenle";
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnMaaslar
            // 
            this.btnMaaslar.BackColor = System.Drawing.Color.Thistle;
            this.btnMaaslar.Location = new System.Drawing.Point(306, 88);
            this.btnMaaslar.Name = "btnMaaslar";
            this.btnMaaslar.Size = new System.Drawing.Size(252, 70);
            this.btnMaaslar.TabIndex = 3;
            this.btnMaaslar.Text = "Maaş Düzenleme";
            this.btnMaaslar.UseVisualStyleBackColor = false;
            this.btnMaaslar.Click += new System.EventHandler(this.btnMaaslar_Click);
            // 
            // btnIzinler
            // 
            this.btnIzinler.BackColor = System.Drawing.Color.Thistle;
            this.btnIzinler.Location = new System.Drawing.Point(34, 164);
            this.btnIzinler.Name = "btnIzinler";
            this.btnIzinler.Size = new System.Drawing.Size(252, 70);
            this.btnIzinler.TabIndex = 4;
            this.btnIzinler.Text = "İzinler";
            this.btnIzinler.UseVisualStyleBackColor = false;
            this.btnIzinler.Click += new System.EventHandler(this.btnIzinler_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.BackColor = System.Drawing.Color.Thistle;
            this.btnOturumuKapat.Location = new System.Drawing.Point(306, 240);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(252, 70);
            this.btnOturumuKapat.TabIndex = 5;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = false;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.Thistle;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(306, 164);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(252, 70);
            this.btnKullaniciEkle.TabIndex = 6;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMesai
            // 
            this.btnMesai.BackColor = System.Drawing.Color.Thistle;
            this.btnMesai.Location = new System.Drawing.Point(34, 240);
            this.btnMesai.Name = "btnMesai";
            this.btnMesai.Size = new System.Drawing.Size(252, 70);
            this.btnMesai.TabIndex = 7;
            this.btnMesai.Text = "Mesailer";
            this.btnMesai.UseVisualStyleBackColor = false;
            this.btnMesai.Click += new System.EventHandler(this.btnMesai_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(590, 345);
            this.Controls.Add(this.btnMesai);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.btnOturumuKapat);
            this.Controls.Add(this.btnIzinler);
            this.Controls.Add(this.btnMaaslar);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnDepartmanEkleDuzenle);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDepartmanEkleDuzenle;
        public System.Windows.Forms.Button btnPersonelEkle;
        public System.Windows.Forms.Button btnPersonelListesi;
        public System.Windows.Forms.Button btnMaaslar;
        public System.Windows.Forms.Button btnIzinler;
        public System.Windows.Forms.Button btnOturumuKapat;
        public System.Windows.Forms.Button btnKullaniciEkle;
        public System.Windows.Forms.Button btnMesai;
    }
}

