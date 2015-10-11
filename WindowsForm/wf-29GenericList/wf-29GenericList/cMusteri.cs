using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_29GenericList
{
    class cMusteri
    {
        private int _musteriNo;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;
        private bool _silindi;

        #region Properties
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }

        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public bool Silindi
        {
            get { return _silindi; }
            set { _silindi = value; }
        }
        #endregion

        public List<cMusteri> MusterileriGetir()
        {
            List<cMusteri> list = new List<cMusteri>();
            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012; Initial Catalog = VideoMarket; uid=sa; pwd=12345t");

            SqlCommand comm = new SqlCommand("Select * from Musteriler", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cMusteri m = new cMusteri();
                    m._musteriNo = Convert.ToInt32(dr["MusteriNo"]);
                    m._musteriAd = Convert.ToString(dr["MusteriAd"]);
                    m._musteriSoyad = Convert.ToString(dr["MusteriSoyad"]);
                    m._telefon = Convert.ToString(dr["Telefon"]);
                    m._adres = Convert.ToString(dr["Adres"]);
                    m._silindi = Convert.ToBoolean(dr["Silindi"]);
                    list.Add(m);
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
            return list;
        }
    }
}
