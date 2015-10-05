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
    class cUrun
    {
        private int _urunID;
        private string _urunKodu;
        private string _urunAd;
        private int _kategoriNo;
        private int _miktar;
        private decimal _birimFiyat;
        private int _kritikSeviye;

        #region Properties
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }

        public string UrunKodu
        {
            get { return _urunKodu; }
            set { _urunKodu = value; }
        }

        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        }

        public int KategoriNo
        {
            get { return _kategoriNo; }
            set { _kategoriNo = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }

        public int KritikSeviye
        {
            get { return _kritikSeviye; }
            set { _kritikSeviye = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();
        DataSet ds = new DataSet();

        public DataSet UrunleriGetir()
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select UrunID, UrunKodu, UrunAdi, Urunler.KategoriNo, KategoriAd, Miktar, KritikSeviye, BirimFiyat from urunler inner join Kategoriler on Kategoriler.KategoriNo = Urunler.KategoriNo where Urunler.silindi = 0", conn);

            try
            {
                da.Fill(ds, "Urunler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return ds;
        }

        public void UrunleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select UrunKodu, UrunAdi, KategoriAd,  Urunler.KategoriNo, UrunID from urunler inner join Kategoriler on Kategoriler.KategoriNo = Urunler.KategoriNo where Urunler.silindi = 0", conn);

            SqlDataReader dr;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
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

        public void UrunleriGetirByKodaGore(ListView liste, string kodaGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select UrunKodu, UrunAdi, KategoriAd, Urunler.KategoriNo, UrunID, Miktar, KritikSeviye, BirimFiyat from urunler inner join Kategoriler on Kategoriler.KategoriNo = Urunler.KategoriNo where Urunler.silindi = 0 and UrunKodu like @UrunKodu + '%' ", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = kodaGore;
           

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
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

        public void UrunleriGetirByAdaGore(ListView liste, string adaGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select UrunKodu, UrunAdi, KategoriAd, Urunler.KategoriNo, UrunID, Miktar, KritikSeviye, BirimFiyat from urunler inner join Kategoriler on Kategoriler.KategoriNo = Urunler.KategoriNo where Urunler.silindi = 0 and UrunAdi like @UrunAdi + '%' ", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = adaGore;


            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
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

        public void UrunleriGetirByKategoriyeGore(ListView liste, string kategoriyeGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select UrunKodu, UrunAdi, KategoriAd, Urunler.KategoriNo, UrunID, Miktar, KritikSeviye, BirimFiyat from urunler inner join Kategoriler on Kategoriler.KategoriNo = Urunler.KategoriNo where Urunler.silindi = 0 and KategoriAd like @KategoriAd + '%' ", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = kategoriyeGore;


            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
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

        public int KacinciUrun(int urunID)
        {
            int kacinciUrun = 0;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select count(*) from Urunler where silindi = 0 and UrunID < @UrunID ", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                kacinciUrun = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }

            return kacinciUrun;
        }

        public bool UrunKontrol(string kod, string ad)
        {
            bool varMi = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select * from Urunler where silindi = 0 and UrunAdi = @UrunAdi and UrunKodu = @UrunKodu", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = kod;


            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                    varMi = true;
                dr.Close();
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return varMi;
        }

        public bool UrunEkle(cUrun u)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Insert into Urunler(UrunKodu, UrunAdi, KategoriNo, BirimFiyat, KritikSeviye) values(@UrunKodu, @UrunAdi, @KategoriNo, @BirimFiyat, @KritikSeviye)", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = u._kategoriNo;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = u._birimFiyat;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public bool UrunGuncelle(cUrun u)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Update Urunler Set UrunKodu = @UrunKodu, UrunAdi = @UrunAdi, KategoriNo = @KategoriNo, BirimFiyat = @BirimFiyat, KritikSeviye = @KritikSeviye where UrunID = @UrunID", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = u._kategoriNo;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = u._birimFiyat;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = u._urunID;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public bool UrunSil(int urunID)
        {
            bool sonuc = false;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Update Urunler Set Silindi = 1 where UrunID = @UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public bool StokGuncelleFromUrunHareketEkle(int urunID, int adet, string islemTuru)
        {
            bool sonuc = false;
            string sorgu = "";
            SqlConnection conn = new SqlConnection(gnl.connStr);
            if (islemTuru == "Stok Giriş")
                sorgu = "Update Urunler Set Miktar = Miktar + @Adet where UrunID = @UrunID";
            else
                sorgu = "Update Urunler Set Miktar = Miktar - @Adet where UrunID = @UrunID";

            SqlCommand comm = new SqlCommand(sorgu, conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }
    }
}
