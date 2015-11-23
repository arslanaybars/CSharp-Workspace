using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class UyeKayit : System.Web.UI.Page
    {

        SaglikUrunleriEntities ent = new SaglikUrunleriEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            if (EmailKontrol(txtEmail.Text))
            {
                lblMesaj.Text = "Email adresi önceden kayıtlı";
            }
            else
            {
                lblMesaj.Text = "";
                UyeEkle();
                
            }
        }

        private void UyeEkle()
        {
            Uyeler uye = new Uyeler();
            uye.kullaniciad = txtEmail.Text;
            uye.ad = txtAdi.Text;
            uye.soyad = txtSoyadi.Text;
            uye.sifre = txtSifre.Text;
            uye.tckimlikno = txtTCKNo.Text;
            uye.tarih = DateTime.Now;
            uye.adres = txtAdres.Text;
            uye.il = txtIl.Text;
            uye.ilce = txtIlce.Text;
            uye.telefon = txtTelefon.Text;

            if (cbxOkudum.Checked)
            {
                ent.Uyeler.Add(uye);
                ent.SaveChanges();
                Temizle();
                lblMesaj.Text = "Uye kaydınız yapılmıştır.";
            }
            else
            {
                lblMesaj.Text = "Sözleşmeyi okuyup onaylayınız.";
            }
        }

        private void Temizle()
        {
            txtEmail.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtSifre.Text = "";
            txtAdres.Text = "";
            txtTCKNo.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtTelefon.Text = "";
            cbxOkudum.Checked = false;
            txtEmail.Focus();
        }

        private bool EmailKontrol(string email)
        {
            var sonuc = (from mail in ent.Uyeler
                          where mail.kullaniciad == email
                          select mail).Count();

            if (sonuc > 0)
            {
                return true;
            }
            return false;
        }
    }
}