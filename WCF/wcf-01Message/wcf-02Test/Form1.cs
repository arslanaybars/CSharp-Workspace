using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcf_02Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Client servisten yeni bir örnek oluşturuyoruz.
        ServisMesaj.Service1Client servis = new ServisMesaj.Service1Client(); 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(servis.Mesaj());
        }
    }
}
