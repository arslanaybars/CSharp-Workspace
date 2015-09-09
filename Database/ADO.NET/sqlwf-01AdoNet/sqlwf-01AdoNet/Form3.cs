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

namespace sqlwf_01AdoNet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");

        private void Form3_Load(object sender, EventArgs e)
        {
            FilmTurleriniGetir();
        }

        private void FilmTurleriniGetir()
        {
            SqlCommand comm = new SqlCommand("select FilmTurleri.TurAd from FilmTurleri", conn);

            SqlDataReader dr; //datareader sql deki verileri okumaya yarar

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int i = 0;
            //SqlDataReader dr = comm.ExecuteReader();
            dr = comm.ExecuteReader();
            while (dr.Read()) // listview ekle başlıyor
            {
                cbFilmTurleri.Items.Add(dr["TurAd"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
            cbFilmTurleri.SelectedIndex = 0;
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvFilmler.Items.Clear();
            SqlCommand comm = new SqlCommand("select Filmler.FilmNo, Filmler.FilmAd, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where FilmTurleri.TurAd = @TurAd", conn);

            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = cbFilmTurleri.SelectedItem.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int i = 0;
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read()) // listview ekle başlıyor
            {
                lvFilmler.Items.Add(dr["FilmNo"].ToString());
                //lvFilmler.Items.Add(dr[0].ToString());
                lvFilmler.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                lvFilmler.Items[i].SubItems.Add(dr["TurAd"].ToString());
                lvFilmler.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                lvFilmler.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                lvFilmler.Items[i].SubItems.Add(dr["Miktar"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }
    }
}
