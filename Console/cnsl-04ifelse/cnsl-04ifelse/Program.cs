using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_04ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayiyi giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayiyi giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("1. sayi daha büyüktür");
            else if (sayi1 == sayi2)
                Console.WriteLine("Sayilar eşittir");
            else
                Console.WriteLine("2. sayi daha büyüktür");

            Console.ReadKey();
        }
    }
}
