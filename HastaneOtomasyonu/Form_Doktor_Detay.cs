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
    public partial class Form_Doktor_Detay : Form
    {
        public Form_Doktor_Detay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        public string doktortc;
        private void Form_Doktor_Detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text= doktortc;

            //Ad soyad çekme
            SqlCommand cmd = new SqlCommand("Select Doktorad,Doktorsoyad From Tbl_Doktorlar Where Doktortc=@d1", bgl.baglantı());
            cmd.Parameters.AddWithValue("@d1", lbl_tc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_adsoyad.Text= dr[0] + " " + dr[1];
            }

            //randevuları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular Where Randevudoktor='"+lbl_adsoyad.Text+"'", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_bilgiduzenle_Click(object sender, EventArgs e)
        {
            Form_Doktor_Bilgiguncelle frmdoktorbilgi =new Form_Doktor_Bilgiguncelle();
            frmdoktorbilgi.tcno =lbl_tc.Text;
            frmdoktorbilgi.Show();

        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Form_Duyurular frmduyuru =new Form_Duyurular();
            frmduyuru.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tx_sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Doktor_Detay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
