
namespace PersonelTakipOtomasyonu
{
    partial class frmKullaniciSec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonelKayitIslemleri = new System.Windows.Forms.Button();
            this.btnMaliIslemler = new System.Windows.Forms.Button();
            this.btnYoneticiIslemleri = new System.Windows.Forms.Button();
            this.btnDepartmanKayitİslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelKayitIslemleri
            // 
            this.btnPersonelKayitIslemleri.BackColor = System.Drawing.Color.Thistle;
            this.btnPersonelKayitIslemleri.Location = new System.Drawing.Point(88, 185);
            this.btnPersonelKayitIslemleri.Name = "btnPersonelKayitIslemleri";
            this.btnPersonelKayitIslemleri.Size = new System.Drawing.Size(252, 70);
            this.btnPersonelKayitIslemleri.TabIndex = 1;
            this.btnPersonelKayitIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelKayitIslemleri.UseVisualStyleBackColor = false;
            this.btnPersonelKayitIslemleri.Click += new System.EventHandler(this.btnPersonelKayitIslemleri_Click);
            // 
            // btnMaliIslemler
            // 
            this.btnMaliIslemler.BackColor = System.Drawing.Color.Thistle;
            this.btnMaliIslemler.Location = new System.Drawing.Point(88, 98);
            this.btnMaliIslemler.Name = "btnMaliIslemler";
            this.btnMaliIslemler.Size = new System.Drawing.Size(252, 70);
            this.btnMaliIslemler.TabIndex = 2;
            this.btnMaliIslemler.Text = "Mali İşlemler";
            this.btnMaliIslemler.UseVisualStyleBackColor = false;
            this.btnMaliIslemler.Click += new System.EventHandler(this.btnMaliIslemler_Click);
            // 
            // btnYoneticiIslemleri
            // 
            this.btnYoneticiIslemleri.BackColor = System.Drawing.Color.Thistle;
            this.btnYoneticiIslemleri.Location = new System.Drawing.Point(88, 12);
            this.btnYoneticiIslemleri.Name = "btnYoneticiIslemleri";
            this.btnYoneticiIslemleri.Size = new System.Drawing.Size(252, 70);
            this.btnYoneticiIslemleri.TabIndex = 3;
            this.btnYoneticiIslemleri.Text = "Yönetici İşlemleri";
            this.btnYoneticiIslemleri.UseVisualStyleBackColor = false;
            this.btnYoneticiIslemleri.Click += new System.EventHandler(this.btnYoneticiIslemleri_Click);
            // 
            // btnDepartmanKayitİslemleri
            // 
            this.btnDepartmanKayitİslemleri.BackColor = System.Drawing.Color.Thistle;
            this.btnDepartmanKayitİslemleri.Location = new System.Drawing.Point(88, 278);
            this.btnDepartmanKayitİslemleri.Name = "btnDepartmanKayitİslemleri";
            this.btnDepartmanKayitİslemleri.Size = new System.Drawing.Size(252, 70);
            this.btnDepartmanKayitİslemleri.TabIndex = 4;
            this.btnDepartmanKayitİslemleri.Text = "Departman Kayıt İşlemleri";
            this.btnDepartmanKayitİslemleri.UseVisualStyleBackColor = false;
            this.btnDepartmanKayitİslemleri.Click += new System.EventHandler(this.btnDepartmanKayitİslemleri_Click);
            // 
            // frmKullaniciSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.btnDepartmanKayitİslemleri);
            this.Controls.Add(this.btnYoneticiIslemleri);
            this.Controls.Add(this.btnMaliIslemler);
            this.Controls.Add(this.btnPersonelKayitIslemleri);
            this.Name = "frmKullaniciSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Seçim Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelKayitIslemleri;
        private System.Windows.Forms.Button btnMaliIslemler;
        private System.Windows.Forms.Button btnYoneticiIslemleri;
        private System.Windows.Forms.Button btnDepartmanKayitİslemleri;
    }
}