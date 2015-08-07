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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Hasan", "Ali", "Aybars", "Özgür", "Mustafa", "Buğra" };

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();

            //for (int i = 0; i < Ogrenciler.Length; i++)
            //{
            //    lbListe.Items.Add(Ogrenciler[i]);
            //}

            //foreach (string ogrenci in Ogrenciler)
            //{
            //    lbListe.Items.Add(ogrenci);
            //}

            lbListe.Items.AddRange(Ogrenciler);
        }
    }
}
