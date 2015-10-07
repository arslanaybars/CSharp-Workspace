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

namespace sqlwf07_StoredProcedures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvFilmler.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012;Initial Catalog=VideoMarket; uid=sa; pwd=12345t");
            //SqlCommand comm = new SqlCommand("Select FilmAd, TurAd, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo where Varmi = 1", conn);
            SqlCommand comm = new SqlCommand();
            //comm.CommandText = "Select FilmAd, TurAd, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo where Varmi = 1";
            //comm.CommandType = CommandType.Text;
            //comm.Connection = conn;

            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_FilmGetir";
            comm.Connection = conn;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvFilmler.Items.Add(dr[0].ToString());
                    lvFilmler.Items[i].SubItems.Add(dr[1].ToString());
                    lvFilmler.Items[i].SubItems.Add(dr[2].ToString());
                    lvFilmler.Items[i].SubItems.Add(dr[3].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
