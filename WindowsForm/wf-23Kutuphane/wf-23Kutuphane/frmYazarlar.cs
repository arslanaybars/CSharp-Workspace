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
    public partial class frmYazarlar : Form
    {
        public frmYazarlar()
        {
            InitializeComponent();
        }

        private void frmYazarlar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cYazar y = new cYazar();
            txtID.Text = Convert.ToString(y.SonIDGetir());
            //y.KitapTurleriGetir(lbKitapTurleri);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cYazar y = new cYazar();
            if (txtAdi.Text.Trim() != String.Empty && txtSoyadi.Text.Trim() != String.Empty && txtEmail.Text.Trim() != String.Empty && txtTelefon.Text.Trim() != "(   )    -  -")
            {
                if (y.YazarKontrol(txtTelefon.Text.Substring(0, 1).ToUpper() + txtTelefon.Text.Substring(1).ToLower()))
                {
                    MessageBox.Show("Aynı tür mevcut..");
                    Temizle();
                }
                else
                {
                    //bool sonuc = kt.KitapTuruEkle(txtID.Text, txtKitapTuru.Text);
                    y.Id = Convert.ToInt32(txtID.Text);
                    y.Adi = txtAdi.Text;
                    y.Soyadi = txtSoyadi.Text;
                    y.Telefon = txtTelefon.Text;
                    y.Email = txtEmail.Text;
                    bool sonuc = y.YazarEkle(y);
                    if (sonuc)
                    {
                        MessageBox.Show("Yazar Kayıt Edildi !! " + y.Adi + " " + y.Soyadi );
                        txtID.Text = Convert.ToString(y.SonIDGetir());
                        //y.KitapTurleriGetir(lbKitapTurleri);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Gerçekleşmedi. :(");
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Yazar Adı, Soyadı, Telefonu boş geçilemez.");
            }
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdi.Focus();
        }
    }
}
