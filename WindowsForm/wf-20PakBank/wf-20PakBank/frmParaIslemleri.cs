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

namespace wf_20PakBank
{
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            cbIslemTurleri.SelectedIndex = 0;
            txtIslemTarihi.Text = DateTime.Now.ToShortDateString();

            //frmHesapDokumu frm = new frmHesapDokumu();
            //Public static tanımlanan değişkenlere class'ın new ile örneğini oluşturmadan, yani  doğrudan class adı, değişken şeklinde ulaşabiliriz.
            //txtHesapNo.Text = frmHesapDokumu.hesapNo;
            //txtHesapID.Text = frmHesapDokumu.hesapID;

        }


        //3. yol icin
        public void HesapBilgileri(String ID, String HesapNo)
        {
            txtHesapID.Text = ID;
            txtHesapNo.Text = HesapNo;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            StreamWriter HarketYaz = new StreamWriter("HesapHareketleri.txt", true);

            HarketYaz.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + DateTime.Now.ToShortDateString() + ";" + txtTutar.Text + ";" + cbIslemTurleri.SelectedItem.ToString());

            HarketYaz.Close();

            MessageBox.Show("Para İşlemleri Kaydedildi.");

            this.Close();
        }
    }
}
