
namespace PersonelTakipOtomasyonu
{
    partial class frmMesaiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPersonelAdiSoyadi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeBaslangicSaati = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitisSaati = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBaslangicSaati = new System.Windows.Forms.MaskedTextBox();
            this.txtBitisSaati = new System.Windows.Forms.MaskedTextBox();
            this.comboDonemYil = new System.Windows.Forms.ComboBox();
            this.comboDonemAy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı ve Soyadı:";
            // 
            // comboPersonelAdiSoyadi
            // 
            this.comboPersonelAdiSoyadi.FormattingEnabled = true;
            this.comboPersonelAdiSoyadi.Location = new System.Drawing.Point(152, 37);
            this.comboPersonelAdiSoyadi.Name = "comboPersonelAdiSoyadi";
            this.comboPersonelAdiSoyadi.Size = new System.Drawing.Size(257, 21);
            this.comboPersonelAdiSoyadi.TabIndex = 1;
            this.comboPersonelAdiSoyadi.SelectedIndexChanged += new System.EventHandler(this.comboPersonelAdiSoyadi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // dateTimeBaslangicSaati
            // 
            this.dateTimeBaslangicSaati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangicSaati.Location = new System.Drawing.Point(152, 64);
            this.dateTimeBaslangicSaati.Name = "dateTimeBaslangicSaati";
            this.dateTimeBaslangicSaati.Size = new System.Drawing.Size(131, 20);
            this.dateTimeBaslangicSaati.TabIndex = 3;
            this.dateTimeBaslangicSaati.ValueChanged += new System.EventHandler(this.dateTimeBaslangicSaati_ValueChanged);
            // 
            // dateTimeBitisSaati
            // 
            this.dateTimeBitisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitisSaati.Location = new System.Drawing.Point(153, 90);
            this.dateTimeBitisSaati.Name = "dateTimeBitisSaati";
            this.dateTimeBitisSaati.Size = new System.Drawing.Size(131, 20);
            this.dateTimeBitisSaati.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mesai Saat Ücreti:";
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(153, 117);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(256, 20);
            this.txtMesaiSaatUcreti.TabIndex = 9;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(153, 143);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(256, 20);
            this.txtTutar.TabIndex = 10;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(108, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(86, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(153, 169);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(256, 51);
            this.txtAciklama.TabIndex = 16;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Thistle;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(205, 269);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(116, 61);
            this.btnOnayla.TabIndex = 17;
            this.btnOnayla.Text = "Mesai Ekle";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(327, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBaslangicSaati
            // 
            this.txtBaslangicSaati.Location = new System.Drawing.Point(290, 64);
            this.txtBaslangicSaati.Mask = "90:00";
            this.txtBaslangicSaati.Name = "txtBaslangicSaati";
            this.txtBaslangicSaati.Size = new System.Drawing.Size(119, 20);
            this.txtBaslangicSaati.TabIndex = 19;
            this.txtBaslangicSaati.Text = "0830";
            this.txtBaslangicSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBaslangicSaati.ValidatingType = typeof(System.DateTime);
            // 
            // txtBitisSaati
            // 
            this.txtBitisSaati.Location = new System.Drawing.Point(290, 90);
            this.txtBitisSaati.Mask = "00:00";
            this.txtBitisSaati.Name = "txtBitisSaati";
            this.txtBitisSaati.Size = new System.Drawing.Size(119, 20);
            this.txtBitisSaati.TabIndex = 20;
            this.txtBitisSaati.Text = "1730";
            this.txtBitisSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBitisSaati.ValidatingType = typeof(System.DateTime);
            this.txtBitisSaati.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBitisSaati_MaskInputRejected);
            // 
            // comboDonemYil
            // 
            this.comboDonemYil.FormattingEnabled = true;
            this.comboDonemYil.Location = new System.Drawing.Point(288, 226);
            this.comboDonemYil.Name = "comboDonemYil";
            this.comboDonemYil.Size = new System.Drawing.Size(121, 21);
            this.comboDonemYil.TabIndex = 13;
            this.comboDonemYil.Visible = false;
            // 
            // comboDonemAy
            // 
            this.comboDonemAy.FormattingEnabled = true;
            this.comboDonemAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboDonemAy.Location = new System.Drawing.Point(153, 226);
            this.comboDonemAy.Name = "comboDonemAy";
            this.comboDonemAy.Size = new System.Drawing.Size(121, 21);
            this.comboDonemAy.TabIndex = 12;
            this.comboDonemAy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(95, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dönem:";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(83, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 61);
            this.button2.TabIndex = 21;
            this.button2.Text = "Mesai Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(457, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBitisSaati);
            this.Controls.Add(this.txtBaslangicSaati);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboDonemYil);
            this.Controls.Add(this.comboDonemAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeBitisSaati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeBaslangicSaati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPersonelAdiSoyadi);
            this.Controls.Add(this.label1);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangicSaati;
        private System.Windows.Forms.DateTimePicker dateTimeBitisSaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtBaslangicSaati;
        private System.Windows.Forms.MaskedTextBox txtBitisSaati;
        private System.Windows.Forms.ComboBox comboDonemYil;
        private System.Windows.Forms.ComboBox comboDonemAy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPersonelAdiSoyadi;
        private System.Windows.Forms.Button button2;
    }
}