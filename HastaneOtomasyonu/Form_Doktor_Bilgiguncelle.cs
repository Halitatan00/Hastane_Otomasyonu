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
    public partial class Form_Doktor_Bilgiguncelle : Form
    {
        public Form_Doktor_Bilgiguncelle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        public string tcno;
        private void Form_Doktor_Bilgiguncelle_Load(object sender, EventArgs e)
        {
            tx_tcno.Text = tcno;

            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select Bransad From Tbl_Branslar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cb_brans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();

            //Doktoru Çekme
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE Doktortc=@d1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@d1",tx_tcno.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read()) {
                tc_ad.Text = dr[1].ToString();
                tc_soyad.Text = dr[2].ToString();
                cb_brans.Text = dr[3].ToString();
                tx_tcno.Text = dr[4].ToString();
                tx_sifre.Text = dr[5].ToString();
            }
            bgl.baglantı().Close();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Tbl_Doktorlar Set Doktorad=@d1,Doktorsoyad=@d2,Doktorbrans=@d3,Doktorsifre=@d4 Where Doktortc=@d5", bgl.baglantı());
            komut3.Parameters.AddWithValue("@d1",tc_ad.Text);
            komut3.Parameters.AddWithValue("@d2", tc_soyad.Text);
            komut3.Parameters.AddWithValue("@d3", cb_brans.Text);
            komut3.Parameters.AddWithValue("@d4", tx_sifre.Text);
            komut3.Parameters.AddWithValue("@d5", tx_tcno.Text);
            komut3.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Güncellendi ... ","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
