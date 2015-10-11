using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_30LinqToObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> liste = new List<int>() { 2, 4, 6, 8, 10 };

            foreach (int sayi in liste)
            {
                lbListe1.Items.Add(sayi);
            }

            //var sonuc = from s in liste
            //            where s > 4
            //            select s;

            // => Lambda ifadesi
            var sonuc = liste.Where(s => s > 4).Select(s => s); // s öyleki s byük 4

            foreach (int sayi in sonuc)
            {
                lbListe2.Items.Add(sayi);
            }

            //lbListe2.DataSource = sonuc.ToList();

        }
    }
}
