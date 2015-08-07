using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_15CokBoyutlu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Oya", "Neşe", "Hasan", "Hüseyin", "Ayşe", "Remzi", "Oktay" };

        int[,] Notlar = { { 40, 60, 20 }, { 30, 70, 0 }, { 80, 50, 0 }, { 90, 40, 0 }, { 60, 70, 0 }, { 50, 80, 0 }, { 60, 50, 0 } };

        private void Form2_Load(object sender, EventArgs e)
        {
           
            //foreach (string ogrenci in Ogrenciler)
            //{
            //    lbOgrenciler.Items.Add(ogrenci);
            //}
            //lbOrtalamalar.Items.Add(((Notlar[i, 0] + Notlar[i, 1]) / 2));
            for (int i = 0; i < Notlar.GetLength(0); i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);

                int ort = 0;
                for (int j = 0; j < Notlar.GetLength(1); j++)
                {
                    ort += Notlar[i, j] ;
                }
                
                //int ort = ((Notlar[i, j] + Notlar[i, j-1) / 2);
                lbOrtalamalar.Items.Add(ort / Notlar.GetLength(1));
            }
        }
    }
}
