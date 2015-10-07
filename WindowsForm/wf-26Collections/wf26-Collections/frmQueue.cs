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
    public partial class frmQueue : Form
    {
        public frmQueue()
        {
            InitializeComponent();
        }

        Queue kuyruk = new Queue(); //FIFO (First in First out)

        private void frmQueue_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                kuyruk.Enqueue(sayilar[i]);
            }

            foreach (object eleman in kuyruk)
            {
                lbListe1.Items.Add(Convert.ToInt32(eleman));
            }

            while (kuyruk.Count > 0)
            {
                int sayi = Convert.ToInt32(kuyruk.Dequeue());
                lbListe2.Items.Add(Convert.ToInt32(sayi));
            }
        }
    }
}
