using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_09ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Merhaba");
            }

            for (int i = 0; i <= 10; i=i+2)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
