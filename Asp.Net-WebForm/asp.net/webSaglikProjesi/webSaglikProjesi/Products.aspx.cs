using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Products : System.Web.UI.Page
    {
        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int kno = Convert.ToInt32(Request.QueryString["kno"]);
                int altkno = Convert.ToInt32(Request.QueryString["akno"]);

                if (altkno == 0)
                {
                    var products = (from urun in ent.Urunler
                                    where urun.silindi == false && urun.urunkategorino == kno
                                    select urun).ToList();

                    dlstUrunler.DataSource = products;
                    dlstUrunler.DataBind();
                }
                else
                {
                    var products = (from urun in ent.Urunler
                                    where urun.silindi == false && urun.urunkategorino == kno && urun.urunaltkategorino == altkno
                                    select urun).ToList();

                    dlstUrunler.DataSource = products;
                    dlstUrunler.DataBind();
                }
            }
        }

        protected void dlstUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}