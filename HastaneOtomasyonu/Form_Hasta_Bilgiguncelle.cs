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
    public partial class Form_Hasta_Bilgiguncelle : Form
    {
        public Form_Hasta_Bilgiguncelle()
        {
            InitializeComponent();
        }
        public string Tcno;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE Tbl_Hastalar SET Hastaad=@g1,Hastasoyad=@g2,Hastatelefon=@g3,Hastasifre=@g4,Hastacinsiyet=@g5 Where Hastatc=@g6",bgl.baglantı());
            komut2.Parameters.AddWithValue("@g1",tx_ad.Text);
            komut2.Parameters.AddWithValue("@g2", tx_soyad.Text);
            komut2.Parameters.AddWithValue("@g3", tx_telefonno.Text);
            komut2.Parameters.AddWithValue("@g4", tx_sifre.Text);
            komut2.Parameters.AddWithValue("@g5", cb_cinsiyet.Text);
            komut2.Parameters.AddWithValue("@g6", tx_tcno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Güncelleme Başarılı ...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form_Hasta_Bilgiguncelle_Load(object sender, EventArgs e)
        {
            tx_tcno.Text = Tcno;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar Where Hastatc=@p1",bgl.baglantı());
            komut.Parameters.AddWithValue("@p1",tx_tcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) {
                tx_ad.Text = dr[1].ToString();
                tx_soyad.Text = dr[2].ToString();
                tx_telefonno.Text = dr[4].ToString();
                tx_sifre.Text = dr[5].ToString();
                cb_cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglantı().Close();

        }
    }
}
