using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_27ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            lvFilmler.Items.Clear();
            cFilm f = new cFilm();
            ArrayList alist = f.FilmleriGetir();

            int i = 0;
            foreach (cFilm film in alist)
            {
                lvFilmler.Items.Add(film.FilmNo.ToString());
                lvFilmler.Items[i].SubItems.Add(film.FilmAd);
                lvFilmler.Items[i].SubItems.Add(film.Yonetmen);
                lvFilmler.Items[i].SubItems.Add(film.Oyuncular);
                lvFilmler.Items[i].SubItems.Add(film.Miktar.ToString());
                i++;
            }

            dgvFilmler.DataSource = alist;
        }
    }
}
