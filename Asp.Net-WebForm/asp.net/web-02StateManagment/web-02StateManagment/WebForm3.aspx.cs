using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Browser.Cookies)
            {
                Response.Write("Favori Markanız : " + Request.Cookies["marka"].Value);

                Response.Write("Kullanici : " + Request.Cookies["kullanici"].Value);

                Response.Write("Satış Departmanı - Kullanıcı -1- " + Request.Cookies["Satis"]["user1"] + "Satış Departmanı - Kullanıcı -2- " + Request.Cookies["Satis"]["user2"]);
            }
        }
    }
}