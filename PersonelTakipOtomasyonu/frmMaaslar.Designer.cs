
namespace PersonelTakipOtomasyonu
{
    partial class frmMaaslar
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
            this.radioBtnFiyataGore = new System.Windows.Forms.RadioButton();
            this.radioBtnYuzdeyeGore = new System.Windows.Forms.RadioButton();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtnFiyataGore
            // 
            this.radioBtnFiyataGore.AutoSize = true;
            this.radioBtnFiyataGore.Location = new System.Drawing.Point(12, 29);
            this.radioBtnFiyataGore.Name = "radioBtnFiyataGore";
            this.radioBtnFiyataGore.Size = new System.Drawing.Size(80, 17);
            this.radioBtnFiyataGore.TabIndex = 0;
            this.radioBtnFiyataGore.TabStop = true;
            this.radioBtnFiyataGore.Text = "Fiyata göre ";
            this.radioBtnFiyataGore.UseVisualStyleBackColor = true;
            this.radioBtnFiyataGore.CheckedChanged += new System.EventHandler(this.radioBtnFiyataGore_CheckedChanged);
            // 
            // radioBtnYuzdeyeGore
            // 
            this.radioBtnYuzdeyeGore.AutoSize = true;
            this.radioBtnYuzdeyeGore.Location = new System.Drawing.Point(98, 29);
            this.radioBtnYuzdeyeGore.Name = "radioBtnYuzdeyeGore";
            this.radioBtnYuzdeyeGore.Size = new System.Drawing.Size(90, 17);
            this.radioBtnYuzdeyeGore.TabIndex = 1;
            this.radioBtnYuzdeyeGore.TabStop = true;
            this.radioBtnYuzdeyeGore.Text = "Yüzdeye göre";
            this.radioBtnYuzdeyeGore.UseVisualStyleBackColor = true;
            this.radioBtnYuzdeyeGore.CheckedChanged += new System.EventHandler(this.radioBtnYuzdeyeGore_CheckedChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(87, 173);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtYuzde
            // 
            this.txtYuzde.Location = new System.Drawing.Point(87, 146);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(100, 20);
            this.txtYuzde.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(87, 199);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 49);
            this.txtAciklama.TabIndex = 4;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
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
            this.comboAy.Location = new System.Drawing.Point(87, 68);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(91, 21);
            this.comboAy.TabIndex = 6;
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(87, 104);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(186, 21);
            this.comboPersoneller.TabIndex = 7;
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dönem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fiyat(TL):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yüzde(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(184, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "/";
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelID.Location = new System.Drawing.Point(279, 105);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(14, 15);
            this.lblPersonelID.TabIndex = 14;
            this.lblPersonelID.Text = "0";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(202, 68);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(91, 21);
            this.comboYil.TabIndex = 15;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Thistle;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(107, 275);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(116, 61);
            this.btnOnayla.TabIndex = 16;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Thistle;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(229, 275);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(116, 61);
            this.btnCıkıs.TabIndex = 17;
            this.btnCıkıs.Text = "Geri";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // frmMaaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(357, 348);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.radioBtnYuzdeyeGore);
            this.Controls.Add(this.radioBtnFiyataGore);
            this.Name = "frmMaaslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Düzenleme";
            this.Load += new System.EventHandler(this.frmMaaslar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnFiyataGore;
        private System.Windows.Forms.RadioButton radioBtnYuzdeyeGore;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnCıkıs;
        public System.Windows.Forms.ComboBox comboYil;
    }
}