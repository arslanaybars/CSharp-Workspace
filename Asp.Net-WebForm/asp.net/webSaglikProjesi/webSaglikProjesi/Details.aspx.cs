using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Details : System.Web.UI.Page
    {
        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();
        cSepet spt = new cSepet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int urunid = Convert.ToInt32(Request.QueryString["id"]);
                var uruns = (from product in ent.Urunler
                             where product.silindi == false && product.urunid == urunid
                             select product).ToList();
                dlistUrunler.DataSource = uruns;
                dlistUrunler.DataBind();

                if (Session["sepet"] != null)
                {
                    DataTable dt = (DataTable)Session["sepet"];
                    GridView ozet = (GridView)this.Master.FindControl("gvSepetOzet");
                    ozet.Columns[0].FooterText = "Toplam : ";
                    ozet.Columns[1].FooterText = string.Format("{0:c}", ToplamTutarBul());

                    ozet.DataSource = dt;
                    ozet.DataBind();
                }
            }
        }

        protected void dlistUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "detay")
            {
                Response.Redirect("Details.aspx?id=" + Convert.ToInt32(e.CommandArgument));
            }
            else if (e.CommandName == "sepet")
            {                                                       // 13.10 ******************
                dlistUrunler.EditItemIndex = e.Item.ItemIndex;
                if (Session["sepet"] == null)
                {
                    Session["sepet"] = spt.YeniSepet();

                }
                DataTable dt = (DataTable)Session["sepet"];
                DataRow dr;
                dr = dt.NewRow();
                dr["UrunID"] = Convert.ToInt32(dlistUrunler.SelectedValue);
                Label Adi = (Label)e.Item.FindControl("lblUrunAdi");
                dr["urunAd"] = Adi.Text;
                TextBox Adet = (TextBox)e.Item.FindControl("txtAdet");
                dr["Adet"] = Convert.ToInt32(Adet.Text);
                Label Fiyat = (Label)e.Item.FindControl("lblUrunFiyat");
                dr["fiyat"] = Convert.ToDecimal(Fiyat.Text);
                dr["tutar"] = Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Fiyat.Text);
                dt.Rows.Add(dr);
                Session["sepet"] = dt;
                Response.Redirect("Sepet.aspx");
            }
        }

        private int ToplamAdetBul()
        {
            int toplamAdet = 0;
            DataTable dt = (DataTable)Session["sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                toplamAdet += Convert.ToInt32(dr["Adet"]);
            }

            return toplamAdet;
        }

        private decimal ToplamTutarBul()
        {
            decimal toplamTutar = 0;
            DataTable dt = (DataTable)Session["sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                toplamTutar += Convert.ToInt32(dr["Tutar"]);
            }

            return toplamTutar;
        }
    }
}