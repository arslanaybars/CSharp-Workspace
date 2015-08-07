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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Neşe", "Kerem", "Hakkı", "Necati", "Ayşe", "Sevgi" };

        int[] Notlar = { 40, 60, 50, 90, 70, 50 };

        private void Form3_Load(object sender, EventArgs e)
        {
            DiziGoster(Ogrenciler);
            DiziGoster(Ogrenciler, lbListe2);
            DiziGoster(Notlar);
            DiziGoster(Notlar, lbListe2);
        }

        private void DiziGoster(string[] Dizi)
        {
            foreach (string eleman in Dizi)
            {
                lbListe1.Items.Add(eleman);
            }
        }

        private void DiziGoster(int[] Dizi)
        {
            foreach (int eleman in Dizi)
            {
                lbListe1.Items.Add(eleman);
            }
        }

        private void DiziGoster(string[] Dizi, ListBox lb)
        {
            foreach (string eleman in Dizi)
            {
                lb.Items.Add(eleman);
            }
        }

        private void DiziGoster(int[] Dizi, ListBox lb)
        {
            foreach (int eleman in Dizi)
            {
                lb.Items.Add(eleman);
            }
        }
    }
}
