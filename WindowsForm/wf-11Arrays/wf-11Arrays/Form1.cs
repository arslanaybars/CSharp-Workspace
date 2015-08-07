using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_11Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] takimlar = new string[5];
            takimlar[0] = "Beşiktaş";
            takimlar[1] = "Fenerbahçe";
            takimlar[2] = "Galatasaray";
            takimlar[3] = "AntalyaSpor";
            takimlar[4] = "AdanaDemirSpor";

            //for (int i = 0; i < takimlar.Length; i++)
            //{
            //    MessageBox.Show(takimlar[i]);
            //}

            foreach (string takim in takimlar)
            {
                MessageBox.Show(takim);
            }

            MessageBox.Show(takimlar[0]); // ilk eleman
            MessageBox.Show(takimlar[takimlar.Length - 1]); // son eleman
        }
    }
}