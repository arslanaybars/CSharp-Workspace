using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_11Arrays
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int[] Sayilar = { 2, 5, 8, 3, 12, 4, 7, 10 };

        private void Form3_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Sayilar[0].ToString());
            //MessageBox.Show((Sayilar.Length - 1).ToString());
            //MessageBox.Show(Sayilar.Max().ToString());
            //MessageBox.Show(Sayilar.Min().ToString());

            foreach (int sayi in Sayilar)
            {
                lbIlkHali.Items.Add(sayi.ToString());
            }

            //Dizi elemanlarının sırasını tersine cevirir
            Array.Reverse(Sayilar); 
            foreach (int sayi in Sayilar)
            {
                lbSonHali.Items.Add(sayi.ToString());
            }

            //Dizi elemanlarını sıralar
            Array.Sort(Sayilar);
            foreach (int sayi in Sayilar)
            {
                lbSıralı.Items.Add(sayi.ToString());
            }

            // Belirtilen değerin dizi içerisindeki indeksini döndürür
            MessageBox.Show(Array.IndexOf(Sayilar, 7).ToString()); 

        }
    }
}
