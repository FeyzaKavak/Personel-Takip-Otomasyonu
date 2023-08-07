
namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelIslemSecimSayfası
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
            this.btnIzinler = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzinler
            // 
            this.btnIzinler.BackColor = System.Drawing.Color.Thistle;
            this.btnIzinler.Location = new System.Drawing.Point(73, 190);
            this.btnIzinler.Name = "btnIzinler";
            this.btnIzinler.Size = new System.Drawing.Size(252, 70);
            this.btnIzinler.TabIndex = 7;
            this.btnIzinler.Text = "İzinler";
            this.btnIzinler.UseVisualStyleBackColor = false;
            this.btnIzinler.Click += new System.EventHandler(this.btnIzinler_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.Color.Thistle;
            this.btnPersonelListesi.Location = new System.Drawing.Point(73, 114);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Size = new System.Drawing.Size(252, 70);
            this.btnPersonelListesi.TabIndex = 6;
            this.btnPersonelListesi.Text = "Personel Listele/Düzenle";
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.Thistle;
            this.btnPersonelEkle.Location = new System.Drawing.Point(73, 38);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(252, 70);
            this.btnPersonelEkle.TabIndex = 5;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Thistle;
            this.btnCıkıs.Location = new System.Drawing.Point(73, 266);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(252, 70);
            this.btnCıkıs.TabIndex = 8;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // frmPersonelIslemSecimSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(399, 374);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnIzinler);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnPersonelEkle);
            this.Name = "frmPersonelIslemSecimSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzinler;
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnCıkıs;
    }
}