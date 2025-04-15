using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class form_giris : Form
    {
        public form_giris()
        {
            InitializeComponent();
        }
        public string GirisSayfasi;
        private void btn_hasta_Click(object sender, EventArgs e)
        {
            GirisSayfasi = "hasta";
            Form_Girisbilgi yeniForm = new Form_Girisbilgi(this);
            yeniForm.Show();
            this.Hide();
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            GirisSayfasi = "doktor";
            Form_Girisbilgi yeniForm = new Form_Girisbilgi(this);
            yeniForm.Show();
            this.Hide();
        }

        private void btn_sekreter_Click(object sender, EventArgs e)
        {
            GirisSayfasi = "sekreter";
            Form_Girisbilgi yeniForm = new Form_Girisbilgi(this);
            yeniForm.Show();
            this.Hide();
        }
    }
}
