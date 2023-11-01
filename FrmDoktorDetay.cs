using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;
            
            // Doktor ad ve soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevuları datagride çekme
            DataTable dr1 = new DataTable();
            SqlDataAdapter rr = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'", bgl.baglanti());
            rr.Fill(dr1);
            dataGridView1.DataSource = dr1;
            
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TC = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RichSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
        }
    }
}
