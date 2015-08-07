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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Oya", "Neşe", "Hasan", "Hüseyin", "Ayşe", "Remzi", "Oktay" };

        int[,] Notlar = { { 40, 60 }, { 30, 70 }, { 80, 50 }, { 90, 40 }, { 60, 70 }, { 50, 80 }, { 60, 50 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Ogrenciler[2] + " : " + Notlar[2, 0] + " , " + Notlar[2, 1]);
            //MessageBox.Show(Ogrenciler.Length.ToString());
            //MessageBox.Show(Notlar.Length.ToString());
            //MessageBox.Show(Ogrenciler.Rank.ToString());// Dizinin boyutunu verir
            //MessageBox.Show(Notlar.Rank.ToString());// Dizinin boyutunu verir
            //MessageBox.Show(Notlar.GetLength(0).ToString());// Dizinin Satır sayısını verir
            //MessageBox.Show(Notlar.GetLength(1).ToString());// Dizinin Sutun sayısını verir

            foreach (string ogrenci in Ogrenciler)
            {
                lbOgrenciler.Items.Add(ogrenci);
            }

            for (int i = 0; i < Notlar.GetLength(0); i++)
            {

                lbNot1.Items.Add(Notlar[i, 0]);
                lbNot2.Items.Add(Notlar[i, 1]);
                //for (int j = 1; j < Notlar.GetLength(1); j++)
                //{
                //    lbNot2.Items.Add(Notlar[i, j]);
                //}
            }



        }

        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNot1.SelectedIndex = lbOgrenciler.SelectedIndex;
        }

        private void lbNot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNot2.SelectedIndex = lbNot1.SelectedIndex;
        }

        private void lbNot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNot1.SelectedIndex = lbNot2.SelectedIndex;
            lbOgrenciler.SelectedIndex = lbNot2.SelectedIndex;
        }



    }
}
