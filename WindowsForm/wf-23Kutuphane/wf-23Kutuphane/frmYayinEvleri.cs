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
    public partial class frmYayinEvleri : Form
    {
        public frmYayinEvleri()
        {
            InitializeComponent();
        }

        private void frmYayinEvleri_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            cYayinEvi y = new cYayinEvi();
            txtID.Text = Convert.ToString(y.SonIDGetir());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cYayinEvi y = new cYayinEvi();
            if (txtUnvan.Text.Trim() != String.Empty && txtYetkili.Text.Trim() != String.Empty && txtAdres.Text.Trim() != String.Empty && txtTelefon.Text.Trim() != "(   )    -  -" && txtAdres.Text.Trim() != String.Empty)
            {
                if (y.YayinEviKontrol(txtTelefon.Text.Substring(0, 1).ToUpper() + txtTelefon.Text.Substring(1).ToLower()))
                {
                    MessageBox.Show("Aynı tür mevcut..");
                    Temizle();
                }
                else
                {
                    //bool sonuc = kt.KitapTuruEkle(txtID.Text, txtKitapTuru.Text);
                    y.Id = Convert.ToInt32(txtID.Text);
                    y.Unvan = txtUnvan.Text;
                    y.Yetkili = txtYetkili.Text;
                    y.Telefon = txtTelefon.Text;
                    y.Sehir = txtSehir.Text;
                    y.Adres = txtAdres.Text;
                    bool sonuc = y.YayinEviEkle(y);
                    if (sonuc)
                    {
                        MessageBox.Show("Yayın Evi Kayıt Edildi !! ");
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
                MessageBox.Show("Yayın Evi Unvanı, Yetkilisi, Telefonu boş geçilemez.");
            }

            Temizle();
        }

        private void Temizle()
        {
            txtUnvan.Clear();
            txtYetkili.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtSehir.Clear();
            txtUnvan.Focus();
        }
    }
}
