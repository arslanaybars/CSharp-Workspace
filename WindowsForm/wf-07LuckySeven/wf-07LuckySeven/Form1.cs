using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_07LuckySeven
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        Boolean t = false;

        private int sayi1 = 0;
        private int sayi2 = 0;
        private int sayi3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (t == false)
            {
                btnStart.Text = "Durdur";
                t = true;
                timer1.Enabled = true;
            }
            else
            {
                btnStart.Text = "Başlat";
                timer1.Enabled = false;
                t = false;

                if (sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3)
                {
                    this.Height = 350;
                    MessageBox.Show("WellDone !!!!!!!", "Sonuc");
                    this.Height = 250;
                }
                else if (sayi1 == sayi2 || sayi1 == sayi3 || sayi2 == sayi3)
                    MessageBox.Show("Fena degil, AMORTI kazandın !!!!!!!", "Sonuc");
                else
                    MessageBox.Show("bence sen oynama", "Sonuc");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1 ve 7 arası demek 1 dahil 8 dahil degil
            sayi1 = rnd.Next(1, 8);
            sayi2 = rnd.Next(1, 8);
            sayi3 = rnd.Next(1, 8);
            lbl1.Text = sayi1.ToString();
            lbl2.Text = sayi2.ToString();
            lbl3.Text = sayi3.ToString();
        }
    }
}
