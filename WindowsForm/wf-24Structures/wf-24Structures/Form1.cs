using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_24Structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Ogrenci
        {
            private int _id;
            private string _ad;
            private string _soyad;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Ad
            {
                get { return _ad; }
                set { _ad = value; }
            }

            public string Soyad
            {
                get { return _soyad; }
                set { _soyad = value; }
            }

            public Ogrenci(int ID, string isim, string soyisim)
            {
                _id = ID;
                _ad = isim;
                _soyad = soyisim;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ogrenci o; //value type oldugundan kullanılmadan önce deger atanmalıdır.
            //MessageBox.Show(o.Ad); 

            Ogrenci o = new Ogrenci();
            o.Ad = "Ali";
            o.Soyad = "Uçar";
            MessageBox.Show(o.Ad + " " + o.Soyad);

            Ogrenci ogr = new Ogrenci(1, "Ayşe", "Koşar");
            MessageBox.Show(ogr.Ad + " " + ogr.Soyad);
        } 
    }
}
