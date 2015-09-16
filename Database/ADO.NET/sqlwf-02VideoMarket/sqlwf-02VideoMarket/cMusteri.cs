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

        //Veritabanı genel bilgileri icin
        cGenel gnl = new cGenel();

        public void MusterileriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("select * from Musteriler where silindi = 0", conn);

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
                    //silindi dogal olarak parse ettirilmemistir.
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public bool MusteriEkle(cMusteri m)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Insert into Musteriler(MusteriAd, MusteriSoyad, Telefon, Adres) values (@MusteriAd, @MusteriSoyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();              

            return sonuc;           
        }

        public bool MusteriEkle(string adi, string soyadi, string telefon, string adres)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Insert into Musteriler(MusteriAd, MusteriSoyad, Telefon, Adres) values (@MusteriAd, @MusteriSoyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = adi;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = adres;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public bool MusteriKontrol(string telefon)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("select * from musteriler where Telefon = @Telefon and silindi = 0", conn);
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = telefon;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader rd = comm.ExecuteReader();

            if (rd.HasRows)
                sonuc = true;

            rd.Close();
            conn.Close();

            return sonuc;
        }

        public bool MusteriGuncelle(cMusteri m)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update Musteriler Set MusteriAd = @MusteriAd , MusteriSoyad = @MusteriSoyad, Telefon = @Telefon, Adres = @Adres Where MusteriNo = @MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = m._musteriNo;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public bool MusteriSil(cMusteri m)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Update Musteriler Set Silindi = 1 Where MusteriNo = @MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = m._musteriNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());


            conn.Close();
            
            return sonuc;
        }

        public void MusterileriGetirByAdaGore(string adaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("select * from Musteriler where silindi = 0 and MusteriAd like @MusteriAd + '%'", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = adaGore; 

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
                    //silindi dogal olarak parse ettirilmemistir.
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
    }
}
