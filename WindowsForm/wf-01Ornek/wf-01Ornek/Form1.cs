using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_01Ornek
{
    public partial class Form1 : Form
    {
        private Boolean i = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Başlığı Dinamik Olarak Değiştirdim.";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (i == false)
            {
                btnKaydet.Text = "Buton tıklandı";
                i = false;
            }
            else
            {
                btnKaydet.Text = "Kaydet";
                i = true;
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtAdi.Text);
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtAdi.Text);
        }

    }
}
