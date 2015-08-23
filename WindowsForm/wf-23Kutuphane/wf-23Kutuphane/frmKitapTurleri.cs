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
    public partial class frmKitapTurleri : Form
    {
        public frmKitapTurleri()
        {
            InitializeComponent();
        }

        private void frmKitapTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cKitapTuru kt = new cKitapTuru();
            txtID.Text = Convert.ToString(kt.SonIDGetir());
            kt.KitapTurleriGetir(lbKitapTurleri);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cKitapTuru kt = new cKitapTuru();
            if (txtKitapTuru.Text.Trim() != String.Empty)
            {
                if (kt.KitapTuruKontrol(txtKitapTuru.Text.Substring(0, 1).ToUpper() + txtKitapTuru.Text.Substring(1).ToLower()))
                {
                    MessageBox.Show("Aynı tür mevcut..");
                    txtKitapTuru.Clear();
                    txtKitapTuru.Focus();
                }
                else
                {
                    //bool sonuc = kt.KitapTuruEkle(txtID.Text, txtKitapTuru.Text);
                    kt.Id = Convert.ToInt32(txtID.Text);
                    kt.KitapTuru = txtKitapTuru.Text;
                    bool sonuc = kt.KitapTuruEkle(kt);
                    if (sonuc)
                    {
                        MessageBox.Show("Kitap Türü Kayıt Edildi !!");
                        txtID.Text = Convert.ToString(kt.SonIDGetir());
                        kt.KitapTurleriGetir(lbKitapTurleri);
                        txtKitapTuru.Clear();
                        txtKitapTuru.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Gerçekleşmedi. :(");
                        txtKitapTuru.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kitap Türü Boş Geçilemez..");
            }

        }

    }
}
