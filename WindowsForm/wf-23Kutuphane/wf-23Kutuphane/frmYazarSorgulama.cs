using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf_23Kutuphane
{
    public partial class frmYazarSorgulama : Form
    {
        public frmYazarSorgulama()
        {
            InitializeComponent();
        }

        private void frmYazarSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cYazar y = new cYazar();
            y.YazarlarGetir(lvYazarlar);
            
        }

        private void txtAdinaGore_TextChanged(object sender, EventArgs e)
        {
            cYazar y = new cYazar();
            y.YazarlarGetirByAdaGore(lvYazarlar, txtAdinaGore.Text);
        }
    }
}
