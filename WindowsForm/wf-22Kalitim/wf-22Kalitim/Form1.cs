using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_22Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cCanli abstract class olduğundan miras alınabilir ancak new ile nesne oluşturulmaz
            //cCanli c = new cCanli(); 
            //c.Beslenme = "Petrol";

            cBitki b = new cBitki();
            b.Beslenme = "Gübre";

            cHayvan h = new cHayvan();
            h.Hareket = "Koşar";
            MessageBox.Show(h.YeniDogan());

            cInsan i = new cInsan();
            i.Dusunur = "Bazen";
            MessageBox.Show(i.YeniDogan());

            //cInsan sealed class olduğundan miraz veremez, 
            //ancak new ile istenildiği kadar çoğaltılıp nesne oluşturulabilir.
            //cKisi k = new cKisi();
            //k.Ad = "Ali";
        }
    }

    //class cKisi : cInsan
    //{
    //    private string ad;

    //    public string Ad
    //    {
    //        get { return ad; }
    //        set { ad = value; }
    //    }
    //    private string soyad;

    //    public string Soyad
    //    {
    //        get { return soyad; }
    //        set { soyad = value; }
    //    }
    //}
}
