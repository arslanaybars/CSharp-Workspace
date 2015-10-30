using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_05HaberPortal
{
    public partial class Haberler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog = HaberPortal; uid=sa; pwd=12345t");
                SqlCommand comm = new SqlCommand("Select * from Haberler where aktif=1", conn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataReader dr = comm.ExecuteReader();

                try
                {
                        Repeater1.DataSource = dr;
                        //DataBind -> DataBind() metodu verileri veri kaynağından okuyup kontrolü tekrar oluşturur.
                        Repeater1.DataBind();
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
        }
    }
}