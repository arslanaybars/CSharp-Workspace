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
                KategorileriGetir();
            }
        }

        private void KategorileriGetir()
        {
            var categories = from category in ent.Kategoriler
                             where category.silindi == false
                             select new { category.id, category.kategoriad };

            var subCategories = from subCategory in ent.AltKategoriler
                                where subCategory.silindi == false
                                select new { subCategory.id, subCategory.altkategoriad, subCategory.kategorino };

            foreach (var kategori in categories)
            {
                MenuItem mitm = new MenuItem();
                mitm.Text = kategori.kategoriad;
                mitm.Value = Convert.ToString(kategori.id);
                //mitm.NavigateUrl = "~/Database.aspx";
                mnuKategoriler.Items.Add(mitm);
                foreach (var altKategori in subCategories)
                {
                    if (kategori.id == altKategori.kategorino)
                    {
                        MenuItem citm = new MenuItem();
                        citm.Text = altKategori.altkategoriad;
                        citm.Value = Convert.ToString(altKategori.id);
                        //citm1.NavigateUrl = "~/MYSQL.aspx";
                        mitm.ChildItems.Add(citm);
                    }
                }
            }
        }

        protected void mnuKategoriler_MenuItemClick(object sender, MenuEventArgs e)
        {
            //Response.Write("Seçilen text : " + e.Item.Text + ", Value : " + e.Item.Value);
            int altkno = 0;
            string[] Degerler = e.Item.ValuePath.Split('/');
            if (Degerler.Length == 2)
                altkno = Convert.ToInt32(Degerler[1]);

            Response.Redirect("Products.aspx?kno=" + Degerler[0] + "&akno=" + altkno);
        }
    }
}