using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_28GenericCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cOrnek<string> o1 = new cOrnek<string>();
            o1.Alan1 = "Ali";

            cOrnek<int> o2 = new cOrnek<int>();
            o2.Alan1 = 20;

            MessageBox.Show(o1.Alan1 + ", " + o2.Alan1 + " Yaşında");

            MessageBox.Show(o1.Metot1("5"));
            MessageBox.Show(o2.Metot1(5).ToString());
        }
    }
}
