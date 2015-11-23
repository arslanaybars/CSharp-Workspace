using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUsername.Focus();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "9999")
            {
                Session["Admin"] = txtUsername.Text;
                Response.Redirect("Admin.aspx");
            }
            else
            {
                lblMesaj.Text = "Yanlış şifre girişi...";
                txtUsername.Focus();
            }
        }
    }
}