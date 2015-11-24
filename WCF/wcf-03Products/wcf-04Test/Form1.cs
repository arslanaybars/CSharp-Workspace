using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wcf_04Test.ServisProducts;

namespace wcf_04Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Client servisten yeni bir örnek oluşturuyoruz.
        ServisProducts.Service1Client servis = new ServisProducts.Service1Client();



        private void btnGetir_Click(object sender, EventArgs e)
        {
            gvUrunler.DataSource = servis.listProducts();

            //List<T> Products = servis.listProducts();
            //List<ServisProducts.Product> elemanlar = new List<ServisProducts.Product>();
            //elemanlar = servis.listProducts();
            //gvUrunler.DataSource = elemanlar;

        }
    }
}
