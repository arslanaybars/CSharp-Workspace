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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {

            lvDetaylar.Items.Clear();

            if (cbMarkalar.SelectedIndex == 0)
            {
                lvDetaylar.Items.Add("Iphone 5", 0);
                lvDetaylar.Items[0].SubItems.Add("1.4 GHz");
                lvDetaylar.Items[0].SubItems.Add("16 GB");
                lvDetaylar.Items[0].SubItems.Add("6 MP");
                lvDetaylar.Items[0].SubItems.Add("4''");
                lvDetaylar.Items[0].SubItems.Add("2199 TL");

                lvDetaylar.Items.Add("Iphone 6", 1);
                lvDetaylar.Items[1].SubItems.Add("1.6 GHz");
                lvDetaylar.Items[1].SubItems.Add("16 GB");
                lvDetaylar.Items[1].SubItems.Add("8 MP");
                lvDetaylar.Items[1].SubItems.Add("4.7''");
                lvDetaylar.Items[1].SubItems.Add("2999 TL");

                lvDetaylar.Items.Add("Iphone 6S", 2);
                lvDetaylar.Items[2].SubItems.Add("1.6 GHz");
                lvDetaylar.Items[2].SubItems.Add("32 GB");
                lvDetaylar.Items[2].SubItems.Add("8 MP");
                lvDetaylar.Items[2].SubItems.Add("4.7''");
                lvDetaylar.Items[2].SubItems.Add("3499 TL");
            }
            else if (cbMarkalar.SelectedIndex == 1)
            {
                lvDetaylar.Items.Add("Galaxy Note 4", 0);
                lvDetaylar.Items[0].SubItems.Add("1.2 GHz");
                lvDetaylar.Items[0].SubItems.Add("64 GB");
                lvDetaylar.Items[0].SubItems.Add("15 MP");
                lvDetaylar.Items[0].SubItems.Add("5.5''");
                lvDetaylar.Items[0].SubItems.Add("2499 TL");

                lvDetaylar.Items.Add("Galaxy S5", 1);
                lvDetaylar.Items[1].SubItems.Add("1.4 GHz");
                lvDetaylar.Items[1].SubItems.Add("32 GB");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("4.7''");
                lvDetaylar.Items[1].SubItems.Add("1999 TL");

                lvDetaylar.Items.Add("Galaxy S6", 2);
                lvDetaylar.Items[2].SubItems.Add("1.8 GHz");
                lvDetaylar.Items[2].SubItems.Add("32 GB");
                lvDetaylar.Items[2].SubItems.Add("16 MP");
                lvDetaylar.Items[2].SubItems.Add("5''");
                lvDetaylar.Items[2].SubItems.Add("2499 TL");
            }
            else if (cbMarkalar.SelectedIndex == 2)
            {
                lvDetaylar.Items.Add("Lumia 1020", 0);
                lvDetaylar.Items[0].SubItems.Add("1.2 GHz");
                lvDetaylar.Items[0].SubItems.Add("64 GB");
                lvDetaylar.Items[0].SubItems.Add("15 MP");
                lvDetaylar.Items[0].SubItems.Add("5.5''");
                lvDetaylar.Items[0].SubItems.Add("2499 TL");

                lvDetaylar.Items.Add("Lumia 1320", 1);
                lvDetaylar.Items[1].SubItems.Add("1.4 GHz");
                lvDetaylar.Items[1].SubItems.Add("32 GB");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("4.7''");
                lvDetaylar.Items[1].SubItems.Add("1999 TL");

                lvDetaylar.Items.Add("Lumia 1520", 2);
                lvDetaylar.Items[2].SubItems.Add("1.8 GHz");
                lvDetaylar.Items[2].SubItems.Add("32 GB");
                lvDetaylar.Items[2].SubItems.Add("16 MP");
                lvDetaylar.Items[2].SubItems.Add("5''");
                lvDetaylar.Items[2].SubItems.Add("2499 TL");
            }

        }

        private void mitmLargeIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.LargeIcon;
        }

        private void mitmSmallIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.SmallIcon;
        }

        private void mitmDetails_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Details;
        }

        private void mitmList_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.List;
        }

        private void mitmTile_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Tile;
        }

        private void lvDetaylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvDetaylar.SelectedItems.Count > 0)
            //{
            //    MessageBox.Show(lvDetaylar.SelectedItems[0].SubItems[0].Text + "\tFiyati : " + lvDetaylar.Items[0].SubItems[5].Text);
            //}
        }

        private void lvDetaylar_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lvDetaylar.SelectedItems[0].SubItems[0].Text + "\tFiyati : " + lvDetaylar.Items[0].SubItems[5].Text);
        }


    }
}
