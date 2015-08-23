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
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }

        int hesapID = 1;
        Random rnd = new Random();

        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 5;

            cbHesapTurleri.SelectedIndex = 0;
            txtAcilisTarihi.Text = DateTime.Now.ToShortDateString();

            SonHesapIDBul();
            HesapNumarasiOlustur();

        }

        private void SonHesapIDBul()
        {
            StreamWriter DosyaYaz = new StreamWriter("HesapKartlari.txt", true);
            DosyaYaz.Close();

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");

            string okunan = DosyaOku.ReadLine();
            if (okunan == null)
            {
                txtHesapID.Text = hesapID.ToString();
            }
            else
            {
                while (okunan != null)
                {
                    string[] Degerler = okunan.Split(';');
                    hesapID = Convert.ToInt32(Degerler[0]);
                    okunan = DosyaOku.ReadLine();
                }
                hesapID++;
                txtHesapID.Text = hesapID.ToString();
            }
            DosyaOku.Close();
        }

        private void HesapNumarasiOlustur()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapVarmi();
            } while (Varmi);
        }

        private bool HesapVarmi()
        {
            int hesapNoRand = rnd.Next(1000, 10000);
            String hesapNo = ("ACC" + hesapNoRand.ToString());

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (hesapNo == Degerler[1])
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            txtHesapNo.Text = hesapNo;
            DosyaOku.Close();
            return false;
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            StreamWriter KartOlustur = new StreamWriter("HesapKartlari.txt", true);
            KartOlustur.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + DateTime.Now.ToShortDateString() + ";" + txtAdi.Text + ";" + txtSoyadi.Text + ";" + txtTCK.Text + ";" + txtBakiye.Text + ";" + cbHesapTurleri.SelectedItem.ToString());
            KartOlustur.Close();

            StreamWriter HareketOlustur = new StreamWriter("HesapHareketleri.txt", true);
            HareketOlustur.WriteLine(txtHesapID.Text + ";" + txtHesapNo.Text + ";" + DateTime.Now.ToShortDateString() + ";" + txtBakiye.Text +";"+ "yatan");
            HareketOlustur.Close();

            MessageBox.Show("Hesap Bilgileri Oluşturuldu.");

            Temizle();

        }

        private void Temizle()
        {
            SonHesapIDBul();
            HesapNumarasiOlustur();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCK.Clear();
            txtBakiye.Clear();
            cbHesapTurleri.SelectedIndex = 0;
        }
    }
}