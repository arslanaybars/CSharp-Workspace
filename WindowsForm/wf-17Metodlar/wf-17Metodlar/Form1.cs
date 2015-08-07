using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_17Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EkranaGoruntule("Veriler kaydedildi"); 
            Temizle();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            EkranaGoruntule("Veriler degistirildi"); 
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EkranaGoruntule("Veriler silindi");
            Temizle();
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void EkranaGoruntule(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
    }
}
