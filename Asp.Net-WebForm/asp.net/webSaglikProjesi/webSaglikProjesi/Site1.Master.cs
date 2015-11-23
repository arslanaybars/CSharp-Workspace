using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var kategoriler = (from kategori in ent.Kategoriler
                                   where kategori.silindi==false
                                   select kategori).ToList();
                foreach (var ktg in kategoriler)
                {
                    MenuItem mitm = new MenuItem();
                    mitm.Text = ktg.kategoriad;
                    mitm.Value = ktg.id.ToString();
                    menuKategoriler.Items.Add(mitm);

                    var altkategoriler = (from altkategori in ent.AltKategoriler
                                          where altkategori.silindi==false && altkategori.kategorino == ktg.id
                                          select altkategori).ToList();

                    foreach (var altktg in altkategoriler)
                    {
                        MenuItem mitmalt = new MenuItem();
                        mitmalt.Text = altktg.altkategoriad.ToString();
                        mitmalt.Value = altktg.id.ToString();
                        mitm.ChildItems.Add(mitmalt);
                    }
                }



            }
        }

        protected void menuKategoriler_MenuItemClick(object sender, MenuEventArgs e)
        {
            //Response.Write("Seçilen text : " + e.Item.Text + " , value : " + e.Item.Value);
            int altkno=0;
            string[] Degerler = e.Item.ValuePath.Split('/'); //tıklanan menülerin id değerlerini veriyor. böylece hangi sekmeyi tıkladığmızı anlıyoruz
            if (Degerler.Length == 2)
                altkno = Convert.ToInt32(Degerler[1]);
            Response.Redirect("Products.aspx?kno=" + Degerler[0] + "&akno=" + altkno);
       }
    }
}