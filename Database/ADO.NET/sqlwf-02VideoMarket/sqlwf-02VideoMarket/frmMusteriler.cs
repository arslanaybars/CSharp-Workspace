using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_02VideoMarket
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterileriGoster(lvMusteriler);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusteriAd = txtAdi.Text;
            m.MusteriSoyad = txtSoyadi.Text;
            m.Telefon = txtTelefon.Text;
            m.Adres = txtAdres.Text;

            if (txtAdi.Text.Trim() == string.Empty || txtSoyadi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Müşterinin ismini ve soyismini girmek zorundasin", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //TODO - Müşteri var mı kontrol
                if (m.MusteriKontrol(txtTelefon.Text))
                    MessageBox.Show("Müşteri Daha Once Kayıt Edilmiş");
                else
                {
                    bool sonuc = m.MusteriEkle(m);
                    //bool sonuc = m.MusteriEkle(txtAdi.Text, txtSoyadi.Text, txtTelefon.Text, txtAdres.Text);
                    if (sonuc)
                    {
                        MessageBox.Show("Müşteri Kayıt Edildi");
                        Temizle();
                        btnKaydet.Enabled = false;
                        m.MusterileriGoster(lvMusteriler);
                    }
                }
            }
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            txtNo.Text = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;   
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusteriNo = Convert.ToInt32(txtNo.Text);
            m.MusteriAd = txtAdi.Text;
            m.MusteriSoyad = txtSoyadi.Text;
            m.Telefon = txtTelefon.Text;
            m.Adres = txtAdres.Text;

            bool sonuc = m.MusteriGuncelle(m);
            if (sonuc)
            {
                MessageBox.Show("Müşteri Güncellendi");
                Temizle();
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                m.MusterileriGoster(lvMusteriler);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();

            m.MusteriNo = Convert.ToInt32(txtNo.Text);
            m.MusteriAd = txtAdi.Text;
            m.MusteriSoyad = txtSoyadi.Text;
            m.Telefon = txtTelefon.Text;
            m.Adres = txtAdres.Text;

            if ((MessageBox.Show("Silmek istiyor musunuz ?", "Silinsin Mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                bool sonuc = m.MusteriSil(m);
                
                if (sonuc)
                {
                    MessageBox.Show("Film Türü Silindi");
                    Temizle();
                    btnSil.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = false;
                    m.MusterileriGoster(lvMusteriler);
                }
            }
            else
            {

            }
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterileriGetirByAdaGore(txtAdaGore.Text, lvMusteriler);
        }

        private void Temizle()
        {
            txtNo.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }


    }
}
