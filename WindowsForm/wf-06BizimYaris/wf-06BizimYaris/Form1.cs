using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_06BizimYaris
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pb1.Left = 30;
            pb2.Left = 30;
            pb3.Left = 30;
            pb4.Left = 30;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                pb1.Left += rnd.Next(1, 10);
                pb2.Left += rnd.Next(1, 10);
                pb3.Left += rnd.Next(1, 10);
                pb4.Left += rnd.Next(1, 10);

            if (pb1.Left >= this.Width - pb1.Width - 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. At kazandı", "WINNER!!");
            }
            if (pb2.Left >= this.Width - pb1.Width - 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At kazandı", "WINNER!!");
            }
            if (pb3.Left >= this.Width - pb1.Width - 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At kazandı", "WINNER!!");
            }
            if (pb4.Left >= this.Width - pb1.Width - 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("4. At kazandı", "WINNER!!");
            }
            
        }
    }
}
