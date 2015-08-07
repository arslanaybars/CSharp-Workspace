using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_11WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while (i < 20)
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}

            Console.Write("Bir sayi giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayi daha giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int toplam = 0;

            if (sayi1 > sayi2)
            {
                while (sayi1 >= sayi2)
                {
                    Console.WriteLine(sayi2);
                    toplam += sayi2;
                    sayi2++;
                }
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("Sayi1 ve Sayi2 eşittir ve sayi " + sayi1);
                toplam = sayi1;
            }
            else
            {
                while (sayi2 >= sayi1)
                {
                    Console.WriteLine(sayi1);
                    toplam += sayi1;
                    sayi1++;
                }
            }

            Console.WriteLine("\nToplam = {0}", toplam);

            Console.ReadKey();
        }
    }
}
