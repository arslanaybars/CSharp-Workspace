using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlwf_06StokTakibi
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        BindingSource bs1;

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cKategori k = new cKategori();
            k.KategorileriGetir(cbKategoriler);

            cUrun u = new cUrun();

            DataBagla();

            u.UrunleriGetir(lvUrunler);
            u.KacinciUrun(0);
            Konum();
        }

        private void DataBagla()
        {
            cUrun u = new cUrun();
            ds = u.UrunleriGetir();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Urunler"];

            txtUrunID.DataBindings.Clear();
            txtUrunKodu.DataBindings.Clear();
            txtUrunAdi.DataBindings.Clear();
            txtKategoriNo.DataBindings.Clear();
            txtKategori.DataBindings.Clear();
            txtMiktar.DataBindings.Clear();
            txtBirimFiyat.DataBindings.Clear();
            txtKritikSeviye.DataBindings.Clear();

            txtUrunID.DataBindings.Add("Text", bs1, "UrunID");
            txtUrunKodu.DataBindings.Add("Text", bs1, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", bs1, "urunAdi");
            txtKategoriNo.DataBindings.Add("Text", bs1, "KategoriNo");
            txtKategori.DataBindings.Add("Text", bs1, "KategoriAd");
            txtMiktar.DataBindings.Add("Text", bs1, "Miktar");
            txtBirimFiyat.DataBindings.Add("Text", bs1, "BirimFiyat");
            txtKritikSeviye.DataBindings.Add("Text", bs1, "KritikSeviye");

            txtUrunID2.DataBindings.Clear();
            txtUrunKodu2.DataBindings.Clear();
            txtUrunAdi2.DataBindings.Clear();

            txtUrunID2.DataBindings.Add("Text", bs1, "UrunID");
            txtUrunKodu2.DataBindings.Add("Text", bs1, "UrunKodu");
            txtUrunAdi2.DataBindings.Add("Text", bs1, "urunAdi");

        }

        private void Konum()
        {
            cUrunHareket uh = new cUrunHareket();
            uh.UrunHareketleriGetirByUrunID(lvHareketler, Convert.ToInt32(txtUrunID.Text));
            
            tsKonum.Text = (bs1.Position + 1) + " / " + bs1.Count;

        }

        private void tsNext_Click(object sender, EventArgs e)
        {
            bs1.Position += 1;
            Konum();
        }

        private void tsPrev_Click(object sender, EventArgs e)
        {
            bs1.Position -= 1;
            Konum();
        }

        private void tsLast_Click(object sender, EventArgs e)
        {
            bs1.Position = bs1.Count;
            Konum();
        }

        private void tsFirst_Click(object sender, EventArgs e)
        {
            bs1.Position = 0;
            Konum();
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            cUrun u = new cUrun();
            bs1.Position = u.KacinciUrun(Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[4].Text));
            Konum();
        }

        private void txtKodaGore_TextChanged(object sender, EventArgs e)
        {
            cUrun u = new cUrun();
            u.UrunleriGetirByKodaGore(lvUrunler, txtKodaGore.Text);
        }

        private void txtKategoriyeGore_TextChanged(object sender, EventArgs e)
        {
            cUrun u = new cUrun();
            u.UrunleriGetirByKategoriyeGore(lvUrunler, txtKategoriyeGore.Text);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cUrun u = new cUrun();
            u.UrunleriGetirByAdaGore(lvUrunler, txtAdaGore.Text);
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cKategori k = (cKategori)cbKategoriler.SelectedItem;
            //cKategori k = cbKategoriler.SelectedItem as cKategori;
            txtKategori.Text = k.KategoriAd;
            txtKategoriNo.Text = Convert.ToString(k.KategoriNo);

            //cKategori k = new cKategori();
            //txtKategori.Text = cbKategoriler.SelectedItem.ToString();
            //txtKategoriNo.Text = k.KategoriNoGetirByKategoriyeGore(cbKategoriler.SelectedItem.ToString()).ToString();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsSil.Enabled = false;
            tsDegistir.Enabled = false;
            bs1.AddNew();
            txtUrunKodu.Focus();
        }

        private void tsVazgec_Click(object sender, EventArgs e)
        {
            bs1.CancelEdit();
            tsKaydet.Enabled = false;
            tsSil.Enabled = true;
            tsDegistir.Enabled = true;
            Konum();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "")
            {
                cUrun u = new cUrun();
                if (u.UrunKontrol(txtUrunKodu.Text, txtUrunAdi.Text))
                {
                    MessageBox.Show("Aynı Ürün Daha Önce Girilmiş");
                    txtUrunKodu.Focus();
                }
                else
                {
                    u.UrunKodu = txtUrunKodu.Text;
                    u.UrunAd = txtUrunAdi.Text;
                    u.KategoriNo = Convert.ToInt32(txtKategoriNo.Text);
                    if (txtBirimFiyat.Text.Trim() == "")
                        txtBirimFiyat.Text = "0";
                    u.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                    if (txtKritikSeviye.Text.Trim() == "")
                        txtKritikSeviye.Text = "0";
                    u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                    if (u.UrunEkle(u))
                    {
                        bs1.EndEdit();
                        MessageBox.Show("Urun Bilgileri Eklendi");
                        tsKaydet.Enabled = false;
                        tsSil.Enabled = true;
                        tsDegistir.Enabled = true;
                        u.UrunleriGetir(lvUrunler);
                        DataBagla();
                        Konum();
                    }
                }
            }
            else
            {
                MessageBox.Show("Urun Kodu ve Urun Adı Boş Geçilemez.");
            }
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "")
            {
                cUrun u = new cUrun();
                u.UrunID = Convert.ToInt32(txtUrunID.Text);
                u.UrunKodu = txtUrunKodu.Text;
                u.UrunAd = txtUrunAdi.Text;
                u.KategoriNo = Convert.ToInt32(txtKategoriNo.Text);
                if (txtBirimFiyat.Text.Trim() == "")
                    txtBirimFiyat.Text = "0";
                u.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                if (txtKritikSeviye.Text.Trim() == "")
                    txtKritikSeviye.Text = "0";
                u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                if (u.UrunGuncelle(u))
                {
                    bs1.EndEdit();
                    MessageBox.Show("Urun Bilgileri Güncellendi");
                    tsKaydet.Enabled = false;
                    tsSil.Enabled = true;
                    tsDegistir.Enabled = true;
                    u.UrunleriGetir(lvUrunler);
                    DataBagla();
                    Konum();
                }
            }
            else
            {
                MessageBox.Show("Urun Kodu ve Urun Adı Boş Geçilemez.");
            }
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Eminmisiniz?", "Silinsin Microsoft?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cUrun u = new cUrun();
                if (u.UrunSil(Convert.ToInt32(txtUrunID.Text)))
                {
                    MessageBox.Show("Ürün Bilgileri Silindi.");
                    u.UrunleriGetir(lvUrunler);
                    DataBagla();
                    Konum();
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

            txtIslemTarihi.Text = DateTime.Now.ToShortDateString();
            cbIslemTurleri.SelectedIndex = 0;
            txtAdet.Text = "1";
            txtBirimFiyat.Text = txtBirimFiyat.Text;
            txtTutar.Text = "0";
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            if (txtIslemTuru.Text == "Stok Giriş")
                cGenel.cariTipi = "Satici";
            else if (txtIslemTuru.Text == "Stok Çıkış")
                cGenel.cariTipi = "Alici";
            else
                cGenel.cariTipi = "Tüm Cariler";

            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();

            txtFirma.Text = cGenel.unvan;
            txtFirmaNo.Text = Convert.ToString(cGenel.cariNo);
            txtBelge.Focus();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                txtTutar.Text = "0";
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                txtTutar.Text = "0";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cUrunHareket uh = new cUrunHareket();
            uh.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
            uh.IslemTuru = txtIslemTarihi.Text;
            uh.FirmaNo = Convert.ToInt32(txtFirmaNo.Text);
            uh.UrunID = Convert.ToInt32(txtUrunID2.Text);
            uh.Belge = txtBelge.Text;
            uh.Adet = Convert.ToInt32(txtAdet.Text);
            uh.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
            uh.Tutar = Convert.ToDecimal(txtTutar.Text);

            int kayitNo = uh.UrunHareketEkle(uh);

            if (kayitNo > 0)
            {
                MessageBox.Show("Ürün Hareketleri Kayıt Edildi.");
                uh.UrunHareketleriGetirByUrunID(lvHareketler, uh.UrunID);
                cUrun u = new cUrun();
                if (u.StokGuncelleFromUrunHareketEkle(uh.UrunID, uh.Adet, uh.IslemTuru))
                {
                    MessageBox.Show("Stok Bilgileri Güncellendi.");
                }
            }
        }
    }
}
