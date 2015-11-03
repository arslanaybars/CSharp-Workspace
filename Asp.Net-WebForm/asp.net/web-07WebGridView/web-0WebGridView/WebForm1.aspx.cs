using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_0WebGridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog = VideoMarket; uid=sa; pwd=12345t");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBagla();
            }
        }

        private void DataBagla()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MusteriNo, MusteriAd, MusteriSoyad, Telefon, Adres from Musteriler where silindi = 0", conn);

            try
            {
                da.Fill(dt);
                gvMusteriler.DataSource = dt;
                gvMusteriler.DataBind();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void gvMusteriler_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMusteriler.EditIndex = e.NewEditIndex;
            DataBagla();
        }

        protected void gvMusteriler_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMusteriler.EditIndex = -1;
            DataBagla();
        }

        protected void gvMusteriler_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int ID = Convert.ToInt32(gvMusteriler.DataKeys[e.RowIndex].Value);
            TextBox Adi = (TextBox)gvMusteriler.Rows[e.RowIndex].FindControl("txtAdi");
            TextBox Soyadi = (TextBox)gvMusteriler.Rows[e.RowIndex].FindControl("txtSoyadi");
            TextBox Telefon = (TextBox)gvMusteriler.Rows[e.RowIndex].FindControl("txtTelefon");
            TextBox Adres = (TextBox)gvMusteriler.Rows[e.RowIndex].FindControl("txtAdres");

            bool sonuc = MusteriGuncelle(Adi.Text, Soyadi.Text, Telefon.Text, Adres.Text, ID);

            if (sonuc)
            {
                gvMusteriler.EditIndex = -1;
                DataBagla();
            }
        }

        private bool MusteriGuncelle(string adi, string soyadi, string telefon, string adres, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Musteriler Set MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, Telefon=@Telefon, Adres=@Adres where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = adi;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = adres;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = ID;


            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return sonuc;
        }

        protected void gvMusteriler_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(gvMusteriler.DataKeys[e.RowIndex].Value);

            if (MusteriSil(ID))
            {
                gvMusteriler.EditIndex = -1;
                DataBagla();
            }
        }

        private bool MusteriSil(int ID)
        {
            bool sonuc = false;

            SqlCommand comm = new SqlCommand("Update Musteriler Set Silindi=1 where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = ID;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return sonuc;
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            gvMusteriler.ShowFooter = true;
            DataBagla();
        }

        protected void gvMusteriler_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Save")
            {
                TextBox Adi = (TextBox)gvMusteriler.FooterRow.FindControl("txtYeniAd");
                TextBox Soyadi = (TextBox)gvMusteriler.FooterRow.FindControl("txtYeniSoyad");
                TextBox Telefon = (TextBox)gvMusteriler.FooterRow.FindControl("txtYeniTelefon");
                TextBox Adres = (TextBox)gvMusteriler.FooterRow.FindControl("txtYeniAdres");

                bool sonuc = MusteriEkle(Adi.Text, Soyadi.Text, Telefon.Text, Adres.Text);

                if (sonuc)
                {
                    gvMusteriler.ShowFooter = false;
                    DataBagla();
                }
            }
            else if (e.CommandName == "Vazgec")
            {
                gvMusteriler.ShowFooter = false;
                DataBagla();
            }
        }

        private bool MusteriEkle(string adi, string soyadi, string telefon, string adres)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert Into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) Values (@MusteriAd, @MusteriSoyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = adi;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = adres;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return sonuc;
        }
    }
}