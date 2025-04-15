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
    public partial class Form_Randevulistesi : Form
    {
        public Form_Randevulistesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form_Randevulistesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular",bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            Form_Sekreter_Detay form_Sekreter_Detay = new Form_Sekreter_Detay();
            form_Sekreter_Detay.secilen = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            form_Sekreter_Detay.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
