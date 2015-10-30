using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_06DataList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog = Stok; uid=sa; pwd=12345t");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                DataBagla();
        }

        private void DataBagla()
        {
            SqlCommand comm = new SqlCommand("Select * from Kategoriler where silindi = 0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                dlstKategoriler.DataSource = dr;
                //DataBind -> DataBind() metodu verileri veri kaynağından okuyup kontrolü tekrar oluşturur.
                dlstKategoriler.DataBind();
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

        protected void dlstKategoriler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                //Response.Write("Değiştir Butonuna tıklandı !");
                dlstKategoriler.EditItemIndex = e.Item.ItemIndex;
                DataBagla();
            }
            else if (e.CommandName == "delete")
            {
                //Response.Write("Sil Butonuna tıklandı !");
                int id = Convert.ToInt32(e.CommandArgument);
            }
            else if (e.CommandName == "cancel")
            {
                dlstKategoriler.EditItemIndex = -1;
                DataBagla();
            }
            else if (e.CommandName == "update")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                // Hata fırlatıyo
                TextBox KategoriAdi = (TextBox)e.Item.FindControl("txtKategoriAdi");
                // Hata fırlatmıyo
                TextBox Aciklama = e.Item.FindControl("txtAciklama") as TextBox;

                bool sonuc = kategoriGuncelle(KategoriAdi.Text, Aciklama.Text, id);

                if (sonuc)
                {
                    dlstKategoriler.EditItemIndex = -1;
                    DataBagla();
                }
            }
        }

        private bool kategoriGuncelle(string kategoriAdi, string aciklama, int id)
        {
            bool sonuc = false;

            

            return sonuc;
        }
    }
}