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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mItemCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mItmUrunKarlari_Click(object sender, EventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            FormAcikMi(frm);
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

    }
}
