using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmDepartmanEkleDuzenle : Form
    {
        public frmDepartmanEkleDuzenle()
        {
            InitializeComponent();
        }

        private void frmDepartmanEkleDuzenle_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "insert into Departmanlar values ('"+d.Departman+"','"+d.Aciklama+"')";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sorgu);
            MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanId = int.Parse(txtDepartmanId.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "update Departmanlar set Departman = '"+d.Departman+"', Aciklama = '"+d.Aciklama+"' where DepartmanID='"+d.DepartmanId+"'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sorgu);
            MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
          /*  if (listView1.SelectedItems.Count>0) {
                Departmanlar d = new Departmanlar();
                d.DepartmanId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from Departmanlar where DepartmanID='"+d.DepartmanId+"'";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sorgu);
                MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Kayıt seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
