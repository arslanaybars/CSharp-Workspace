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
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void frmFilmler_Load(object sender, EventArgs e)
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

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilmTuru.Text = cbFilmTurleri.SelectedItem.ToString();
            cFilmTuru ft = new cFilmTuru();
            txtTurNo.Text = Convert.ToString(ft.FilmTurNoGetirByTureGore(txtFilmTuru.Text));
            txtYonetmen.Focus();
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
            cFilm f = new cFilm();
            f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
            f.FilmAd = txtAdi.Text;
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            if (txtMiktar.Text != string.Empty)
                f.Miktar = Convert.ToInt32(txtMiktar.Text);


            if (txtAdi.Text.Trim() == string.Empty || txtYonetmen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Filmin Adını ve Yönetmenini girmek zorundasınız.", "Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (f.FilmKontrol(f))
                {
                    MessageBox.Show("Film zaten kayıtlı", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (f.FilmEkle(f))
                    {
                        MessageBox.Show("Film başarıyla kaydedildi.");
                        Temizle();
                        btnKaydet.Enabled = false;
                        f.FilmleriGoster(lvFilmler);
                    }
                }

            }
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();

            txtFilmNo.Text = lvFilmler.SelectedItems[0].SubItems[0].Text.ToString();
            txtAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
            txtTurNo.Text = lvFilmler.SelectedItems[0].SubItems[2].Text;
            txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
            txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
            txtOzet.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
            txtFilmTuru.Text = ft.FilmTuruGetirByFilmTurNo(Convert.ToInt32(txtTurNo.Text));
           

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;  
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmNo = Convert.ToInt32(txtFilmNo.Text);
            f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
            f.FilmAd = txtAdi.Text;
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            if (txtMiktar.Text != string.Empty)
                f.Miktar = Convert.ToInt32(txtMiktar.Text);

            bool sonuc = f.FilmGuncelle(f);
            if (sonuc)
            {
                MessageBox.Show("Film Türü Güncellendi");
                Temizle();
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                f.FilmleriGoster(lvFilmler);
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();

            f.FilmNo = Convert.ToInt32(txtFilmNo.Text);
            f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
            f.FilmAd = txtAdi.Text;
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            if (txtMiktar.Text != string.Empty)
                f.Miktar = Convert.ToInt32(txtMiktar.Text);

            if ((MessageBox.Show("Silmek istiyor musunuz ?", "Silinsin Mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                bool sonuc = f.FilmSil(f);

                if (sonuc)
                {
                    MessageBox.Show("Film Türü Silindi");
                    Temizle();
                    btnSil.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = false;
                    f.FilmleriGoster(lvFilmler);
                }           
            }
            else
            {

            }
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGetirByAdaGore(txtAdaGore.Text, lvFilmler);
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtTurNo.Clear();
            txtOzet.Clear();
            txtMiktar.Clear();
            txtFilmNo.Clear();
            txtFilmTuru.Clear();
            cbFilmTurleri.SelectedIndex = 0;
            txtAdi.Focus();
        }

    }
}
