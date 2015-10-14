using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_10EntityDataModel
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        VideoMarketEntities ent = new VideoMarketEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            var sonuc = (from m in ent.Musteriler
                        where m.Silindi == false
                        select m).ToList();

            dgvMusteriler.DataSource = sonuc;
            //dgvMusteriler.DataSource = sonuc.ToList();
        }
    }
}
