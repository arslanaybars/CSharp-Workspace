using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlwf_06StokTakibi
{
    class cCari
    {
        private int _cariNo;
        private string _cariTip;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _sehir;
        private string _vergiNo;
        private string _vergiDairesi;
        private decimal _toplamBorc;
        private decimal _toplamAlacak;
        private decimal _bakiye;

        #region Properties
        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }

        public string CariTip
        {
            get { return _cariTip; }
            set { _cariTip = value; }
        }

        public string Unvan
        {
            get { return _unvan; }
            set { _unvan = value; }
        }

        public string Yetkili
        {
            get { return _yetkili; }
            set { _yetkili = value; }
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

        public string Sehir
        {
            get { return _sehir; }
            set { _sehir = value; }
        }

        public string VergiNo
        {
            get { return _vergiNo; }
            set { _vergiNo = value; }
        }

        public string VergiDairesi
        {
            get { return _vergiDairesi; }
            set { _vergiDairesi = value; }
        }

        public decimal ToplamBorc
        {
            get { return _toplamBorc; }
            set { _toplamBorc = value; }
        }

        public decimal ToplamAlacak
        {
            get { return _toplamAlacak; }
            set { _toplamAlacak = value; }
        }

        public decimal Bakiye
        {
            get { return _bakiye; }
            set { _bakiye = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();
        

        public DataTable CarileriGetir()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * From Cariler where Silindi = 0", conn);

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public DataTable CarileriGetirByCariTipi(string cariTipi)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * From Cariler where Silindi = 0 and CariTipi = @CariTipi", conn);
            da.SelectCommand.Parameters.Add("@CariTipi", SqlDbType.VarChar).Value = cariTipi;

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
    }
}
