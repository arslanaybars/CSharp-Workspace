using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace wf_23Kutuphane
{
    class cKitapTuru
    {
        private int _id;
        private string _kitapTuru;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string KitapTuru
        {
            get { return _kitapTuru; }
            set { _kitapTuru = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower(); }
        }

        public int SonIDGetir()
        {
            int ID = 0;
            StreamWriter DosyaYaz = new StreamWriter("KitapTurleri.txt", true);
            DosyaYaz.Close();

            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");
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

        public void KitapTurleriGetir(ListBox liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");

            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                liste.Items.Add(Degerler[1]);
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public void KitapTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");

            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                liste.Items.Add(Degerler[1]);
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public bool KitapTuruEkle(string ID, string KitapTuru)
        {
            StreamWriter DosyaYaz = new StreamWriter("KitapTurleri.txt", true);
            DosyaYaz.WriteLine(ID + ";" + KitapTuru.Substring(0,1).ToUpper() + KitapTuru.Substring(1).ToLower());
            DosyaYaz.Close();

            return true;
        }

        public bool KitapTuruEkle(cKitapTuru kt)
        {
            StreamWriter DosyaYaz = new StreamWriter("KitapTurleri.txt", true);
            DosyaYaz.WriteLine(kt._id.ToString() + ";" + kt._kitapTuru);
            DosyaYaz.Close();
            
            return true;
        }

        public bool KitapTuruKontrol(string KitapTuru)
        {
            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == KitapTuru)
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
    }
}
