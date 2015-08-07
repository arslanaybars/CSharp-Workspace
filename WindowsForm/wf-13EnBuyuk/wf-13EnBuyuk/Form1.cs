using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_13EnBuyuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = { 30, 50, 80, 60, 70, 20, 90, 40 };
        string[] Ogrencier = { "Arda", "Kerem", "Neşe", "Oya", "Ali", "Özgür", "Aybars", "Hasan" };

        private void Form1_Load(object sender, EventArgs e)
        {
            int max = sayilar[0];
            int min = sayilar[0];

            //EN BUYUK
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (max < sayilar[i])
                {
                    max = sayilar[i];
                    txtEnBuyukOgrenci.Text = Ogrencier[i];
                }
                if (min > sayilar[i])
                {
                    min = sayilar[i];
                    txtEnKucukOgrenci.Text = Ogrencier[i];
                }
            }

            txtEnBuyuk.Text = max.ToString();

            ////EN KUCUK
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (min >= sayilar[i])
            //        min = sayilar[i];
            //}

            txtEnKucuk.Text = min.ToString();

            //txtEnBuyukOgrenci.Text = Ogrencier[Array.IndexOf(sayilar, max)];
            //txtEnKucukOgrenci.Text = Ogrencier[Array.IndexOf(sayilar, min)];
        }
    }
}
