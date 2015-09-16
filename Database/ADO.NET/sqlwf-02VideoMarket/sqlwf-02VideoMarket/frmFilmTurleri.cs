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
    public partial class frmFilmTurleri : Form
    {
        public frmFilmTurleri()
        {
            InitializeComponent();
        }

        private void frmFilmTurleri_Load(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(lvTurler);
            this.Top = 0;
            this.Left = 0;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();
            if (txtFilmTuru.Text.Trim() != string.Empty)
            {
                if (ft.FilmTuruKontrol(txtFilmTuru.Text))
                    MessageBox.Show("Daha önceden kayıtlı!");
                else
                {
                    bool sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    if (sonuc)
                    {
                        MessageBox.Show("Film Türü Kayıt Edildi");
                        Temizle();
                        btnKaydet.Enabled = false;
                        ft.FilmTurleriGoster(lvTurler);
                    }
                }
            }
            else
                MessageBox.Show("Film Türü Boş Bırakılamaz");

        }

        private void lvTurler_DoubleClick(object sender, EventArgs e)
        {
            //btnSil.Enabled = true;
            //btnDegistir.Enabled = true;
            txtTurNo.Text = lvTurler.SelectedItems[0].SubItems[0].Text.ToString();
            txtFilmTuru.Text = lvTurler.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvTurler.SelectedItems[0].SubItems[2].Text;

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;   
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();
            //bool sonuc = ft.FilmTuruGuncelle(Convert.ToInt32(txtTurNo.Text), txtFilmTuru.Text, txtAciklama.Text);
            ft.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
            ft.TurAd = txtFilmTuru.Text;
            ft.Aciklama = txtAciklama.Text;

            bool sonuc = ft.FilmTuruGuncelle(ft);
            if (sonuc)
            {
                MessageBox.Show("Film Türü Güncellendi");
                Temizle();
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                ft.FilmTurleriGoster(lvTurler);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();

            ft.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
            ft.TurAd = txtFilmTuru.Text;
            ft.Aciklama = txtAciklama.Text;

            if ((MessageBox.Show("Silmek istiyor musunuz ?", "Silinsin Mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                bool sonuc = ft.FilmTuruSil(ft);
                //bool sonuc = ft.FilmTuruSil(Convert.ToInt32(txtTurNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Film Türü Silindi");
                    Temizle();
                    btnSil.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = false;
                    ft.FilmTurleriGoster(lvTurler);
                }
            }
            else
            {

            }
        }

        private void Temizle()
        {
            txtTurNo.Clear();
            txtFilmTuru.Clear();
            txtAciklama.Clear();
            txtFilmTuru.Focus();
        }
    }
}
