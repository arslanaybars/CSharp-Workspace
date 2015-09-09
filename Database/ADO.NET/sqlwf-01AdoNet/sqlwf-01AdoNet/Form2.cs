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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");
            SqlCommand comm = new SqlCommand("select Filmler.FilmNo, Filmler.FilmAd, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo", conn);
            SqlDataReader dr; //datareader sql deki verileri okumaya yarar

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            
            int i = 0;
            //SqlDataReader dr = comm.ExecuteReader();
            dr = comm.ExecuteReader();
            while (dr.Read()) // listview ekle başlıyor
            {
                //dr.GetInt32(0);//0. kolon -> filmNo
                //dr.GetString(1);//1. kolon -> FilmAd
                //dr.GetString(2);//2. kolon burası böyle devam edebilir -> FilmTuru
                //dr.GetString(3);//3. kolon -> Yönetmen
                //dr.GetString(4);//4. kolon -> Oyuncular
                //dr.GetInt32(5);//5. kolon -> miktar

                /*
                lvFilmler.Items.Add(dr.GetInt32(0).ToString()); //ilk kolon böyle ekleniyor biz id yi ekledik kolon 0
                lvFilmler.Items[i].SubItems.Add(dr.GetString(1));
                lvFilmler.Items[i].SubItems.Add(dr.GetString(2));
                lvFilmler.Items[i].SubItems.Add(dr.GetString(3));
                lvFilmler.Items[i].SubItems.Add(dr.GetString(4));
                lvFilmler.Items[i].SubItems.Add(dr.GetInt32(5).ToString());
                */

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
