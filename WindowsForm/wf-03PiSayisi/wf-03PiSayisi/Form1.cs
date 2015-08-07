using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_03PiSayisi
{
    public partial class Form1 : Form
    {
        private double PI = 3.14;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {

            double cevre = 0;
            if (txtR.Text.Trim() == "")
            {
                MessageBox.Show("Yanlış Giriniz !");
            }
            else
            {
                cevre = (Convert.ToInt32(txtR.Text)) * 2 * PI;
                MessageBox.Show(cevre.ToString());
                txtSonuc.Text = cevre.ToString();
            }
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            double alan = 0;
            if (txtR.Text.Trim() == "")
            {
                MessageBox.Show("Yanlış Giriniz !");
            }
            else
            {
                //Math.Pow (kuvvetiAlicakSayi, kuvvet)
                alan = Math.Pow(Convert.ToInt32(txtR.Text), 2) * PI;
                MessageBox.Show(alan.ToString());
                txtSonuc.Text = alan.ToString();
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double alan = 0;
            double cevre = 0;
            if (rbAlan.Checked)
            {
                alan = Math.Pow(Convert.ToInt32(txtR.Text), 2) * PI;
                txtSonuc.Text = alan.ToString();
            }
            else if (rbCevre.Checked)
            {
                cevre = (Convert.ToInt32(txtR.Text)) * 2 * PI;
                txtSonuc.Text = cevre.ToString();
            }
            else
            {
                MessageBox.Show("Something going bad !1");
            }
        }

    }
}
