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
    class cUrunHareket
    {
        private int _hareketID;
        private DateTime _tarih;
        private string _islemTuru;
        private int _firmaNo;
        private int _urunID;
        private string _birim;
        private string _belge;
        private int _adet;
        private decimal _birimFiyat;
        private decimal _tutar;

        #region Properties
        public int HareketID
        {
            get { return _hareketID; }
            set { _hareketID = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }

        public int FirmaNo
        {
            get { return _firmaNo; }
            set { _firmaNo = value; }
        }

        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }

        public string Birim
        {
            get { return _birim; }
            set { _birim = value; }
        }

        public string Belge
        {
            get { return _belge; }
            set { _belge = value; }
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

        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }

        #endregion

        cGenel gnl = new cGenel();

        public int UrunHareketEkle(cUrunHareket uh)
        {
            int kayitNo = 0;

            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Insert into UrunHareketler(Tarih, IslemTuru, FirmaNo, UrunID, Belge, Adet, BirimFiyat, Tutar) values(@Tarih, @IslemTuru, @FirmaNo, @UrunID, @Belge, @Adet, @BirimFiyat, @Tutar); Select Scope_Identity()", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = uh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = uh._islemTuru;
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = uh._firmaNo;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = uh._urunID;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = uh._belge;
            comm.Parameters.Add("@Adet", SqlDbType.VarChar).Value = uh._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = uh._birimFiyat;
            comm.Parameters.Add("@Tutar", SqlDbType.Money).Value = uh._tutar;

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            try
            {
                kayitNo = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException e)
            {
                string hata = e.Message;
            }
            finally
            {
                conn.Close();
            }


            return kayitNo;
        }

        public void UrunHareketleriGetirByUrunID(ListView liste, int urunID)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select HareketID, Tarih, IslemTuru, FirmaNo, Unvan, Adet, BirimFiyat, Tutar, Belge, UrunID from UrunHareketler uh inner join Cariler on Cariler.CariNo=uh.FirmaNo where uh.Silindi=0 and uh.UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
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
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    liste.Items[i].SubItems.Add(dr[9].ToString());
                    i++;
                } dr.Close();
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
            }
            finally { conn.Close(); }
        }
    }
}
