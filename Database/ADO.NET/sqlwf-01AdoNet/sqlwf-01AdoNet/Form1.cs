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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGetir_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("DataSource = WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; Integrated Security = true");
            SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");
            //SqlCommand comm = new SqlCommand("select FilmAd from Filmler where FilmNo = " + txtFilmNo.Text, conn);
            SqlCommand comm = new SqlCommand("select FilmAd from Filmler where FilmNo = @FilmNo ", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = Convert.ToInt32(txtFilmNo.Text);
            conn.Open();
            txtFilmAdi.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }

        private void btnFilmNoGetir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog = VideoMarket; uid = sa; pwd = 12345t");
            SqlCommand comm = new SqlCommand("select FilmNo from Filmler where FilmAd = @FilmAd", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = Convert.ToString(txtFilmAdi.Text);
            conn.Open();
            txtFilmNo.Text = Convert.ToString(comm.ExecuteScalar());
            conn.Close();
        }
    }
}
