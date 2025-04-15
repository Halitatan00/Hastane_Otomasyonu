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
    public partial class Form_Hasta_Uyeol : Form
    {
        public Form_Hasta_Uyeol()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl =new SqlBaglanti();
        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("INSERT INTO Tbl_Hastalar(Hastaad, Hastasoyad, Hastatc, Hastatelefon, Hastasifre, Hastacinsiyet) VALUES (@h1,@h2,@h3,@h4,@h5,@h6)",bgl.baglantı());
            komut.Parameters.AddWithValue("@h1", tx_ad.Text);
            komut.Parameters.AddWithValue("@h2", tx_soyad.Text);
            komut.Parameters.AddWithValue("@h3", tx_tcno.Text);
            komut.Parameters.AddWithValue("@h4", tx_telefonno.Text);
            komut.Parameters.AddWithValue("@h5", tx_sifre.Text);
            komut.Parameters.AddWithValue("@h6", cb_cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir ... ","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form_Hasta_Uyeol_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
