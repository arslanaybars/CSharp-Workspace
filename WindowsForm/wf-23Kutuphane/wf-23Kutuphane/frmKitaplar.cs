using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_23Kutuphane
{
    public partial class frmKitaplar : Form
    {
        public frmKitaplar()
        {
            InitializeComponent();
        }

        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cKitap k = new cKitap();
            txtID.Text = k.SonIDGetir().ToString();

            cKitapTuru kt = new cKitapTuru();
            kt.KitapTurleriGetir(cbKitapTurleri);
            cbKitapTurleri.SelectedIndex = 0;

            cYazar y = new cYazar();
            y.YazarlarGetir(cbYazarlar);
            cbYazarlar.SelectedIndex = 0;

            cYayinEvi yevi = new cYayinEvi();
            yevi.YayinEvleriniGetir(cbYayinEvleri);
            cbYayinEvleri.SelectedIndex = 0;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cKitap y = new cKitap();
            if (txtKitapAdi.Text.Trim() != "")
            {
                if (y.KitapKontrol(txtKitapAdi.Text, cbYazarlar.SelectedItem.ToString()))
                {
                    MessageBox.Show("Önceden Girilmiş!");
                }
                else
                {

                    y.Id = Convert.ToInt32(txtID.Text);
                    y.Kitapadi = txtKitapAdi.Text;
                    y.Kitapturu = cbKitapTurleri.SelectedItem.ToString();
                    y.Kitapyayinevi = cbYayinEvleri.SelectedItem.ToString();
                    y.Kitapyazari = cbYazarlar.SelectedItem.ToString();
                    y.Basimtarihi = DateTime.Now.ToShortDateString();
                    bool Sonuc = y.KitapEkle(y);
                    if (Sonuc)
                    {
                        MessageBox.Show("Kitap bilgileri kayıt edildi.");
                        txtID.Text = y.SonIDGetir().ToString();
                        txtKitapAdi.Clear();
                        txtKitapAdi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi!");
                        txtKitapAdi.Focus();
                    }
                }
            }
            else { MessageBox.Show("Kitap adı boş geçilemez!"); }
        }
    }
}
