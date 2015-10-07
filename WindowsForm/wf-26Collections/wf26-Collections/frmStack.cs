using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf26_Collections
{
    public partial class frmStack : Form
    {
        public frmStack()
        {
            InitializeComponent();
        }

        Stack yigin = new Stack(); // LIFO

        private void frmStack_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                yigin.Push(sayilar[i]);
            }

            foreach (object eleman in yigin)
            {
                lbListe1.Items.Add(Convert.ToInt32(eleman));
            }

            while (yigin.Count > 0)
            {
                int sayi = Convert.ToInt32(yigin.Pop());
                lbListe2.Items.Add(Convert.ToInt32(sayi));
            }
        }
    }
}
