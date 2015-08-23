using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_21OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.urunAdi = "Bilgisayar";
            u.fiyat = 1500;

            MessageBox.Show("Ürün : " + u.urunAdi + ", Fiyatı : " + u.fiyat);
        }
    }

    partial class Urun
    {
        public decimal fiyat;
        public int miktar;
    }
}
