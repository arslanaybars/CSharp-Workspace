using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_01PostBack
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Sayfa İlk Defa Yükleniyor.");
            }
            else if (IsPostBack)
                Response.Write("Sayfa Postback Oldu.");

            this.Title = "ASP.NET Sayfalarında SEO (Search Engine Optimization) Çalışmaları";
            this.MetaDescription = "SEO çalışmalarında özgün içerik, title, description ve keywords bilgilerinin birbiriyle ve sayfa içeriğiyle ilgili olması çok önemlidir.";
            this.MetaKeywords = "SEO, Search Engine, Arama Motoru, Page Rank, özgün içerik, google'da ilk sırada çıkmak";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Merhaba " + TextBox1.Text);
        }
    }
}