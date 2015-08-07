using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_06mode
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayi1 % sayi2 -> mode değerini yani iki sayının birbirine bölümünden kalanı verir

            Console.Write("1. sayiyi giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayiyi giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 % sayi2 == 0)
                Console.WriteLine("Sayi Tam Bölünebilir");
            else
                Console.WriteLine("Bölünemez ve kalan : {0}", sayi1 % sayi2);

            Console.ReadKey();
        }
    }
}
