using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_01Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.Write("Hello World");
            System.Console.Write("İsminizi giriniz : ");
            String isim = Console.ReadLine();

            Console.WriteLine("Merhaba " + isim);
            Console.ReadKey();

            //System.Console.ReadKey();
            //System.Console.RealLine();
        }
    }
}
