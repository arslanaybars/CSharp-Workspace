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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (topla(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)).ToString());
        }

        private int topla(int a, int b)
        {
            return a + b;
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (cikar(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)).ToString());
        }

        private int cikar(int a, int b)
        {
            return a - b;
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (carp(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)).ToString());
        }

        private int carp(int a, int b)
        {
            return a * b;
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (bol(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)).ToString());
        }

        private int bol(int a, int b)
        {
            return a / b;
        }


    }
}
