using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["state"] = "Aktif";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(ViewState["state"].ToString());
            Response.Redirect("WebForm2.aspx?state=Aktif&user=" + TextBox1.Text);
        }
    }
}