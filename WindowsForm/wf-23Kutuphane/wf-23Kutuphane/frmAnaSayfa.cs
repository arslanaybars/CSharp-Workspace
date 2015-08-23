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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mItmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mItmKitapTuru_Click(object sender, EventArgs e)
        {
            frmKitapTurleri frm = new frmKitapTurleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmYazarTanimlama_Click(object sender, EventArgs e)
        {
            frmYazarlar frm = new frmYazarlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmYazarSorgulama_Click(object sender, EventArgs e)
        {
            frmYazarSorgulama frm = new frmYazarSorgulama();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmYayineviTanimlama_Click(object sender, EventArgs e)
        {
            frmYayinEvleri frm = new frmYayinEvleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmYayıneviSorgulama_Click(object sender, EventArgs e)
        {
            frmYayinEviSorgulama frm = new frmYayinEviSorgulama();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmKitapTanimlama_Click(object sender, EventArgs e)
        {
            frmKitaplar frm = new frmKitaplar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mItmKitapSorgulama_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
