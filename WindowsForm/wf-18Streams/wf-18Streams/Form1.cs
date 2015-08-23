using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf_18Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Deneme.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(fs);

            //StreamWriter sw = new StreamWriter("Deneme.txt"); //Dosyayi acar, her seferinde bastan yazar, onceki bilgiler silinir

            StreamWriter sw = new StreamWriter("Deneme.txt", true); // true, yeni kayıtların dosyanın sonuna ekleneceğini belirtir
            sw.Write("OK!");
            sw.Write("OK!");
            sw.WriteLine("Diger satır!");
            sw.Close();  //İslerimiz bittiginde mutlaka nesnemizi sonlandırmalıyız.

            StreamReader sr = new StreamReader("Deneme.txt");
            //MessageBox.Show(sr.ReadLine());
            //MessageBox.Show(sr.ReadLine());
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }
    }
}
