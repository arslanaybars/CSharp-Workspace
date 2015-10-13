using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_08LinqToSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext dc = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var Films = from film in dc.Filmlers
                        where film.Varmi == true
                        select new {film.FilmAd, film.Yonetmen, film.Oyuncular, film.Miktar};

            dgvFilmler.DataSource = Films;
        }
    }
}
