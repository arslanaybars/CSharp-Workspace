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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection("Data Source=WISSEN245\\MSSQL2012; Initial Catalog=VideoMarket; uid=sa; pwd=12345t");

            SqlDataAdapter da = new SqlDataAdapter("Select * from vw_DetayliSatis", conn);

            da.Fill(dt);

            dgvSatislar.DataSource = dt;
        }
    }
}
