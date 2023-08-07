
namespace PersonelTakipOtomasyonu
{
    partial class frmMesaiListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBitisSaati = new System.Windows.Forms.MaskedTextBox();
            this.txtBaslangicSaati = new System.Windows.Forms.MaskedTextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDonemYil = new System.Windows.Forms.ComboBox();
            this.comboDonemAy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeBitisSaati = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeBaslangicSaati = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtBitisSaati
            // 
            this.txtBitisSaati.Location = new System.Drawing.Point(254, 378);
            this.txtBitisSaati.Mask = "00:00";
            this.txtBitisSaati.Name = "txtBitisSaati";
            this.txtBitisSaati.Size = new System.Drawing.Size(119, 20);
            this.txtBitisSaati.TabIndex = 35;
            this.txtBitisSaati.Text = "1730";
            this.txtBitisSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBitisSaati.ValidatingType = typeof(System.DateTime);
            // 
            // txtBaslangicSaati
            // 
            this.txtBaslangicSaati.Location = new System.Drawing.Point(254, 352);
            this.txtBaslangicSaati.Mask = "90:00";
            this.txtBaslangicSaati.Name = "txtBaslangicSaati";
            this.txtBaslangicSaati.Size = new System.Drawing.Size(119, 20);
            this.txtBaslangicSaati.TabIndex = 34;
            this.txtBaslangicSaati.Text = "0830";
            this.txtBaslangicSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBaslangicSaati.ValidatingType = typeof(System.DateTime);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(484, 278);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(256, 51);
            this.txtAciklama.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(417, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(426, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dönem:";
            this.label6.Visible = false;
            // 
            // comboDonemYil
            // 
            this.comboDonemYil.FormattingEnabled = true;
            this.comboDonemYil.Location = new System.Drawing.Point(619, 335);
            this.comboDonemYil.Name = "comboDonemYil";
            this.comboDonemYil.Size = new System.Drawing.Size(121, 21);
            this.comboDonemYil.TabIndex = 30;
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
            this.comboDonemAy.Location = new System.Drawing.Point(484, 335);
            this.comboDonemAy.Name = "comboDonemAy";
            this.comboDonemAy.Size = new System.Drawing.Size(121, 21);
            this.comboDonemAy.TabIndex = 29;
            this.comboDonemAy.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(117, 431);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(256, 20);
            this.txtTutar.TabIndex = 27;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(117, 405);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(256, 20);
            this.txtMesaiSaatUcreti.TabIndex = 26;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mesai Saat Ücreti:";
            // 
            // dateTimeBitisSaati
            // 
            this.dateTimeBitisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitisSaati.Location = new System.Drawing.Point(117, 378);
            this.dateTimeBitisSaati.Name = "dateTimeBitisSaati";
            this.dateTimeBitisSaati.Size = new System.Drawing.Size(131, 20);
            this.dateTimeBitisSaati.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bitiş Saati:";
            // 
            // dateTimeBaslangicSaati
            // 
            this.dateTimeBaslangicSaati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangicSaati.Location = new System.Drawing.Point(117, 352);
            this.dateTimeBaslangicSaati.Name = "dateTimeBaslangicSaati";
            this.dateTimeBaslangicSaati.Size = new System.Drawing.Size(131, 20);
            this.dateTimeBaslangicSaati.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mesai ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(36, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Personel ID:";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(117, 326);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(256, 20);
            this.txtAdiSoyadi.TabIndex = 39;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(117, 300);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(256, 20);
            this.txtPersonelID.TabIndex = 40;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(117, 274);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(256, 20);
            this.txtMesaiID.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(624, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 42;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMesaiListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(752, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBitisSaati);
            this.Controls.Add(this.txtBaslangicSaati);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMesaiListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Listele";
            this.Load += new System.EventHandler(this.frmMesaiListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtBitisSaati;
        private System.Windows.Forms.MaskedTextBox txtBaslangicSaati;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDonemYil;
        private System.Windows.Forms.ComboBox comboDonemAy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeBitisSaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangicSaati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}