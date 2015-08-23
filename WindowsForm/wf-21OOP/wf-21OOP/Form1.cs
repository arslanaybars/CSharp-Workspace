using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_21OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Telefon tel1 = new Telefon();
            //tel1.Marka = "Apple";
            //tel1.Model = "Iphone 6";
            //MessageBox.Show("Markası : " + tel1.Marka + ", Modeli : " + tel1.Model);

            //Telefon tel2 = new Telefon("Samsung", "Note 4");
            //MessageBox.Show("Markası : " + tel2.Marka + ", Modeli : " + tel2.Model);

        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            Telefon tel = new Telefon();
            MessageBox.Show(tel.AramaYap(txtTelNo.Text));
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            Telefon tel = new Telefon();
            MessageBox.Show(tel.SmsAt(txtTelNo.Text, txtMesaj.Text));
        }
    }

    partial class Urun
    {
        public string urunAdi;
        public string urunKodu;
    }

    class Telefon
    {
        private string _marka;
        private string _model;
        private string _hafiza;
        private string _ekran;
        private string _kamera;
        private decimal _fiyat;

        #region Properties
        public string Marka
        {
            get { return _marka; }
            set { _marka = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Hafiza
        {
            get { return _hafiza; }
            set { _hafiza = value; }
        }

        public string Ekran
        {
            get { return _ekran; }
            set { _ekran = value; }
        }

        public string Kamera
        {
            get { return _kamera; }
            set { _kamera = value; }
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        #endregion

        public Telefon(string markasi, string modeli)
        {
            _marka = markasi;
            _model = modeli;
        }

        public Telefon()
        {

        }

        public string AramaYap(string telefonNumarasi)
        {
            return telefonNumarasi + " nolu telefon aranıyor... ";
        }

        public string SmsAt(string telefonNumarasi, string mesaj)
        {
            return telefonNumarasi + " nolu telefona \n" + mesaj + "\nmesajı gönderiliyor.";
        }

        ~Telefon()
        {
            MessageBox.Show("Nesneler hafızadan atılıyor...");
        }
    }
}
