using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_12EntityOkul
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OKULEntities ent = new OKULEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                SiniflariGetir();
        }

        private void SiniflariGetir()
        {
            var classes = (from sinif
                          in ent.Siniflar
                           select sinif).ToList();

            ddlSiniflar.DataTextField = "SinifAd";
            ddlSiniflar.DataValueField = "ID";
            ddlSiniflar.DataSource = classes;
            ddlSiniflar.DataBind();
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
        }

        protected void ddlSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
        }

        private void OgrencileriGetirBySinif(int sinifNo)
        {
            var students = (from ogrenci in ent.Ogrenciler
                            where ogrenci.SinifID == sinifNo
                            select ogrenci).ToList();

            gvOgrenciler.DataSource = students;
            gvOgrenciler.DataBind();
        }

        protected void gvOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            lblOgrenciNo.Visible = true;
            lblOgrenciNo.Text = Convert.ToInt32(gvOgrenciler.SelectedValue).ToString();
            txtAdi.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[2].Text);
            txtSoyadi.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[3].Text);
            txtTelefon.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[4].Text);
            txtAdres.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[5].Text);
            txtTCKNo.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[7].Text);
            txtTSayisi.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[8].Text);
            txtTTutari.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[9].Text);
        }

        protected void lbEkle_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Temizle();
        }

        private void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtTCKNo.Text = "";
            txtTSayisi.Text = "0";
            txtTTutari.Text = "0";
            txtAdi.Focus();
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            if (lblOgrenciNo.Text.Trim() != "")
            {
                int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var ogrenci = (from ogr in ent.Ogrenciler
                               where ogr.ID == ogrenciNo
                               select ogr).First();
                ogrenci.Ad = txtAdi.Text;
                ogrenci.Soyad = txtSoyadi.Text;
                ogrenci.Telefon = txtTelefon.Text;
                ogrenci.Adres = txtAdres.Text;
                ogrenci.TCKNo = txtTCKNo.Text;
                ogrenci.TaksitSayisi = Convert.ToByte(txtTSayisi.Text);
                ogrenci.TaksitTutari = Convert.ToDecimal(txtTTutari.Text);
                ogrenci.SinifID = Convert.ToInt32(ddlSiniflar.SelectedValue);
                ent.SaveChanges();
                OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
                Temizle();
                Panel1.Visible = false;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Ad = txtAdi.Text;
            ogrenci.Soyad = txtSoyadi.Text;
            ogrenci.Telefon = txtTelefon.Text;
            ogrenci.Adres = txtAdres.Text;
            ogrenci.TCKNo = txtTCKNo.Text;
            ogrenci.TaksitSayisi = Convert.ToByte(txtTSayisi.Text);
            ogrenci.TaksitTutari = Convert.ToDecimal(txtTTutari.Text);
            ogrenci.SinifID = Convert.ToInt32(ddlSiniflar.SelectedValue);
            ent.Ogrenciler.Add(ogrenci);
            ent.SaveChanges();
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
            Temizle();
            Panel1.Visible = false;
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            if (lblOgrenciNo.Text.Trim() != "")
            {
                int ogrenciNo = Convert.ToInt32(lblOgrenciNo.Text);
                var silinen = (from ogr in ent.Ogrenciler
                               where ogr.ID == ogrenciNo
                               select ogr).First();
                ent.Ogrenciler.Remove(silinen);
                ent.SaveChanges();
                OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
                Temizle();
                Panel1.Visible = false;
            }
        }
    }
}