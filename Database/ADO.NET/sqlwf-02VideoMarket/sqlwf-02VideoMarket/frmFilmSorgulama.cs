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
    public partial class frmFilmSorgulama : Form
    {
        public frmFilmSorgulama()
        {
            InitializeComponent();
        }

        private void frmFilmSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(cbFilmTurleri);

            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);

            cbFilmTurleri.Items.Insert(0, "Bir Film Türü Seçiniz");
            cbFilmTurleri.SelectedIndex = 0;
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGetirByAdaGore(txtAdaGore.Text, lvFilmler);
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            if (cbFilmTurleri.SelectedItem.ToString() == "Bir Film Türü Seçiniz")
                f.FilmleriGoster(lvFilmler);
            else
                f.FilmleriGetirbyTureGore(cbFilmTurleri.SelectedItem.ToString(), lvFilmler);
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.filmNo = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
            cGenel.filmAdi = lvFilmler.SelectedItems[0].SubItems[1].Text;
            cGenel.stokMiktari = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[7].Text);
            this.Close();
        }
    }
}
