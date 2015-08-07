using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_10ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMarkalar.SelectedIndex = 0;
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbModeller.Items.Clear();

            if (cbMarkalar.SelectedIndex == 0)
            {
                lbModeller.Items.Add("Iphone 5");
                lbModeller.Items.Add("Iphone 6");
                lbModeller.Items.Add("Iphone 6S");
            }
            else if (cbMarkalar.SelectedIndex == 1)
            {
                lbModeller.Items.Add("Galaxy Note 4");
                lbModeller.Items.Add("Galaxy S5");
                lbModeller.Items.Add("Galaxy S6");
            }
            else if (cbMarkalar.SelectedIndex == 2)
            {
                lbModeller.Items.Add("Lumia 1020");
                lbModeller.Items.Add("Lumia 1320");
                lbModeller.Items.Add("Lumia 1520");
            }
            else
            {

            }
        }

        private void lbModeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetaylar.Items.Clear();

            if (lbModeller.SelectedItem.ToString() == "Iphone 5")
            {
                lvDetaylar.Items.Add("1.4 GHz");
                lvDetaylar.Items[0].SubItems.Add("16 GB");
                lvDetaylar.Items[0].SubItems.Add("6 MP");
                lvDetaylar.Items[0].SubItems.Add("4''");
                lvDetaylar.Items[0].SubItems.Add("2199 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Iphone 6S")
            {
                lvDetaylar.Items.Add("1.6 GHz");
                lvDetaylar.Items[0].SubItems.Add("16 GB");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("4.7''");
                lvDetaylar.Items[0].SubItems.Add("2999 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Iphone 6")
            {
                lvDetaylar.Items.Add("1.6 GHz");
                lvDetaylar.Items[0].SubItems.Add("32 GB");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("4.7''");
                lvDetaylar.Items[0].SubItems.Add("3499 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy Note 4")
            {
                lvDetaylar.Items.Add("1.2 GHz");
                lvDetaylar.Items[0].SubItems.Add("64 GB");
                lvDetaylar.Items[0].SubItems.Add("15 MP");
                lvDetaylar.Items[0].SubItems.Add("5.5''");
                lvDetaylar.Items[0].SubItems.Add("2499 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S5")
            {
                lvDetaylar.Items.Add("1.4 GHz");
                lvDetaylar.Items[0].SubItems.Add("32 GB");
                lvDetaylar.Items[0].SubItems.Add("12 MP");
                lvDetaylar.Items[0].SubItems.Add("4.7''");
                lvDetaylar.Items[0].SubItems.Add("1999 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S6")
            {
                lvDetaylar.Items.Add("1.8 GHz");
                lvDetaylar.Items[0].SubItems.Add("32 GB");
                lvDetaylar.Items[0].SubItems.Add("16 MP");
                lvDetaylar.Items[0].SubItems.Add("5''");
                lvDetaylar.Items[0].SubItems.Add("2499 TL");
            }
        }
    }
}
