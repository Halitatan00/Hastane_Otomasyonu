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
    public partial class Form_Hasta_Detay : Form
    {
        public Form_Hasta_Detay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;
        private void Form_Hasta_Detay_Load(object sender, EventArgs e)
        {
            //Diğer Formdan ad soyad çekme
            lbl_tc.Text = tc;
            SqlCommand komut1 = new SqlCommand("select Hastaad,Hastasoyad from Tbl_Hastalar where Hastatc=@h1",bgl.baglantı());
            komut1.Parameters.AddWithValue("@h1", lbl_tc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0]+ " "+dr[1];
            }
            bgl.baglantı().Close();
            
            //Geçmiş Randevu
            DataTable dt = new DataTable(); //tabloda gösterme
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular Where Hastatc="+ tc,bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select Bransad From Tbl_Branslar",bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cb_brans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
           
        }

        private void cb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter randevu = new SqlDataAdapter("Select * from Tbl_Randevular Where Randevubrans='"+ cb_brans.Text +"'"+" and Randevudoktor='"+cb_doktor.Text + "' and Randevudurum=0",bgl.baglantı());
            randevu.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        private void cb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktorlar listele
            cb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select Doktorad,Doktorsoyad From Tbl_Doktorlar Where Doktorbrans=@b1", bgl.baglantı());
            komut3.Parameters.AddWithValue("@b1", cb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cb_doktor.Items.Add(dr3[0] + " " +dr3[1]);
            }
            bgl.baglantı().Close();
        }

        private void lnk_bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Hasta_Bilgiguncelle frm =new Form_Hasta_Bilgiguncelle();
            frm.Tcno = lbl_tc.Text;
            frm.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("UPDATE  Tbl_Randevular SET Randevudurum=1,Hastatc=@r1,Hastasikayet=@r2 where Randevuid=@r3", bgl.baglantı());
            komut3.Parameters.AddWithValue("@r1",lbl_tc.Text);
            komut3.Parameters.AddWithValue("@r2", tx_sikayet.Text);
            komut3.Parameters.AddWithValue("@r3", tx_id.Text);
            komut3.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Alındı ...","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen =dataGridView2.SelectedCells[0].RowIndex;
            tx_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void tx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Hasta_Detay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
