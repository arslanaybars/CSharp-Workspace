using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wcf_05WebService
{
    /// <summary>
    /// Summary description for WSFilmler
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSFilmler : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog = VideoMarket; uid=sa; pwd = 12345t");
        DataSet ds = new DataSet();

        [WebMethod]
        public DataSet FilmleriGetir(string filmTuru)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select FilmAd, Yonetmen, Oyuncular, Miktar from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo where TurAd = @TurAd and varmi = 1", conn);
            da.SelectCommand.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = filmTuru;
            da.Fill(ds, "Filmler");
            return ds;
        }
    }
}
