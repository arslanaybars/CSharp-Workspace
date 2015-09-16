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

namespace sqlwf_03WindowsFormDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");

            SqlDataAdapter da = new SqlDataAdapter("Select * From Filmler where Varmi = 1", conn);

            //da.Fill(ds, "Filmler");
            da.Fill(dt);
            //dgvFilmler.DataSource = ds.Tables["Filmler"];
            dgvFilmler.DataSource = dt;
        }
    }
}
