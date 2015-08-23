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
using System.Drawing.Printing;

namespace wf_20PakBank
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }

        public static string hesapID;
        public static string hesapNo;

        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);

        SolidBrush sb = new SolidBrush(Color.Black);

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text.Trim() != "")
            {
                HesapBilgileriniGoster();
                HesapHareketleriniGoster();
                ToplamlariGoster();
            }
        }

        private void HesapBilgileriniGoster()
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();


            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                if (Degerler[1] == txtHesapNo.Text)
                {
                    txtAdi.Text = Degerler[3];
                    txtSoyadi.Text = Degerler[4];
                    txtTCKno.Text = Degerler[5];
                    txtHesapTürü.Text = Degerler[7];
                    txtTarih.Text = Degerler[2];
                }
                okunan = DosyaOku.ReadLine();

            }
            DosyaOku.Close();
        }

        private void HesapHareketleriniGoster()
        {
            lvHareketler.Items.Clear();
            StreamReader HareketOku = new StreamReader("HesapHareketleri.txt");

            string hareket = HareketOku.ReadLine();

            int sayac = 0;

            while (hareket != null)
            {
                string[] Hareketler = hareket.Split(';');
                if (Hareketler[1] == txtHesapNo.Text)
                {
                    lvHareketler.Items.Add(Hareketler[0]);
                    lvHareketler.Items[sayac].SubItems.Add(Hareketler[1]);
                    lvHareketler.Items[sayac].SubItems.Add(Hareketler[2]);
                    lvHareketler.Items[sayac].SubItems.Add(Hareketler[3]);
                    lvHareketler.Items[sayac].SubItems.Add(Hareketler[4]);
                    sayac++;
                }
                hareket = HareketOku.ReadLine();
            }
            HareketOku.Close();
        }

        private void ToplamlariGoster()
        {
            //StreamReader HareketOku = new StreamReader("HesapHareketleri.txt");

            //string hareket = HareketOku.ReadLine();

            //int sayac = 0;
            //int yatan = 0;
            //int cekilen = 0;

            //while (hareket != null)
            //{
            //    string[] Hareketler = hareket.Split(';');
            //    if (Hareketler[1] == txtHesapNo.Text)
            //    {
            //        if (Hareketler[4].Trim().ToLower() == "yatan")
            //            yatan += Convert.ToInt32(Hareketler[3]);
            //        else if (Hareketler[4].Trim().ToLower() == "cekilen")
            //            cekilen += Convert.ToInt32(Hareketler[3]);
            //        sayac++;
            //    }
            //    hareket = HareketOku.ReadLine();
            //}
            //HareketOku.Close();
            //txtToplamYatan.Text = yatan.ToString();
            //txtToplamCekilen.Text = cekilen.ToString();
            //txtBakiye.Text = (yatan - cekilen).ToString();
            int yatan = 0;
            int cekilen = 0;
            //foreach (ListViewItem item in lvHareketler.Items)
            //{
            //    if (item.SubItems[3].ToString().ToLower() == "yatan")
            //        yatan += Convert.ToInt32(item.SubItems[2].Text);
            //    else if (item.SubItems[3].ToString().ToLower() == "cekilen")
            //        cekilen += Convert.ToInt32(item.SubItems[2].Text);
            //}

            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text.ToLower() == "yatan")
                    yatan += Convert.ToInt32(lvHareketler.Items[i].SubItems[3].Text);
                else if (lvHareketler.Items[i].SubItems[4].Text.ToLower() == "cekilen")
                    cekilen += Convert.ToInt32(lvHareketler.Items[i].SubItems[3].Text);
            }

            txtToplamYatan.Text = yatan.ToString();
            txtToplamCekilen.Text = cekilen.ToString();
            txtBakiye.Text = (yatan - cekilen).ToString();

        }

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            //1
            //hesapNo = txtHesapNo.Text;
            //hesapID = lvHareketler.Items[0].SubItems[0].Text;
            frmParaIslemleri frm = new frmParaIslemleri();
            //2
            //Label, TextBox gibi kontroller default olarak private tanımlanırlar. Modifiers özelliklerini Public yaparak bu kontrollere diger class'lardan da erişebiliriz.
            //frm.txtHesapID.Text = lvHareketler.Items[0].SubItems[0].Text;
            //frm.txtHesapNo.Text = txtHesapNo.Text;

            //3
            frm.HesapBilgileri(lvHareketler.Items[0].SubItems[0].Text, txtHesapNo.Text);
            frm.ShowDialog();

            HesapHareketleriniGoster();
            ToplamlariGoster();
        }

        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 5;
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            ppdHareketler.Width = 600;
            ppdHareketler.Height = 600;
            ppdHareketler.ShowDialog();
        }
        int y = 0;
        private void pdocHareketler_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Müşteri : " + txtAdi.Text + " " + txtSoyadi.Text, fntBaslik, sb, 100, 130, fmt);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 600, 130, fmt);
            e.Graphics.DrawString("Hesap Hareketleri", fntBaslik, sb, 300, 180, fmt);
            e.Graphics.DrawString("  ID    HesapNo    İşlemTarihi     İşlemTutarı     İşlemTipi", fntBaslik, sb, 150, 250, fmt);
            e.Graphics.DrawString(" _______________________________________________", fntBaslik, sb, 150, 260);
            int j = 0;
            for (int i = y; i < lvHareketler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[0].Text, fntDetay, sb, 160, 300 + j * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[1].Text, fntDetay, sb, 210, 300 + j * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[2].Text, fntDetay, sb, 330, 300 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[3].Text, fntDetay, sb, 530, 300 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[4].Text, fntDetay, sb, 600, 300 + j * 30, fmt);
                if (y % 22 == 0 && y != 0)
                {
                    y++;
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    y++;
                    j++;
                    e.HasMorePages = false;
                }
            }
            j++;
            e.Graphics.DrawString(" _______________________________________________", fntBaslik, sb, 150, 300 + j * 30);
            j++;
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Toplam Yatan ", fntBaslik, sb, 400, 300 + j * 30, fmt);
            e.Graphics.DrawString(String.Format("{0:#,##0.00}", Convert.ToDouble(txtToplamYatan.Text)), fntBaslik, sb, 530, 300 + j * 30, fmt);
            j++;
            e.Graphics.DrawString("Toplam Çekilen", fntBaslik, sb, 400, 300 + j * 30, fmt);
            e.Graphics.DrawString(String.Format("{0:#,##0.00}", Convert.ToDouble(txtToplamCekilen.Text)), fntBaslik, sb, 530, 300 + j * 30, fmt);
            j++;
            e.Graphics.DrawString("Bakiye ", fntBaslik, sb, 400, 300 + j * 30, fmt);
            e.Graphics.DrawString(String.Format("{0:#,##0.00}", Convert.ToDouble(txtBakiye.Text)), fntBaslik, sb, 530, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;


        }
    }
}
