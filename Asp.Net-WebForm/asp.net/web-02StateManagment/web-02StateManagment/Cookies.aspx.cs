using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ddlMarkalar.SelectedIndex = 0;
        }

        protected void ddlMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(ddlMarkalar.SelectedItem.ToString());

            // Non Persistent Cookies(Kalıcı olmayan cookie'ler).
            Response.Cookies["marka"].Value = ddlMarkalar.SelectedItem.ToString();

            //Persistent Cookies(Kalıcı Çerez).
            Response.Cookies["marka"].Expires = DateTime.Now.AddDays(3);

            HttpCookie user = new HttpCookie("kullanici");
            user.Value = "Admin";
            user.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(user);

            Response.Cookies["Satis"]["user1"] = "Hasan";
            Response.Cookies["Satis"]["user2"] = "Nese";
            Response.Cookies["Satis"].Expires = DateTime.Now.AddMonths(1);

            Response.Redirect("WebForm3.aspx");
        }
    }
}