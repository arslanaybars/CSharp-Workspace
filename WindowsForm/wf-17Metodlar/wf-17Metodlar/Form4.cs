using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_17Metodlar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int a = 5;
            MessageBox.Show(a.ToString());
            //DegerAl(a);
            DegerAl(ref a);
            //DegerAl(out a);
            MessageBox.Show(a.ToString());
            string[] Sehirler = { "İstanbul", "İzmir", "Ankara", "Bursa" };
            MessageBox.Show(Sehirler[0]);
            ReferansAl(Sehirler);
            MessageBox.Show(Sehirler[0]);
        }

        //private void DegerAl(out int a)
        //{
        //    a = 10;
        //}

        private void DegerAl(ref int a)
        {
            a = 10;
        }

        //private void DegerAl(int a)
        //{
        //    a = 10;
        //}

        private void ReferansAl(string[] Iller)
        {
            Iller[0] = "Adana";
        }
    }
}
