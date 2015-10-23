using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_02StateManagment
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "999")
            {
                Session["user"] = txtUsername.Text;
                Response.Redirect("WebForm4.aspx");
            }
            else
            {
                Response.Write("Yanlış Kullanıcı adı veya şifre girişi!");
                txtUsername.Focus();
            }
        }
    }
}