using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_10ToplamBul
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                toplam += i;
            }
            Console.WriteLine(toplam);

            Console.ReadKey();
        }
    }
}
