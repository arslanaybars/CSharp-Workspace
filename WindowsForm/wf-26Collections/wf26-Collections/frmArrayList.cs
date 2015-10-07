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
    public partial class frmArrayList : Form
    {
        public frmArrayList()
        {
            InitializeComponent();
        }

        ArrayList alist = new ArrayList();

        private void frmArrayList_Load(object sender, EventArgs e)
        {
            alist.Add(1);
            MessageBox.Show(alist.Count.ToString());
            alist.Add(2);
            alist.Add(3);
            alist.Add(4);
            alist.Add(5);
            MessageBox.Show(alist.Capacity.ToString());
            alist.Add(6);
            alist.Add(7);
            alist.Add(8);
            foreach (object eleman in alist)
            {
                lbListe1.Items.Add(Convert.ToInt32(eleman));
            }

            alist.Insert(6, 10);
            MessageBox.Show(alist.Capacity.ToString());
            foreach (object eleman in alist)
            {
                lbListe2.Items.Add(Convert.ToInt32(eleman));
            }

            alist.Remove(5); // Degeri 5 olan elemanı siler, digerlerini kaydırır.
            MessageBox.Show(alist.Capacity.ToString());

            foreach (object eleman in alist)
            {
                lbListe3.Items.Add(Convert.ToInt32(eleman));
            }

            alist.RemoveAt(5); // 5.sıradaki indexi 5 olan elemanı siler.
            foreach (object eleman in alist)
            {
                lbListe4.Items.Add(Convert.ToInt32(eleman));
            }

            int toplam = 0;
            foreach (object eleman in alist)
            {
               toplam += Convert.ToInt32(eleman);
            }
            MessageBox.Show("Toplam : " + toplam);
        }
    }
}
