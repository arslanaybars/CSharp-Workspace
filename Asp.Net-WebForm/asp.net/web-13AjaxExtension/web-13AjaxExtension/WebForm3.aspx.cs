using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_13AjaxExtension
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetir_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);

            SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Filmler where varmi = 1", conn);
            da.Fill(dt);

            gvFilmler.DataSource = dt;
            gvFilmler.DataBind();
        }
    }
}