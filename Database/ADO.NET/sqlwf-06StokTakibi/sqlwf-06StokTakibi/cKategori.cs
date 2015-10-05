using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_06StokTakibi
{
    class cKategori
    {
        private int _kategoriNo;
        private string _kategoriAd;
        private string _aciklama;

        #region Properties
        public int KategoriNo
        {
            get { return _kategoriNo; }
            set { _kategoriNo = value; }
        }

        public string KategoriAd
        {
            get { return _kategoriAd; }
            set { _kategoriAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        } 
        #endregion


        cGenel gnl = new cGenel();

        public void KategorileriGetir(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select * from Kategoriler where silindi = 0", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKategori k = new cKategori();
                    k._kategoriNo = Convert.ToInt32(dr["KategoriNo"]);
                    k._kategoriAd = (dr["KategoriAd"]).ToString();
                    liste.Items.Add(k);
                    //liste.Items.Add(dr["KategoriAd"].ToString());
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

        public int KategoriNoGetirByKategoriyeGore(string kategori)
        {
            int kategoriNo = 0;


            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select KategoriNo from Kategoriler where KategoriAd = @KategoriAd and Silindi = 0 ", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = kategori;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                kategoriNo = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }



            return kategoriNo;
        }

        public override string ToString()
        {
            return KategoriAd;
        }

    }
}
