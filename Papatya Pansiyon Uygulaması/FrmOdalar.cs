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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SD8QNP\\SQLEXPRESS;Initial Catalog=PansiyonOtomasyonu;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //Oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda101.BackColor = Color.MediumSeaGreen;
            }


            //Oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda102.BackColor = Color.MediumSeaGreen;
            }


            //Oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
               
            }
            baglanti.Close();

            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda103.BackColor = Color.MediumSeaGreen;
            }


            //Oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda104.BackColor = Color.MediumSeaGreen;
            }


            //Oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda105.BackColor = Color.MediumSeaGreen;
            }


            //Oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda106.BackColor = Color.MediumSeaGreen;
            }


            //Oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("SELECT * FROM Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda107.BackColor = Color.MediumSeaGreen;
            }


            //Oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("SELECT * FROM Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda108.BackColor = Color.MediumSeaGreen;
            }


            //Oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("SELECT * FROM Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda109.BackColor = Color.MediumSeaGreen;
            }


            //Oda110
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("SELECT * FROM Oda110", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda110.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda110.Text != "110")
            {
                BtnOda110.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda110.BackColor = Color.MediumSeaGreen;
            }


            //Oda111
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("SELECT * FROM Oda111", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda111.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda111.Text != "111")
            {
                BtnOda111.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda111.BackColor = Color.MediumSeaGreen;
            }


            //Oda112
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("SELECT * FROM Oda112", baglanti);
            SqlDataReader oku12 = komut11.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda112.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();

            }
            baglanti.Close();

            if (BtnOda112.Text != "112")
            {
                BtnOda112.BackColor = Color.IndianRed;
            }
            else
            {
                BtnOda112.BackColor = Color.MediumSeaGreen;
            }
        }






    }
    
}
