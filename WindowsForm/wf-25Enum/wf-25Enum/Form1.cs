using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_25Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Gunler : byte { Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }

        enum Subeler { Beşiktaş = 1250, Taksim = 1350, Bakirkoy, Kadikoy = 1426 }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Gunler.Cumartesi.ToString());
            //MessageBox.Show(((int)Gunler.Cumartesi).ToString());

            int Kod = (int)Subeler.Bakirkoy;

            MessageBox.Show("Bakırköy = " + Kod.ToString());

            string[] Degerler = Enum.GetNames(typeof(Subeler)); // typeof
            foreach (string gun in Degerler)
            {
                MessageBox.Show(gun);
            }
        }
    }
}
