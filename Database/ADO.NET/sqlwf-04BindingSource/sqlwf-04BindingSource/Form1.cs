using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_04BindingSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoMarketDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.videoMarketDataSet.Musteriler);
            Konum();
        }

        private void Konum()
        {
            lblKonum.Text = (bs1.Position + 1) + " / " + bs1.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //bs1.MoveFirst();
            bs1.Position = 0;
            Konum();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //bs1.MovePrevious();
            bs1.Position -= 1;
            Konum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //bs1.MoveNext();
            bs1.Position += 1;
            Konum();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //bs1.MoveLast();
            bs1.Position = bs1.Count;
            Konum();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            bs1.AddNew();
            txtAdi.Focus();
            Konum();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bs1.EndEdit();
            this.musterilerTableAdapter.Update(this.videoMarketDataSet.Musteriler);
            Konum();
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Konum();
        }
    }
}
