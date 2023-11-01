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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bl = new sqlbaglantisi();

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p0,@p1,@p2,@p3,@p4,@p5)", bl.baglanti());
            komut.Parameters.AddWithValue("@p0", TxtAd.Text);
            komut.Parameters.AddWithValue("@p1", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MskTc.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtSıfre.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);

            komut.ExecuteNonQuery();
            bl.baglanti().Close();           
            MessageBox.Show("Kaydınız Gerçekleşmiştir \n Şifreniz: " + TxtSıfre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
