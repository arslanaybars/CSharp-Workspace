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
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }

        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            txtTarih.Text = DateTime.Now.ToShortDateString();

            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAdet.Enabled = true;
            txtFiyat.Enabled = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtAdet.Text.Trim() == string.Empty)
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, 2);
            }
            if (txtFiyat.Text.Trim() == string.Empty)
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, 2);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtAdet.Text.Trim() == string.Empty)
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, 2);
            }
            if (txtFiyat.Text.Trim() == string.Empty)
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, 2);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.ShowDialog();

            txtMusteriNo.Text = cGenel.musteriNo.ToString();
            txtMusteri.Text = cGenel.musteri;
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            frm.ShowDialog();

            txtFilmNo.Text = cGenel.filmNo.ToString();
            txtFilm.Text = cGenel.filmAdi;
            txtStok.Text = cGenel.stokMiktari.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            //f.Miktar = Convert.ToInt32(txtAdet.Text);
            //f.FilmNo = Convert.ToInt32(txtFilmNo.Text);

            cFilmSatis fs = new cFilmSatis();
            fs.Tarih = Convert.ToDateTime(txtTarih.Text);
            fs.FilmNo = Convert.ToInt32(txtFilmNo.Text);
            fs.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
            fs.Adet = Convert.ToInt32(txtAdet.Text);
            fs.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);

            if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
            {
                MessageBox.Show("Stokta yeterli miktarda bulunmamaktadır." + "en fazla " + txtStok.Text + " adet satış yapabilirsiniz." );
                txtAdet.Text = txtStok.Text;
                txtAdet.Focus();
            }
            else
            {
                if (txtFilmNo.Text.Trim() != string.Empty && txtMusteriNo.Text.Trim() != string.Empty)
                {
                    if (fs.FilmSatisEkle(fs))
                    {
                        MessageBox.Show("Satış Bilgileri Kayıt Edildi");
                        if (f.FilmStokGuncelleFromSatisEkle(fs.FilmNo, fs.Adet))
                        {

                            fs.SatislariGetir(lvSatislar, txtAdet, txtTutar);
                            MessageBox.Show("Stok miktarı güncellendi");
                            btnKaydet.Enabled = false;
                        }
                        Temizle();
                    }
                }
                else
                    MessageBox.Show("Müşteri ve Film Bilgileri Boş Bırakılmamaıdır.");
            }
        }

        private void lvSatislar_DoubleClick(object sender, EventArgs e)
        {
            txtSatisNo.Text = lvSatislar.SelectedItems[0].SubItems[0].Text;
            txtTarih.Text = lvSatislar.SelectedItems[0].SubItems[1].Text;
            txtFilmNo.Text = lvSatislar.SelectedItems[0].SubItems[2].Text;
            txtFilm.Text = lvSatislar.SelectedItems[0].SubItems[3].Text;
            txtMusteriNo.Text = lvSatislar.SelectedItems[0].SubItems[5].Text;
            txtMusteri.Text = lvSatislar.SelectedItems[0].SubItems[6].Text;
            txtFiyat.Text = lvSatislar.SelectedItems[0].SubItems[7].Text;
            txtAdet.Text = lvSatislar.SelectedItems[0].SubItems[8].Text;
            txtTutar.Text = lvSatislar.SelectedItems[0].SubItems[9].Text;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdet.Enabled = false;
            txtFiyat.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                bool Sonuc = fs.FilmSatisIptal(Convert.ToInt32(txtSatisNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Satış Bilgileri silindi.");
                    cFilm f = new cFilm();
                    Sonuc = f.FilmStokGuncelleFromSatisIptal(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text));
                    if (Sonuc)
                    {
                        MessageBox.Show("Stok miktarı güncellendi");
                        fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                        Temizle();
                        btnSil.Enabled = false;
                    }
                }
            }


        }

        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtMusteri.Clear();
            txtMusteriNo.Clear();
            txtFilmNo.Clear();
            txtFilm.Clear();
            txtSatisNo.Clear();
            txtFiyat.Focus();
            txtStok.Clear();
        }

    }
}
