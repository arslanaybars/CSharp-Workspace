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
    public partial class frmYayinEviSorgulama : Form
    {
        public frmYayinEviSorgulama()
        {
            InitializeComponent();
        }

        private void YayinEviSorgulama_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            cYayinEvi y = new cYayinEvi();
            y.YayinEvleriniGetir(lvYayinEvleri);

        }

        private void txtUnvanaGore_TextChanged(object sender, EventArgs e)
        {
            cYayinEvi y = new cYayinEvi();
            y.YayinEvleriniGetirByAdaGore(txtUnvanaGore.Text, lvYayinEvleri);
        }
    }
}
