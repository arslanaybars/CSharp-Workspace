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
    public partial class KategoriEkle : System.Web.UI.Page
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
                }
            }
        }

        private void KategoriGetir()
        {
            var categories = (from kategori in ent.Kategoriler
                              where kategori.silindi == false
                              select kategori).ToList();

            gvKategoriler.DataSource = categories;
            gvKategoriler.DataBind();
        }

        protected void gvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            txtKategoriAdi.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[2].Text);
        }

        protected void btnYeni_Click(object sender, EventArgs e)
        {
            gvKategoriler.SelectedIndex = -1; // gridview'deki seçimi kaldırıyor.
            pnlGiris.Visible = true;
            Temizle();
            txtKategoriAdi.Focus();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() != "")
            {
                Kategoriler kategori = new Kategoriler();
                kategori.kategoriad = txtKategoriAdi.Text;
                kategori.aciklama = txtAciklama.Text;

                ent.Kategoriler.Add(kategori);
                ent.SaveChanges();
                Temizle();
                KategoriGetir();
            }
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            int kategoriNo = Convert.ToInt32(gvKategoriler.SelectedValue);
            if (kategoriNo > 0)
            {
                //int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var degisen = (from category in ent.Kategoriler
                                where category.id == kategoriNo
                                select category).First();

                degisen.kategoriad = txtKategoriAdi.Text;
                degisen.aciklama = txtAciklama.Text;

                try
                {
                    ent.SaveChanges();
                    KategoriGetir();
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
            int kategoriNo = Convert.ToInt32(gvKategoriler.SelectedValue);
            if (kategoriNo > 0)
            {
                //int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var silinen = (from category in ent.Kategoriler
                               where category.id == kategoriNo
                               select category).First();

                silinen.silindi = true;

                try
                {
                    //ent.Kategoriler.Remove(silinen);
                    ent.SaveChanges();
                    KategoriGetir();
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
            txtKategoriAdi.Text = "";
            txtAciklama.Text = "";
        }
    }
}