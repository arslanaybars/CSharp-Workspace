using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_25Enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        struct Urun
        {
            private int _id;
            private string _urunAdi;
            private decimal _urunFiyati;
            private Renkler _urunRengi;

            public Renkler UrunRengi
            {
                get { return _urunRengi; }
                set { _urunRengi = value; }
            }

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string UrunAdi
            {
                get { return _urunAdi; }
                set { _urunAdi = value; }
            }

            public decimal UrunFiyati
            {
                get { return _urunFiyati; }
                set { _urunFiyati = value; }
            }

            public Urun(int ID, string Urun, decimal Fiyat, Renkler Renk)
            {
                _id = ID;
                _urunAdi = Urun;
                _urunFiyati = Fiyat;
                _urunRengi = Renk;
            }
        }

        enum Renkler : byte { Siyah, Kırmızı, Beyaz, Sarı, Lacivert, Yeşil }

        private void Form2_Load(object sender, EventArgs e)
        {
            Urun u = new Urun(1, "Bilgisayar", 1500, Renkler.Beyaz);
            MessageBox.Show("Ürün Adi : " + u.UrunAdi + ", Fiyatı : " + u.UrunFiyati + ", Urun Rengi : " + u.UrunRengi);
            if ((int)Renkler.Beyaz == 2)
                MessageBox.Show("COOL");
        }
    }
}
