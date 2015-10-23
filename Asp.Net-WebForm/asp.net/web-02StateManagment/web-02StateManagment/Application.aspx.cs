using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["uygulama"] = "çalışıyor";
            //Application.Add("uygulama", "çalışıyor");

            Response.Write("online ziyaretci sayisi : " + Application["onlineZiyaretci"].ToString());
        }
    }
}