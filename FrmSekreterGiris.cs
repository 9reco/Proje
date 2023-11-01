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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dl = komut.ExecuteReader();
            if (dl.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.TC = MskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
