using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WSFilmler.WSFilmler servis = new WSFilmler.WSFilmler();

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = servis.FilmleriGetir(cbFilmTurleri.SelectedItem.ToString());
            dgvFilmler.DataSource = ds.Tables[0];
        }

    }
}
