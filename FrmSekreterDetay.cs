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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text=TC;

            //Ad Soyad 
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dr = new DataTable();
            SqlDataAdapter dt1 = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            dt1.Fill(dr);
            dataGridView1.DataSource = dr;

            //Doktorlar Datagride Aktarma
            DataTable dr2 = new DataTable();
            SqlDataAdapter dt2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            dt2.Fill(dr2);
            dataGridView2.DataSource = dr2;

            //Branşı comboboxa aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader rd = komut3.ExecuteReader();
            while (rd.Read())
            {
                CmbBrans.Items.Add(rd[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kaydınız Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            CmbDoktor.Text = "";
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",RichDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListe fr = new FrmRandevuListe();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
