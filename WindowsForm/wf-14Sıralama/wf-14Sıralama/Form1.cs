using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_14Sıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = { 22, 12, 5, 33, 6, 18, 20, 45, 11 };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int item in sayilar)
            {
                lbIlkHali.Items.Add(item);
            }


            //Bubble sort
            int tmp = 0;
           
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = 1; j < sayilar.Length; j++)
                {
                    if (sayilar[j] < sayilar[j - 1])
                    {
                        tmp = sayilar[j];
                        sayilar[j] = sayilar[j - 1];
                        sayilar[j - 1] = tmp;
                    }
                }
            }

            foreach (int item in sayilar)
            {
                lbSiraliHali.Items.Add(item);
            }
        }
    }
}
