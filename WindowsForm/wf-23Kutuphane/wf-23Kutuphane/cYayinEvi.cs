using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wf_23Kutuphane
{
    class cYayinEvi
    {
        private int _id;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _sehir;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Unvan
        {
            get { return _unvan; }
            set { _unvan = value; }
        }

        public string Yetkili
        {
            get { return _yetkili; }
            set { _yetkili = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string Sehir
        {
            get { return _sehir; }
            set { _sehir = value; }
        }


        public int SonIDGetir()
        {
            int ID = 0;
            StreamWriter DosyaYaz = new StreamWriter("YayinEvleri.txt", true);
            DosyaYaz.Close();

            StreamReader DosyaOku = new StreamReader("YayinEvleri.txt");
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

        public bool YayinEviEkle(cYayinEvi y)
        {
            StreamWriter DosyaYaz = new StreamWriter("YayinEvleri.txt", true);
            DosyaYaz.WriteLine(y._id + ";" + y._unvan + ";" + y._yetkili + ";" + y._telefon + ";" + y._adres + ";" + y._sehir);
            DosyaYaz.Close();

            return true;
        }

        public bool YayinEviKontrol(string Unvan)
        {
            StreamReader DosyaOku = new StreamReader("YayinEvleri.txt", true);
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                if (Degerler[1] == Unvan)
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

        public void YayinEvleriniGetir(ListView liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("YayinEvleri.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                liste.Items.Add(Degerler[1]);
                liste.Items[sayac].SubItems.Add(Degerler[2]);
                liste.Items[sayac].SubItems.Add(Degerler[3]);
                liste.Items[sayac].SubItems.Add(Degerler[4]);
                liste.Items[sayac].SubItems.Add(Degerler[5]);
                liste.Items[sayac].SubItems.Add(Degerler[0]);
                sayac++;

                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public void YayinEvleriniGetir(ComboBox liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("YayinEvleri.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');

                liste.Items.Add(Degerler[1]);
                sayac++;

                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public void YayinEvleriniGetirByAdaGore(string YayinEvineGore, ListView liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("YayinEvleri.txt");

            string okunan = DosyaOku.ReadLine();

            int sayac = 0;

            while (okunan != null)
            {
                string[] Degeler = okunan.Split(';');
                if (Degeler[1].ToLower().StartsWith(YayinEvineGore.ToLower()))
                {
                liste.Items.Add(Degeler[1]);
                liste.Items[sayac].SubItems.Add(Degeler[2]);
                liste.Items[sayac].SubItems.Add(Degeler[3]);
                liste.Items[sayac].SubItems.Add(Degeler[4]);
                liste.Items[sayac].SubItems.Add(Degeler[5]);
                liste.Items[sayac].SubItems.Add(Degeler[0]);
                sayac++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
