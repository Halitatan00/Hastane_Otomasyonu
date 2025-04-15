using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class Form_Doktor_Paneli : Form
    {
        public Form_Doktor_Paneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        private void Form_Doktor_Paneli_Load(object sender, EventArgs e)
        {
            //Doktorları çek
            DataTable dt1 = new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select * from Tbl_doktorlar", bgl.baglantı());
            dv.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branslarıcomboxa at
            SqlCommand cbr = new SqlCommand("Select Bransad from Tbl_Branslar", bgl.baglantı());
            SqlDataReader dr2 = cbr.ExecuteReader();
            while (dr2.Read())
            {
                cb_brans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Insert into Tbl_Doktorlar (Doktorad,Doktorsoyad,Doktorbrans,Doktortc,Doktorsifre) VALUES (@d1,@d2,@d3,@d4,@d5)",bgl.baglantı());
            komut1.Parameters.AddWithValue("@d1",tc_ad.Text);
            komut1.Parameters.AddWithValue("@d2", tc_soyad.Text);
            komut1.Parameters.AddWithValue("@d3", cb_brans.Text);
            komut1.Parameters.AddWithValue("@d4", tx_tcno.Text);
            komut1.Parameters.AddWithValue("@d5", tx_sifre.Text);
            komut1.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Başarılı ...","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim =dataGridView1.SelectedCells[0].RowIndex;
            tc_ad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            tc_soyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            cb_brans.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            tx_tcno.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            tx_sifre.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            tx_id.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Doktorlar Where Doktorid=@s1",bgl.baglantı());
            komutsil.Parameters.AddWithValue("s1",tx_id.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Silindi ...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Doktorlar set Doktorad=@g1,Doktorsoyad=@g2,Doktorbrans=@g3,Doktortc=@g4,Doktorsifre=@g5 Where Doktorid=@g6", bgl.baglantı());
            komutguncelle.Parameters.AddWithValue("@g1", tc_ad.Text);
            komutguncelle.Parameters.AddWithValue("@g2", tc_soyad.Text);
            komutguncelle.Parameters.AddWithValue("@g3", cb_brans.Text);
            komutguncelle.Parameters.AddWithValue("@g4", tx_tcno.Text);
            komutguncelle.Parameters.AddWithValue("@g5", tx_sifre.Text);
            komutguncelle.Parameters.AddWithValue("@g6", tx_id.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Güncellendi ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form_Doktor_Paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
