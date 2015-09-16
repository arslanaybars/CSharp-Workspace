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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormAcikMi(Form AcilacakForum)
        {
            bool acikMi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForum.Name == MdiChildren[i].Name)
                {
                    MdiChildren[i].Focus();
                    acikMi = true;
                }
            }

            if (acikMi == false)
            {
                AcilacakForum.MdiParent = this;
                AcilacakForum.Show();
            }
            else
            {
                AcilacakForum.Dispose(); //Yeni açılan pencere nesnesi hafızadan atılır. Bu işlemi biz yapmasak da garbage collector takip edecektir.
            }
        }

        private void mItemCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mItemFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTurleri frm = new frmFilmTurleri();
            FormAcikMi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mItemMusteriGirisi_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            FormAcikMi(frm);
        }

        private void mItemFilmTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmler frm = new frmFilmler();
            FormAcikMi(frm);
        }

        private void mItemMusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            FormAcikMi(frm);
        }

        private void mItemFilmSorgulama_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            FormAcikMi(frm);
        }

        private void mItemFilmSatis_Click(object sender, EventArgs e)
        {
            frmFilmSatis frm = new frmFilmSatis();
            FormAcikMi(frm);
        }

        private void mItemSatisSorgulama_Click(object sender, EventArgs e)
        {
            frmSatisSorgulama frm = new frmSatisSorgulama();
            FormAcikMi(frm);
        }
    }
}
