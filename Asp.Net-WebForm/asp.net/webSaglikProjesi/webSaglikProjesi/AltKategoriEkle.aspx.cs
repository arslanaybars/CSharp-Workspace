using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class AltKategoriEkle : System.Web.UI.Page
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
                }
            }
        }

        protected void gvAltKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            txtAltKategoriAdi.Text = HttpUtility.HtmlDecode(gvAltKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvAltKategoriler.SelectedRow.Cells[2].Text);
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

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategoriGetir();
        }

        private void AltKategoriGetir()
        {
            int kNo = Convert.ToInt32(ddlKategoriler.SelectedValue);
            var subcategories = (from subcategory in ent.AltKategoriler
                                 where subcategory.kategorino == kNo && subcategory.silindi == false
                                 select subcategory).ToList();

            gvAltKategoriler.DataSource = subcategories;
            gvAltKategoriler.DataBind();
        }

        protected void btnYeni_Click(object sender, EventArgs e)
        {
            gvAltKategoriler.SelectedIndex = -1; // gridview'deki seçimi kaldırıyor.
            pnlGiris.Visible = true;
            Temizle();
            txtAltKategoriAdi.Focus();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAltKategoriAdi.Text.Trim() != "")
            {
                AltKategoriler altkategori = new AltKategoriler();
                altkategori.altkategoriad = txtAltKategoriAdi.Text;
                altkategori.aciklama = txtAciklama.Text;
                altkategori.kategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);

                ent.AltKategoriler.Add(altkategori);
                ent.SaveChanges();
                Temizle();
                AltKategoriGetir();
            }
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            int altNo = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            if (altNo > 0)
            {
                //int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var degisen = (from subcategory in ent.AltKategoriler
                               where subcategory.id == altNo
                               select subcategory).First();

                degisen.altkategoriad = txtAltKategoriAdi.Text;
                degisen.aciklama = txtAciklama.Text;
                degisen.kategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);

                try
                {
                    ent.SaveChanges();
                    AltKategoriGetir();
                    Temizle();
                    pnlGiris.Visible = false;
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }

            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int altNo = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            if (altNo > 0)
            {
                //int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var silinen = (from subcategory in ent.AltKategoriler
                               where subcategory.id == altNo
                               select subcategory).First();

                silinen.silindi = true;

                try
                {
                    //ent.Kategoriler.Remove(silinen);
                    ent.SaveChanges();
                    AltKategoriGetir();
                    Temizle();
                    pnlGiris.Visible = false;
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
            }
        }

        private void Temizle()
        {
            txtAltKategoriAdi.Text = "";
            txtAciklama.Text = "";
        }
    }
}