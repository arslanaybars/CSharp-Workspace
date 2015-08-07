using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_16SatisAnalizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Firmalar = { "Tekstil", "Gıda", "Otomotiv", "İnşaat" };

        double[,] Satislar = { { 700, 600, 1100, 800 }, { 500, 800, 700, 600 }, { 400, 1500, 800, 1400 }, { 2200, 3000, 2500, 2000 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            lvDetaylar.Items.Clear();

            for (int i = 0; i < Satislar.GetLength(1); i++)
            {
                lvDetaylar.Items.Add(Firmalar[i]);
                for (int j = 0; j < Satislar.GetLength(1); j++)
                {
                    //lvDetaylar.Items[i].SubItems.Add(Satislar[i, j]);
                    lvDetaylar.Items[i].SubItems.Add(Satislar[i, j].ToString());
                }   
            }
        }
    }
}
