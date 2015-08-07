using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_04Donguler
{
    public partial class Form1 : Form
    {
        private int toplam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                lbSayilar.Items.Add(i);
                toplam += i;
            }
            txtToplam.Text = toplam.ToString();
            toplam = 0;
        }

        private void btnCiftSayilar_Click(object sender, EventArgs e)
        {
            lbCiftSayilar.Items.Clear();
            for (int i = 0; i <= 10; i=i+2)
            {
                lbCiftSayilar.Items.Add(i);
                toplam += i;
            }
            txtCiftToplam.Text = toplam.ToString();
            toplam = 0;
        }

        private void btnTekSayilar_Click(object sender, EventArgs e)
        {
            lbTekSayilar.Items.Clear();
            for (int i = 1; i <= 10; i = i + 2)
            {
                lbTekSayilar.Items.Add(i);
                toplam += i;
            }
            txtTekToplam.Text = toplam.ToString();
            toplam = 0;
        }
    }
}
