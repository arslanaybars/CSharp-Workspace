using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Sepet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sepet"] != null)
                {
                    DataTable dt = (DataTable)Session["sepet"];
                    SepetGoster(dt);
                }
                else
                {
                    DataTable dt = new DataTable();
                    gvSepet.DataSource = dt;
                    gvSepet.DataBind();
                }
            }
        }

        private void SepetGoster(DataTable dt)
        {
            gvSepet.Columns[1].FooterText = "Toplam : ";
            gvSepet.Columns[2].FooterStyle.HorizontalAlign = HorizontalAlign.Right;
            gvSepet.Columns[2].FooterText = Convert.ToString(ToplamAdetBul());
            gvSepet.Columns[2].FooterStyle.HorizontalAlign = HorizontalAlign.Center;
            gvSepet.Columns[3].FooterText = string.Format("{0:c}", ToplamTutarBul());
            gvSepet.Columns[3].FooterStyle.HorizontalAlign = HorizontalAlign.Right;

            gvSepet.DataSource = dt;
            gvSepet.DataBind();
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



        protected void btnDevam_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (Session["sepet"] != null)
            {
                DataTable dt = (DataTable)Session["sepet"];
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("Adres.aspx");
                }
            }
            Response.Redirect("Default.aspx");
        }

        protected void btnBosalt_Click(object sender, EventArgs e)
        {
            if (Session["sepet"] != null)
            {
                DataTable dt = (DataTable)Session["sepet"];
                dt.Clear();
                Session["sepet"] = dt;
                Response.Redirect("Default.aspx");
            }
        }

        protected void gvSepet_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = (DataTable)Session["sepet"];
            dt.Rows.RemoveAt(e.RowIndex);
            SepetGoster(dt);
        }
    }
}