using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    Response.Write(Session.SessionID.ToString());
                    Response.Write("Hoşgeldin, " + Session["user"].ToString());
                }
                else
                {
                    Response.Redirect("Session.aspx");
                }
            }
        }
    }
}