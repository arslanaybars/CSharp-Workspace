using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webSaglikProjesi
{
    public partial class UrunEkle : System.Web.UI.Page
    {

        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] == null)
                    Response.Redirect("Admin.aspx");
                else
                {
                    KategoriGetir();
                    AltKategoriGetir();
                    UrunleriGetir();
                }
            }
        }

        private void KategoriGetir()
        {
            var categories = (from kategori in ent.Kategoriler
                              where kategori.silindi == false
                              select kategori).ToList();
            ddlKategoriler.DataTextField = "kategoriad";
            ddlKategoriler.DataValueField = "id";
            ddlKategoriler.DataSource = categories;
            ddlKategoriler.DataBind();
        }

        private void AltKategoriGetir()
        {
            int kNo = Convert.ToInt32(ddlKategoriler.SelectedValue);
            var subcategories = (from subcategory in ent.AltKategoriler
                                 where subcategory.kategorino == kNo && subcategory.silindi == false
                                 select subcategory).ToList();

            ddlAltKategoriler.DataTextField = "altkategoriad";
            ddlAltKategoriler.DataValueField = "id";
            ddlAltKategoriler.DataSource = subcategories;
            ddlAltKategoriler.DataBind();
        }

        private void UrunleriGetir()
        {
            int kNo = Convert.ToInt32(ddlKategoriler.SelectedValue);
            int altKNo = Convert.ToInt32(ddlAltKategoriler.SelectedValue);
            var products = (from subcategory in ent.Urunler
                            where subcategory.urunkategorino == kNo && subcategory.urunaltkategorino == altKNo && subcategory.silindi == false
                            select subcategory).ToList();

            gvUrunler.DataSource = products;
            gvUrunler.DataBind();
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategoriGetir();
        }

        protected void ddlAltKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtUrunKodu.Text.Trim() != "" && txtUrunKodu.Text.Trim() != "")
            if (fuResim1.HasFile)
            {
                //Kullanıcının seçtiği resim dosyaları, projenin bulunduğu klasör altına toplanır.
                fuResim1.SaveAs(Server.MapPath("~/images/" + fuResim1.FileName));
            }

            if (fuResim2.HasFile)
            {
                fuResim2.SaveAs(Server.MapPath("~/images/buyuk/" + fuResim2.FileName));
            }

            Urunler urun = new Urunler();
            urun.urunkodu = txtUrunKodu.Text;
            urun.urunad = txtUrunAdi.Text;
            urun.urunbilgisi = txtUrunBilgisi.Text;
            urun.miktar = Convert.ToInt32(txtMiktar.Text);
            urun.urunfiyat = Convert.ToDecimal(txtFiyat.Text);
            urun.urunkategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);
            urun.urunaltkategorino = Convert.ToInt32(ddlAltKategoriler.SelectedValue);
            urun.resimyolu1 = "images/" + (fuResim1.FileName);
            urun.resimyolu2 = "images/buyuk/" + (fuResim2.FileName);

            ent.Urunler.Add(urun);

            try
            {
                ent.SaveChanges();
                pnlGiris.Visible = false;
                UrunleriGetir();
                Temizle();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        private void Temizle()
        {
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunBilgisi.Text = "";
            txtMiktar.Text = "1";
            txtFiyat.Text = "0";
            fuResim1.Controls.Clear();
            fuResim2.Controls.Clear();
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {

        }

        protected void btnYeni_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
        }
    }
}