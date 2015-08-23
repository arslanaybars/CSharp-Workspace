using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wf_23Kutuphane
{
    class cYazar
    {
        private int _id;
        private string _adi;
        private string _soyadi;
        private string _telefon;
        private string _email;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); ; }
        }

        public string Soyadi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int SonIDGetir()
        {
            int ID = 0;
            StreamWriter DosyaYaz = new StreamWriter("Yazarlar.txt", true);
            DosyaYaz.Close();

            StreamReader DosyaOku = new StreamReader("Yazarlar.txt");
            string okunan = DosyaOku.ReadLine();

            if (okunan == null)
            {
                ID = 1;
            }
            else
            {
                while (okunan != null)
                {
                    string[] Degerler = okunan.Split(';');
                    ID = Convert.ToInt32(Degerler[0]) + 1;
                    okunan = DosyaOku.ReadLine();
                }
            }
            DosyaOku.Close();
            return ID;
        }

        public bool YazarEkle(cYazar y)
        {
            StreamWriter DosyaYaz = new StreamWriter("Yazarlar.txt", true);
            DosyaYaz.WriteLine(y._id.ToString() + ";" + y._adi + ";" + y._soyadi + ";" + y._telefon + ";" + y._email);
            DosyaYaz.Close();

            return true;
        }

        public bool YazarKontrol(string Telefon)
        {
            StreamReader DosyaOku = new StreamReader("Yazarlar.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[3] == Telefon)
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

        public void YazarlarGetir(ListView liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("Yazarlar.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                liste.Items.Add(Degerler[1]);
                liste.Items[sayac].SubItems.Add(Degerler[2]);
                liste.Items[sayac].SubItems.Add(Degerler[3]);
                liste.Items[sayac].SubItems.Add(Degerler[4]);
                liste.Items[sayac].SubItems.Add(Degerler[0]);
                sayac++;

                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public void YazarlarGetir(ComboBox liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("Yazarlar.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                liste.Items.Add(Degerler[1] + " " + Degerler[2]);

                sayac++;

                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public void YazarlarGetirByAdaGore(ListView liste, string AdaGore)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("Yazarlar.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degeler = okunan.Split(';');
                if (Degeler[1].ToLower().StartsWith(AdaGore.ToLower()))
                {
                    liste.Items.Add(Degeler[1]);
                    liste.Items[sayac].SubItems.Add(Degeler[2]);
                    liste.Items[sayac].SubItems.Add(Degeler[3]);
                    liste.Items[sayac].SubItems.Add(Degeler[4]);
                    liste.Items[sayac].SubItems.Add(Degeler[0]);
                    sayac++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
