using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_05BindingOkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        BindingSource bs1;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBagla();
            Konum();
        }

        private void DataBagla()
        {
            cOgretmen o = new cOgretmen();
            
            ds = o.OgretmenleriGetir();
            bs1 = new BindingSource();

            bs1.DataSource = ds.Tables["Ogretmenler"];

            txtAdi.DataBindings.Add("Text", bs1, "Ad");
            txtSoyadi.DataBindings.Add("Text", bs1, "Soyad");
            txtTelefon.DataBindings.Add("Text", bs1, "Telefon");
            txtBrans.DataBindings.Add("Text", bs1, "Brans");
        }

        private void Konum()
        {
            lblKonum.Text = (bs1.Position + 1) + " / " + bs1.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //bs1.MoveFirst();
            bs1.Position = 0;
            Konum();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //bs1.MovePrevious();
            bs1.Position -= 1;
            Konum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //bs1.MoveNext();
            bs1.Position += 1;
            Konum();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //bs1.MoveLast();
            bs1.Position = bs1.Count;
            Konum();
        }

    }
}
