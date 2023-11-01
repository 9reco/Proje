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

namespace WindowsFormsApp1
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dl = komut.ExecuteReader();
            while (dl.Read())
            {
                TxtAd.Text = dl[1].ToString();
                TxtSoyad.Text = dl[2].ToString();
                MskTelefon.Text = dl[4].ToString();
                TxtSıfre.Text = dl[5].ToString();
                CmbCinsiyet.Text = dl[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut1.Parameters.AddWithValue("@p4", TxtSıfre.Text);
            komut1.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut1.Parameters.AddWithValue("@p6", MskTc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
