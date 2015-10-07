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

namespace sqlwf07_StoredProcedures
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012;Initial Catalog=VideoMarket; uid=sa; pwd=12345t");
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_MusteriEkle";
            comm.Connection = conn;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = txtMusteriAdi.Text;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = txtSoyadi.Text;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = txtTelefon.Text;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = txtAdres.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                if (Convert.ToBoolean(comm.ExecuteNonQuery()))
                    MessageBox.Show("Müşteri Eklendi");
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
    }
}
