using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_02VideoMarket
{
    class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private int _miktar;
        private int _varMi;

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

        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
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

        public string Ozet
        {
            get { return _ozet; }
            set { _ozet = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }

        public int VarMi
        {
            get { return _varMi; }
            set { _varMi = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();

        public void FilmleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select Filmler.FilmNo, Filmler.FilmAd, Filmler.FilmTurNo, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Ozet, Filmler.Miktar from Filmler inner join FilmTurleri on filmler.FilmTurNo = FilmTurleri.FilmTurNo where VarMi = 1", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    
                    i++;
                }
            }

            dr.Close();
            conn.Close();
        }

        public bool FilmEkle(cFilm f)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular, Ozet, Miktar) values (@FilmAd, @FilmTurNo, @Yonetmen, @Oyuncular, @Ozet, @Miktar)", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            //TODO
            comm.Parameters.Add("@FilmTurNo", SqlDbType.VarChar).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public bool FilmKontrol(cFilm f)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select * from Filmler where FilmAd = @FilmAd and Yonetmen = @Yonetmen ", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
    
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            //sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                sonuc = true;

            dr.Close();
            conn.Close();

            return sonuc;
        }

        public bool FilmGuncelle(cFilm f)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update Filmler set FilmAd=@FilmAd, FilmTurNo=@FilmTurNo, Yonetmen=@Yonetmen, Oyuncular=@Oyuncular, Ozet=@Ozet, Miktar=@Miktar where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public bool FilmSil(cFilm f)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            //TODO: delete -> not update
            SqlCommand comm = new SqlCommand("Update Filmler Set Varmi = 0 Where FilmNo = @FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public void FilmleriGetirByAdaGore(string adaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select Filmler.FilmNo, Filmler.FilmAd, Filmler.FilmTurNo, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Ozet, Filmler.Miktar from Filmler inner join FilmTurleri on filmler.FilmTurNo = FilmTurleri.FilmTurNo where FilmAd like @AdaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = adaGore;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public void FilmleriGetirbyTureGore(string filmTuru, ListView liste)
        {
            liste.Items.Clear();

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select Filmler.FilmNo, Filmler.FilmAd, Filmler.FilmTurNo, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Ozet, Filmler.Miktar from Filmler inner join FilmTurleri on filmler.FilmTurNo = FilmTurleri.FilmTurNo Where FilmTurleri.Turad = @TurAd", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = filmTuru;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();

        }

        public bool FilmStokGuncelleFromSatisEkle(int filmNo, int adet)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("update Filmler Set Miktar -= @Adet Where FilmNo = @FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = filmNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }



        public bool FilmStokGuncelleFromSatisIptal(int filmNo, int adet)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Update Filmler Set Miktar=Miktar+@Adet  where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = filmNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;
            if (conn.State == ConnectionState.Closed) conn.Open();
            Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            return Sonuc;
        }
    }
}
