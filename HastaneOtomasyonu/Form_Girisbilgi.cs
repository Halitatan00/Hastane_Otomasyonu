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
    public partial class Form_Girisbilgi : Form
    {
        private form_giris girisFormRef; //Giriş formunun bağlantı yapıp oradan string değer alma
        public Form_Girisbilgi(form_giris GirisSayfasi)
        {
            InitializeComponent();
            girisFormRef = GirisSayfasi; //eşleştirip
        }
        int durum = 0;
        SqlBaglanti bgl=new SqlBaglanti();
        private void Form_Hasta_Giris_Load(object sender, EventArgs e)
        {
            string gelenDeger = girisFormRef.GirisSayfasi; //stringe çeviriyoruz
            if (gelenDeger == "hasta")
            {
                lbl_baslık.Text = "HASTA GIRIS EKRANI";
                durum = 1;
            }
            else if (gelenDeger == "doktor")
            {
                lbl_baslık.Text = "DOKTOR GIRIS EKRANI";
                lbl_uyeol.Visible = false;
                durum = 2;
            }
            else if (gelenDeger == "sekreter")
            {
                lbl_baslık.Text = "SEKRETER GIRIS EKRANI";
                lbl_uyeol.Visible = false;
                durum = 3;
            }
        }

        private void lbl_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Hasta_Uyeol formuyeol =new Form_Hasta_Uyeol();
            formuyeol.Show();
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            if (durum==1)
            {
                SqlCommand komuthasta = new SqlCommand("Select * from Tbl_Hastalar Where Hastatc=@h1 and Hastasifre=@h2", bgl.baglantı());
                komuthasta.Parameters.AddWithValue("@h1",tx_tcno.Text);
                komuthasta.Parameters.AddWithValue("@h2", tc_sifre.Text);
                SqlDataReader drhasta = komuthasta.ExecuteReader();
                if (drhasta.Read())
                {
                    Form_Hasta_Detay frmhasta = new Form_Hasta_Detay();
                    frmhasta.tc = tx_tcno.Text;
                    frmhasta.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş...");
                }
                bgl.baglantı().Close();
            }
            else if (durum == 2)
            {
                SqlCommand komutdoktor = new SqlCommand("Select * from Tbl_Doktorlar Where Doktortc=@d1 and Doktorsifre=@d2", bgl.baglantı());
                komutdoktor.Parameters.AddWithValue("@d1", tx_tcno.Text);
                komutdoktor.Parameters.AddWithValue("@d2", tc_sifre.Text);
                SqlDataReader drdoktor = komutdoktor.ExecuteReader();
                if (drdoktor.Read())
                {
                    Form_Doktor_Detay frmdoktor = new Form_Doktor_Detay();
                    frmdoktor.doktortc=tx_tcno.Text;
                    frmdoktor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş...");
                }
                bgl.baglantı().Close();
            }
            else if (durum == 3)
            {
                SqlCommand komutsekreter = new SqlCommand("Select * from Tbl_Sekreter Where Sekretertc=@s1 and Sekretersifre=@s2", bgl.baglantı());
                komutsekreter.Parameters.AddWithValue("@s1", tx_tcno.Text);
                komutsekreter.Parameters.AddWithValue("@s2", tc_sifre.Text);
                SqlDataReader drsekreter = komutsekreter.ExecuteReader();
                if (drsekreter.Read())
                {
                    Form_Sekreter_Detay frmsekreter = new Form_Sekreter_Detay();
                    frmsekreter.sekreter=tx_tcno.Text;
                    frmsekreter.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş...");
                }
                bgl.baglantı().Close();
            }
        }

        private void Form_Girisbilgi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
