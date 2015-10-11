using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_27ArrayList
{
    class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private string _yonetmen;
        private string _oyuncular;
        private int _miktar;

        #region Properties
        public int FilmNo
        {
            get { return _filmNo; }
            set { _filmNo = value; }
        }

        public string FilmAd
        {
            get { return _filmAd; }
            set { _filmAd = value; }
        }

        public string Yonetmen
        {
            get { return _yonetmen; }
            set { _yonetmen = value; }
        }

        public string Oyuncular
        {
            get { return _oyuncular; }
            set { _oyuncular = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        } 
        #endregion


        public ArrayList FilmleriGetir()
        {
            ArrayList alist = new ArrayList();
            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012; Initial Catalog = VideoMarket; uid=sa; pwd=12345t");

            SqlCommand comm = new SqlCommand("Select * from Filmler", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cFilm f = new cFilm();
                    f._filmNo = Convert.ToInt32(dr["FilmNo"]);
                    f._filmAd = Convert.ToString(dr["FilmAd"]);
                    f._yonetmen = Convert.ToString(dr["Yonetmen"]);
                    f._oyuncular = Convert.ToString(dr["Oyuncular"]);
                    f._miktar = Convert.ToInt32(dr["Miktar"]);
                    alist.Add(f);
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
            return alist;
        }
    }
}
