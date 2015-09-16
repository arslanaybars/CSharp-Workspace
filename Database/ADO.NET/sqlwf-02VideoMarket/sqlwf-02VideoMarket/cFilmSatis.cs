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
    class cFilmSatis
    {
        private int _satisNo;
        private DateTime _tarih;
        private int _filmNo;
        private int _musteriNo;
        private int _adet;
        private decimal _birimFiyat;

        #region Properties
        public int SatisNo
        {
            get { return _satisNo; }
            set { _satisNo = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public int FilmNo
        {
            get { return _filmNo; }
            set { _filmNo = value; }
        }

        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }
        #endregion

        cGenel gnl = new cGenel();

        public void SatislariGetir(ListView liste, TextBox adet, TextBox tutar)
        {
            liste.Items.Clear();

            int toplamAdet = 0;
            decimal toplamTutar = 0;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Select FilmSatis.SatisNo, FilmSatis.Tarih, FilmSatis.FilmNo,  Filmler.FilmAd, Filmler.Miktar, FilmSatis.MusteriNo, Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad as Musteri, FilmSatis.BirimFiyat, FilmSatis.Adet, FilmSatis.Adet * FilmSatis.BirimFiyat as Tutar from FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo where FilmSatis.Silindi = 0 order by Tarih desc", conn);

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
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    liste.Items[i].SubItems.Add(dr[9].ToString());
                    toplamAdet += Convert.ToInt32(dr[8]);
                    toplamTutar += Convert.ToDecimal(dr[9]);
                    i++;
                }
            }

            dr.Close();
            conn.Close();

            adet.Text = toplamAdet.ToString();
            tutar.Text = toplamTutar.ToString();
        }

        public bool FilmSatisEkle(cFilmSatis fs)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlCommand comm = new SqlCommand("Insert into FilmSatis( Tarih, FilmNo, MusteriNo, Adet, BirimFiyat) values ( @Tarih, @FilmNo, @MusteriNo, @Adet, @BirimFiyat)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = fs._tarih;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = fs._filmNo;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = fs._musteriNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = fs._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = fs._birimFiyat;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            conn.Close();

            return sonuc;
        }

        public bool FilmSatisIptal(int satisNo)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Update FilmSatis Set Silindi=1 where SatisNo=@SatisNo", conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = satisNo;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public DataTable SatislariGetirByTarihlerArasi(DateTime ilkTarih, DateTime sonTarih)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(gnl.connStr);

            SqlDataAdapter da = new SqlDataAdapter("Select FilmSatis.SatisNo, Convert(Date, Tarih, 104) as Tarih, Filmler.FilmAd, Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad as Musteri, FilmSatis.BirimFiyat, FilmSatis.Adet, FilmSatis.Adet * FilmSatis.BirimFiyat as Tutar from FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo where FilmSatis.Silindi = 0 and Convert(Date, Tarih, 104) >= convert(Date, @Tarih1, 104) and Convert(Date, Tarih, 104) <= convert(Date, @Tarih2, 104)", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = ilkTarih;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = sonTarih;

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            //finally
            //{
            //    conn.Close();
            //}

            
            return dt;
        }
    }
}
