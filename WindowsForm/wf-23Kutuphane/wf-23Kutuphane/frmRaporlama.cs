using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_23Kutuphane
{
    public partial class frmRaporlama : Form
    {
        public frmRaporlama()
        {
            InitializeComponent();
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cKitapTuru kt = new cKitapTuru();
            kt.KitapTurleriGetir(cbKitapTurleri);
            cbKitapTurleri.SelectedIndex = 0;

            cYazar y = new cYazar();
            y.YazarlarGetir(cbYazarlar);
            cbYazarlar.SelectedIndex = 0;

            cYayinEvi yevi = new cYayinEvi();
            yevi.YayinEvleriniGetir(cbYayinEvleri);
            cbYayinEvleri.SelectedIndex = 0;
        }
    }
}
