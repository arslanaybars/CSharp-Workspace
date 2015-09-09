using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_01AdoNet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = WISSEN245\\MSSQL2012; Initial Catalog=OKUL; uid=sa; pwd=12345t");

        private void Form4_Load(object sender, EventArgs e)
        {
            OgretmenleriGetir();
            txtAdi.Focus();
        }

        private void OgretmenleriGetir()
        {
            SqlCommand comm = new SqlCommand("select Ad, Soyad from Ogretmenler", conn);
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                lbOgretmenler.Items.Add(dr[0].ToString() + " " + dr[1].ToString());
            }
            dr.Close();
            conn.Close();
            //lbOgretmenler.Items.Add
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lbOgretmenler.Items.Clear();
            OgretmenKaydet();
            TextboxTemizle();
            OgretmenleriGetir();
        }

        private void OgretmenKaydet()
        {
            SqlCommand comm = new SqlCommand("Insert into Ogretmenler(Ad, Soyad, Telefon, Brans) values(@Ad, @Soyad, @Telefon, @Brans)", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = txtAdi.Text.Trim();
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = txtSoyadi.Text.Trim();
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = txtTelefon.Text.Trim();
            comm.Parameters.Add("@Brans", SqlDbType.VarChar).Value = txtBrans.Text.Trim();

            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            if (sonuc)
                MessageBox.Show("Ögretmenler bilgileri eklendi");
            else
                MessageBox.Show("Kayıt yapılmadı!");

            conn.Close();
        }

        private void TextboxTemizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtBrans.Clear();
            txtTelefon.Clear();
        }


    }
}
