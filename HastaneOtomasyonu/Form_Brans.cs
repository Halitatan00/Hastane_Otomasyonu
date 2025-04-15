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
    public partial class Form_Brans : Form
    {
        public Form_Brans()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        private void Form_Brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglantı());
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Branslar (Bransad) Values (@b1)",bgl.baglantı());
            komut1.Parameters.AddWithValue("b1", tc_ad.Text);
            komut1.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Ekleme Başarılı ...","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("DELETE FROM Tbl_Branslar Where Bransid=@b1", bgl.baglantı());
            komut2.Parameters.AddWithValue("b1",tx_id.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Silme Başarılı ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("UPDATE Tbl_Branslar Set Bransad=@b2 Where Bransid=@b1", bgl.baglantı());
            komut3.Parameters.AddWithValue("b1", tx_id.Text);
            komut3.Parameters.AddWithValue("b2", tc_ad.Text);
            komut3.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Güncelleme ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            tc_ad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            tx_id.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
        }
    }
}
