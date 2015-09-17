using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlwf_05BindingOkul
{
    class cOgretmen
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _brans;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Brans
        {
            get { return _brans; }
            set { _brans = value; }
        } 
        #endregion


        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=OKUL; uid = sa; pwd = 12345t");

        DataSet ds = new DataSet();

        public DataSet OgretmenleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Ogretmenler", conn);

            try
            {
                da.Fill(ds, "Ogretmenler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
           
            return ds;
        }

        
    }
}
