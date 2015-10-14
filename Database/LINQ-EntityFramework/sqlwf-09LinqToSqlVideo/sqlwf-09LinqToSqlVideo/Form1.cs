using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_09LinqToSqlVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoDataContext dc = new VideoDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmleriGoster();
            FilmTurleriGoster();
        }


        private void FilmleriGoster()
        {
            var Films = from film in dc.Filmlers
                        where film.Varmi == true
                        select new { film.FilmNo, film.FilmAd, film.FilmTurNo, film.FilmTurleri.TurAd, film.Yonetmen, film.Oyuncular, film.Ozet, film.Miktar, film.Varmi };

            dgvFilmler.DataSource = Films;
            dgvFilmler.Columns[0].Visible = false;
            dgvFilmler.Columns[2].Visible = false;
        }

        private void FilmTurleriGoster()
        {
            var Turler = from tur in dc.FilmTurleris
                         where tur.Silindi == false
                         select tur.TurAd;

            cbFilmTurleri.DataSource = Turler;

            //foreach (var item in FilmTuru)
            //{
            //    cbFilmTurleri.Items.Add(item.ToString());
            //}

        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilmTuru.Text = cbFilmTurleri.SelectedItem.ToString();

            int TurNo = (from tur in dc.FilmTurleris
                        where tur.Silindi == false && tur.TurAd == txtFilmTuru.Text
                        select tur.FilmTurNo).First();

            txtFilmTurNo.Text = TurNo.ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtMiktar.Text = "1";
            cbxVarmi.Checked = true;
            txtFilmAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != string.Empty && txtFilmTuru.Text.Trim() != string.Empty && txtYonetmen.Text.Trim() != string.Empty)
            {
                if (FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text))
                {
                    MessageBox.Show("Bu Film Öneceden Kayıtlı");
                    txtFilmAdi.Focus();
                }
                else
                {
                    FilmEkle();
                }
            }
            else
            {
                MessageBox.Show("Film Adi, Türü  ve Yönetmen Bilgileri Girilmelidir.", "Eksik Bilgi");
            }
        }

        private bool FilmKontrol(string filmAdi, string yonetmenAdi)
        {
            int sayisi = (from film in dc.Filmlers
                          where film.FilmAd == filmAdi && film.Yonetmen == yonetmenAdi && film.Varmi == true
                          select film).Count();

            return Convert.ToBoolean(sayisi);
        }

        private void FilmEkle()
        {
            Filmler f = new Filmler();
            f.FilmAd = txtFilmAdi.Text;
            f.FilmTurNo = Convert.ToInt32(txtFilmTurNo.Text);
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            f.Miktar = Convert.ToInt32(txtMiktar.Text);
            f.Varmi = cbxVarmi.Checked;

            dc.Filmlers.InsertOnSubmit(f);

            dc.SubmitChanges();

            FilmleriGoster();
            Temizle();

            btnKaydet.Enabled = false;
        }

        private void dgvFilmler_DoubleClick(object sender, EventArgs e)
        {
            txtFilmNo.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[0].Value);
            txtFilmAdi.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[1].Value);
            txtFilmTurNo.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[2].Value);
            txtFilmTuru.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[3].Value);
            txtYonetmen.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[4].Value);
            txtOyuncular.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[5].Value);
            if (dgvFilmler.SelectedRows[0].Cells[6].Value == null)
                txtOzet.Text = "";
            txtOzet.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[6].Value);
            txtMiktar.Text = Convert.ToString(dgvFilmler.SelectedRows[0].Cells[7].Value);
            cbxVarmi.Checked= Convert.ToBoolean(dgvFilmler.SelectedRows[0].Cells[8].Value);

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            FilmiDegisitir(Convert.ToInt32(txtFilmNo.Text));
        }

        private void FilmiDegisitir(int filmNo)
        {
            var degisen = (from film in dc.Filmlers 
                           where film.FilmNo == filmNo 
                           select film).First();

            //var degisen2 = dc.Filmlers.Where(film2 => film2.FilmNo == filmNo).Select(film2 => film2).First();

            degisen.FilmAd = txtFilmAdi.Text;
            degisen.FilmTurNo = Convert.ToInt32(txtFilmTurNo.Text);
            degisen.Yonetmen = txtYonetmen.Text;
            degisen.Oyuncular = txtOyuncular.Text;
            degisen.Ozet = txtOzet.Text;
            degisen.Miktar = Convert.ToInt32(txtMiktar.Text);
            degisen.Varmi = cbxVarmi.Checked;

            dc.SubmitChanges();

            FilmleriGoster();
            Temizle();

            btnSil.Enabled = false;
            btnDegistir.Enabled = false;

            MessageBox.Show("Film Bilgieri Değiştirildi.");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek istiyor musunuz ", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            FilmiSil(Convert.ToInt32(txtFilmNo.Text));
        }

        private void FilmiSil(int filmNo)
        {
            var silinen = (from film in dc.Filmlers
                           where film.FilmNo == filmNo
                           select film).First();

            //var silinen2 = dc.Filmlers.Where(film2 => film2.FilmNo == filmNo).Select(film2 => film2).First();

            dc.Filmlers.DeleteOnSubmit(silinen);

            dc.SubmitChanges();

            FilmleriGoster();
            Temizle();

            btnSil.Enabled = false;
            btnDegistir.Enabled = false;

            MessageBox.Show("Film Bilgieri Silindi.");

        }
    }
}
