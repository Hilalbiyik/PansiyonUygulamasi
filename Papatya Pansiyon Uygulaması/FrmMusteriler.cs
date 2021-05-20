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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SD8QNP\\SQLEXPRESS;Initial Catalog=PansiyonOtomasyonu;Integrated Security=True");
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
            MskTextTelefon.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarih.Text = listView1.SelectedItems[0].SubItems[10].Text;



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();

            }

            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (TxtOdaNo.Text == "110")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda110", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "111")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda111", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (TxtOdaNo.Text == "112")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE from Oda112", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }



        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            TxtKimlikNo.Clear();
            MskTextTelefon.Clear();
            TxtMail.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarih.Text = "";
            DtpCikisTarih.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet= '" + comboBox1.Text + "',TC='" + TxtKimlikNo.Text + "',Telefon= '" + MskTextTelefon.Text + "',Mail= '" + TxtMail.Text + "',OdaNo= '" + TxtOdaNo.Text + "',Ucret= '" + TxtUcret.Text + "',GirisTarihi= '" + DtpGirisTarih.Value.ToString("yyyy-MM-dd") + "',CikisTarihi= '" + DtpCikisTarih.Value.ToString("yyyy-MM-dd") + "'where MusteriID =" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where Adi like '%" + TxtAra.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}

//SqlCommand komut = new SqlCommand("DELETE from MusteriEkle where MusteriID=(" + id + ")", baglanti);