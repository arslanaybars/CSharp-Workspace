using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf_19TextYazmaOkuma
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

        private void btnYaz_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("metin.txt"); // CreateOrOpen
            if (txtYeniSatir.Text.Trim() != "")
            {
                sw.WriteLine(txtYeniSatir.Text);
                MessageBox.Show("Yeni Satır Yazıldı, okuma yapabilirsiniz.");
                txtYeniSatir.Clear();
                txtYeniSatir.Focus();
            }
            else
            {
                MessageBox.Show("Öncelikle metin girmelisiniz.","Dikkat Eksik Bilgi");
            }
            sw.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("metin.txt", true); // append
            if (txtYeniSatir.Text.Trim() != "")
            {
                sw.WriteLine(txtYeniSatir.Text);
                MessageBox.Show("Yeni Satır Eklendi, okuma yapabilirsiniz.");
                txtYeniSatir.Clear();
                txtYeniSatir.Focus();
            }
            else
            {
                MessageBox.Show("Öncelikle metin girmelisiniz.", "Dikkat Eksik Bilgi");

            }
            sw.Close();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("metin.txt");
            txtMetin.Text= sr.ReadLine();
            sr.Close();
        }

        private void btnHepsiniOku_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("metin.txt");
            txtMetin.Clear();
            //txtMetin.Text = sr.ReadToEnd();
            string line  = sr.ReadLine();
            while ((line != null))
            {
                txtMetin.Text += line + "\n";
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
