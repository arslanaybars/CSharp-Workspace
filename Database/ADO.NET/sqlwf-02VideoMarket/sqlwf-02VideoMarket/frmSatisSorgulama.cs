using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_02VideoMarket
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            cFilmSatis fs = new cFilmSatis();

            dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvSatislar.DataSource = dt;

            dgvSatislar.Columns["SatisNo"].Width = 50;
            dgvSatislar.Columns["Adet"].Width = 58;
            dgvSatislar.Columns["SatisNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].Width = 75;


            decimal tutarSum = 0;
            int adetSum = 0;
            //for (int i = 0; i < dgvSatislar.Rows.Count; ++i)
            //{
            //    tutarSum += Convert.ToDecimal(dgvSatislar.Rows[i].Cells["Tutar"].Value);
            //    adetSum += Convert.ToInt32(dgvSatislar.Rows[i].Cells["Adet"].Value);
            //}

            foreach (DataRow dr in dt.Rows)
            {
                adetSum += Convert.ToInt32(dr["Adet"]);
                tutarSum += Convert.ToDecimal(dr["Tutar"]);
            }

            txtToplamTutar.Text = string.Format("{0:C}", tutarSum);
            txtToplamAdet.Text = adetSum.ToString();


        }
    }
}
