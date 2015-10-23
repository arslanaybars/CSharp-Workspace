using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(ViewState["state"].ToString()); - ViewState(stateback) değişkenleri sadece tanımlandıkları sayfada kullanılabilirler.
            string durum = Request.QueryString["state"];
            string kullanici = Request.QueryString["user"];
            Response.Write(kullanici + " kullanıcısının durumu = " + durum);
        }
    }
}