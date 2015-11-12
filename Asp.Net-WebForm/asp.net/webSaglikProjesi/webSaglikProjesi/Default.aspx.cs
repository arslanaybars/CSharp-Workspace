using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Default : System.Web.UI.Page
    {
        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                UrunleriGetir();
        }

        private void UrunleriGetir()
        {
            var products = (from urunler in ent.Urunler
                            where urunler.silindi == false
                            select urunler).ToList();

            dlstUrunler.DataSource = products;
            dlstUrunler.DataBind();
        }

        protected void dlstUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "detay")
            {
                Response.Redirect("Details.aspx?id=" + Convert.ToInt32(e.CommandArgument));
            }
            else if (e.CommandSource == "sepet")
            {

            }
        }
    }
}