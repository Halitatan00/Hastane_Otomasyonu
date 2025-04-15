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
    public partial class Form_Sekreter_Detay : Form
    {
        public Form_Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string sekreter;
        SqlBaglanti bgl =new SqlBaglanti();
        public string secilen;
        private void Form_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = sekreter;
            tx_id.Text = secilen;
            //Ad yazma
            SqlCommand komut = new SqlCommand("SELECT Sekreteradsoyad FROM Tbl_Sekreter WHERE SekretertC = @t1", bgl.baglantı());
            komut.Parameters.AddWithValue("@t1",lbl_tc.Text);
             SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read()) {
                lbl_adsoyad.Text=dr1[0].ToString();
            }
            bgl.baglantı().Close();

            //branşlar
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglantı());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
           

            //Doktorlar
            DataTable dt2 = new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select (Doktorad + ' ' + Doktorsoyad) as 'Doktorlar' ,Doktorbrans as 'Branşlar' from Tbl_doktorlar",bgl.baglantı());
            dv.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Brans Combobox
            SqlCommand cbr = new SqlCommand("Select Bransad from Tbl_Branslar", bgl.baglantı());
            SqlDataReader dr2 = cbr.ExecuteReader();
            while (dr2.Read())
            {
                cb_brans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();

            //Randevuyu çekme
            SqlCommand cbr2 = new SqlCommand("Select * From Tbl_Randevular Where Randevuid=@r1", bgl.baglantı());
            cbr2.Parameters.AddWithValue("r1",tx_id.Text);
            SqlDataReader dr=cbr2.ExecuteReader();
            while (dr.Read())
            {
                tx_tarih.Text=dr[1].ToString();
                tx_saat.Text=dr[2].ToString();
                cb_brans.Text=dr[3].ToString();
                cb_doktor.Text=dr[4].ToString();
                tx_tc.Text=dr[6].ToString();
            }
            bgl.baglantı().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("INSERT INTO Tbl_Randevular (Randevutarih,Randevusaat,Randevubrans,Randevudoktor) VALUES (@y1,@y2,@y3,@y4)",bgl.baglantı());
            komut3.Parameters.AddWithValue("@y1",tx_tarih.Text);
            komut3.Parameters.AddWithValue("@y2", tx_saat.Text);
            komut3.Parameters.AddWithValue("@y3", cb_brans.Text);
            komut3.Parameters.AddWithValue("@y4", cb_doktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Alındı...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

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
                cb_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglantı().Close();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) VALUES (@d1)", bgl.baglantı());
            komut4.Parameters.AddWithValue("@d1",tx_olustur.Text);
            komut4.ExecuteNonQuery();
            bgl.baglantı().Close();
        }

        private void btn_doktorpaneli_Click(object sender, EventArgs e)
        {
            Form_Doktor_Paneli frmdoktorpanel =new Form_Doktor_Paneli();
            frmdoktorpanel.Show();
        }

        private void btn_branspaneli_Click(object sender, EventArgs e)
        {
            Form_Brans frmbrans=new Form_Brans();
            frmbrans.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_randevulistesi_Click(object sender, EventArgs e)
        {
            Form_Randevulistesi frmrandevu =new Form_Randevulistesi();
            frmrandevu.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("update Tbl_Randevular set Randevutarih=@r1,Randevusaat=@r2,Randevubrans=@r3,Randevudoktor=@r4,Hastatc=@r5 Where Randevuid=@r6",bgl.baglantı());
            cmd3.Parameters.AddWithValue("@r1",tx_tarih.Text);
            cmd3.Parameters.AddWithValue("@r2", tx_saat.Text);
            cmd3.Parameters.AddWithValue("@r3", cb_brans.Text);
            cmd3.Parameters.AddWithValue("@r4", cb_doktor.Text);
            cmd3.Parameters.AddWithValue("@r5", tx_tc.Text);
            cmd3.Parameters.AddWithValue("@r6", tx_id.Text);
            cmd3.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Başarılı ...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            Form_Duyurular frmduyuru =new Form_Duyurular();
            frmduyuru.Show();
        }

        private void Form_Sekreter_Detay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
