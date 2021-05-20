using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması
{
    public partial class FrmStoklar : Form
    {
        
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SD8QNP\\SQLEXPRESS;Initial Catalog=PansiyonOtomasyonu;Integrated Security=True");
        private void veriler()
        {
            listViewMutfakStok.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerez"].ToString());
                listViewMutfakStok.Items.Add(ekle);
               
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listViewFaturaStok.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listViewFaturaStok.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Stoklar(Gida,İcecek,Cerez)values ('"+TxtGidalar.Text+"','"+Txtİcecekler.Text+"','"+TxtAtistirmaliklar.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Faturalar(Elektrik,Su,İnternet)values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
