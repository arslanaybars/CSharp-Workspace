using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_29GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] notlar = { 50, 70, 80, 60, 90 };
            string[] ogrenciler = { "Oya", "Sevgi", "Hasan", "Vedat", "Hakan" };

            List<int> liste1 = new List<int>();

            foreach (int sayi in notlar)
            {
                liste1.Add(sayi);                
            }
            lbListe1.DataSource = liste1;

            List<string> liste2 = new List<string>();
            foreach (string ogrenci in ogrenciler)
            {
                liste2.Add(ogrenci);             
            }
            liste2.Remove("Vedat");
            lbListe2.DataSource = liste2;
        }
    }
}
