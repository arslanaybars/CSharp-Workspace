using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_05SayiBulma
{
    public partial class Form1 : Form
    {
        int tahmin = 0;
        int tutulanSayi = 0;
        int can;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rbBaslangic.Checked)
                can = 10;
            else if (rbOrta.Checked)
                can = 5;
            else if (rbIeri.Checked)
                can = 3;
            tutulanSayi = rnd.Next(1, 101); // creates a number between 1 and 100
            
            lblRandom.Text = tutulanSayi.ToString();
            lblCan.Text = (can + " can hakkınız kaldı.");
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            can--;
            lblCan.Text = (can + " can hakkınız kaldı.");
            
            
            if (can == 0)
            {
                MessageBox.Show("Kaybettin Bro");
                Form1_Load(this, null);
            }
            else if (txtTahmin.Text.Trim() != "")
            {
                tahmin = Convert.ToInt32(txtTahmin.Text);

                if (tahmin == tutulanSayi)
                {
                    this.Height = 456;
                    MessageBox.Show("tebrikler " + (can + 1) + ". can hakkınızda bildiniz.");
                    Form1_Load(this, null);
                    this.Height = 296;
                }
                else if (tahmin < tutulanSayi)
                    MessageBox.Show("Üzgünüz bilemediniz. Daha büyük bir sayi tahmin ediniz");
                else if (tahmin > tutulanSayi)
                    MessageBox.Show("Üzgünüz bilemediniz. Daha küçük bir sayi tahmin ediniz");
                else
                    MessageBox.Show("Yine olmadı");
            }
            else
            {
                MessageBox.Show("Öncelikle tahminde bulunmalısınız.");
            }

            
            txtTahmin.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            tutulanSayi = rnd.Next(1, 101);
            txtTahmin.Clear();
            txtTahmin.Focus();
            lblRandom.Text = tutulanSayi.ToString();
        }

        private void rbBaslangic_CheckedChanged(object sender, EventArgs e)
        {
            can = 10;
            lblCan.Text = (can + " can hakkınız kaldı.");
            Form1_Load(this, null);
        }

        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            can = 5;
            lblCan.Text = (can + " can hakkınız kaldı.");
            Form1_Load(this, null);
        }

        private void rbIeri_CheckedChanged(object sender, EventArgs e)
        {
            can = 3;
            lblCan.Text = (can + " can hakkınız kaldı.");
            Form1_Load(this, null);
        }

    }
}
