using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_06StokTakibi
{
    public partial class frmCariSorgulama : Form
    {
        public frmCariSorgulama()
        {
            InitializeComponent();
        }

        cCari c = new cCari();


        private void frmCariSorgulama_Load(object sender, EventArgs e)
        {
            if (cGenel.cariTipi == "Alici")
                rbAlici.Checked = true;
            else if (cGenel.cariTipi == "Satici")
                rbSatici.Checked = true;
            else
                rbTumu.Checked = true;
        }

        private void rbAlici_CheckedChanged(object sender, EventArgs e)
        {
            cGenel.cariTipi = "Alici";
            dgvCariler.DataSource = c.CarileriGetirByCariTipi(cGenel.cariTipi);
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            cGenel.cariTipi = "Satici";
            dgvCariler.DataSource = c.CarileriGetirByCariTipi(cGenel.cariTipi);
        }

        private void rbTumu_CheckedChanged(object sender, EventArgs e)
        {
            dgvCariler.DataSource = c.CarileriGetir();
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.cariNo = Convert.ToInt32(dgvCariler.SelectedRows[0].Cells[0].Value);
            cGenel.unvan = Convert.ToString(dgvCariler.SelectedRows[0].Cells[2].Value);
            this.Close();
        }
    }
}
