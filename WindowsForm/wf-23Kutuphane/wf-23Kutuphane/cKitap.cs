using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wf_23Kutuphane
{
    class cKitap
    {
        private int _id;
        private string _kitapadi;
        private string _kitapturu;
        private string _kitapyazari;
        private string _kitapyayinevi;
        private string _basimtarihi;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Kitapadi
        {
            get { return _kitapadi; }
            set { _kitapadi = value; }
        }

        public string Kitapturu
        {
            get { return _kitapturu; }
            set { _kitapturu = value; }
        }

        public string Kitapyazari1
        {
            get { return _kitapyazari; }
            set { _kitapyazari = value; }
        }

        public string Kitapyazari
        {
            get { return _kitapyazari; }
            set { _kitapyazari = value; }
        }

        public string Kitapyayinevi
        {
            get { return _kitapyayinevi; }
            set { _kitapyayinevi = value; }
        }

        public string Basimtarihi
        {
            get { return _basimtarihi; }
            set { _basimtarihi = value; }
        }
        #endregion

        public int SonIDGetir()
        {
            int ID = 0;
            StreamWriter DosyaYaz = new StreamWriter("Kitaplar.txt", true);
            DosyaYaz.Close();
            StreamReader DosyaOku = new StreamReader("Kitaplar.txt");
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
        public bool KitapKontrol(string KitapAdi, string KitapYazari)
        {
            StreamReader DosyaOku = new StreamReader("Kitaplar.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == KitapAdi && Degerler[3] == KitapYazari)
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

        public bool KitapEkle(cKitap k)
        {
            StreamWriter DosyaEkle = new StreamWriter("Kitaplar.txt", true);
            DosyaEkle.WriteLine(k._id.ToString() + ";" + k._kitapadi + ";" + k._kitapturu + ";" + k._kitapyazari + ";" + k._kitapyayinevi + ";" + k._basimtarihi);
            DosyaEkle.Close();
            return true;
        }
    }
}
