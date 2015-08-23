using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_09ListBox
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            cbMarkalar.SelectedIndex = 0;
        }
    }
}
