using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_29GenericList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            List<cMusteri> liste = m.MusterileriGetir();

            dgvMusteriler.DataSource = liste;
        }
    }
}
