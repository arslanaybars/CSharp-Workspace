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
    class cFilmTuru
    {
        private int _filmTurNo;
        private string _turAd;
        private string _aciklama;

        #region Properties
        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
        }

        public string TurAd
        {
            get { return _turAd; }
            set { _turAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        cGenel gnl = new cGenel();

        public void FilmTurleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where silindi = 0", conn);

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
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public void FilmTurleriGoster(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select TurAd from FilmTurleri where silindi = 0", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = comm.ExecuteReader();

            int i = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        //Film Tur numarası ile film turunu string olarak döndüren metod
        public string FilmTuruGetirByFilmTurNo(int filmTurNo)
        {
            string turAdi = "Seciniz";

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select TurAd from FilmTurleri where FilmTurNo = @FilmTurNo and silindi = 0", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = filmTurNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            turAdi = Convert.ToString(comm.ExecuteScalar());

            conn.Close();

            return turAdi; 
        }

        public int FilmTurNoGetirByTureGore(string filmTuru)
        {
            int turNo = 0;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("select FilmTurNo from FilmTurleri where turAd = @turAd and silindi = 0", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = filmTuru;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            turNo = Convert.ToInt32(comm.ExecuteScalar());         
            
            conn.Close();

            return turNo; 
        }

        public bool FilmTuruEkle(string filmTuru, string aciklama)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Insert into FilmTurleri (TurAd, Aciklama) values (@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = filmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = aciklama;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            //if (sonuc)
            //    MessageBox.Show("Ögretmenler bilgileri eklendi");

            return sonuc;
        }

        public bool FilmTuruKontrol(string filmTuru)
        {
            bool varMi = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            //SqlCommand comm = new SqlCommand("select count(turAd) from FilmTurleri where turAd = @turAd ", conn);
            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where TurAd=@TurAd and silindi = 0", conn);
            comm.Parameters.Add("@turAd", SqlDbType.VarChar).Value = filmTuru;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                varMi = true;

            dr.Close();
            conn.Close();

            //varMi = Convert.ToBoolean(comm.ExecuteScalar());

            return varMi;
        }

        public bool FilmTuruGuncelle(int turNo, string filmTuru, string aciklama)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update FilmTurleri set TurAd=@TurAd, Aciklama=@Aciklama where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = turNo;
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = filmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = aciklama;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            //if (sonuc)
            //    MessageBox.Show("Ögretmenler bilgileri eklendi");

            conn.Close();

            return sonuc;
        }

        public bool FilmTuruGuncelle(cFilmTuru ft)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update FilmTurleri set TurAd=@TurAd, Aciklama=@Aciklama where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = ft._filmTurNo;
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = ft._turAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ft._aciklama;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            //if (sonuc)
            //    MessageBox.Show("Ögretmenler bilgileri eklendi");

            conn.Close();

            return sonuc;
        }

        //public bool FilmTuruSil(cFilmTuru ft)
        //{
        //    bool sonuc = false;

        //    SqlConnection conn = new SqlConnection(gnl.connStr);

        //    SqlCommand comm = new SqlCommand("Delete from FilmTurleri Where FilmTurNo = @FilmTurNo", conn);
        //    comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = ft._filmTurNo;

        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();

        //    sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

        //    //if (sonuc)
        //    //    MessageBox.Show("Ögretmenler bilgileri eklendi");

        //    conn.Close();

        //    return sonuc;
        //}

        public bool FilmTuruSil(cFilmTuru ft)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update FilmTurleri Set Silindi = 1 Where FilmTurNo = @FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = ft._filmTurNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            //if (sonuc)
            //    MessageBox.Show("Ögretmenler bilgileri eklendi");

            conn.Close();

            return sonuc;
        }

        //public bool FilmTuruSil(int turNo)
        //{
        //    bool sonuc = false;

        //    SqlConnection conn = new SqlConnection(gnl.connStr);

        //    SqlCommand comm = new SqlCommand("Delete from FilmTurleri Where FilmTurNo = @FilmTurNo", conn);
        //    comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = turNo;

        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();

        //    sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

        //    //if (sonuc)
        //    //    MessageBox.Show("Ögretmenler bilgileri eklendi");

        //    conn.Close();

        //    return sonuc;
        //}

        public bool FilmTuruSil(int turNo)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update FilmTurleri Set Silindi = 1 Where FilmTurNo = @FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = turNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            //if (sonuc)
            //    MessageBox.Show("Ögretmenler bilgileri eklendi");

            conn.Close();

            return sonuc;
        }

    }
}
