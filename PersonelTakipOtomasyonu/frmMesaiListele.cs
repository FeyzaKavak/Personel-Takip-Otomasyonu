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
    public partial class frmMesaiListele : Form
    {
        public frmMesaiListele()
        {
            InitializeComponent();
        }

        private void frmMesaiListele_Load(object sender, EventArgs e)
        {
           /* int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 5); i--)
            {
                comboDonemYil.Items.Add(i);
            }*/
            veritabani.Listele_Ara(dataGridView1,"Select * from Mesailer ");
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            yapilanZamlar.personelAdSoyadGetir(txtPersonelID, txtAdiSoyadi);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells["MesaiSaatUcreti"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

            string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
            string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
            string doneml= dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();

        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangicSaati.Text + " " + txtBaslangicSaati.Text;
                string bitis = dateTimeBitisSaati.Text + " " + txtBitisSaati.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
