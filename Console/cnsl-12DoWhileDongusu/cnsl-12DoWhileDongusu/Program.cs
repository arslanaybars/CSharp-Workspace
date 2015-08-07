using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_12DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifrenizi giriniz : ");
            string sifre = Console.ReadLine();

            int sayac = 0;

            do
            {
                // sifre 9999 girilinceye kadar sifre istemeye devam eden console uygulaması
                Console.Write("\nŞifrenizi tekrar giriniz : ");
                sifre = Console.ReadLine();
                sayac++;
            } while (sifre != "9999" && sayac != 2);

            if (sifre == "9999")
                Console.Write("\nHoşgeldiniz\n");

            Console.WriteLine("\nŞifre deneme hakkınız bitti. Geçmiş olsun.");

            Console.ReadKey();
        }
    }
}
