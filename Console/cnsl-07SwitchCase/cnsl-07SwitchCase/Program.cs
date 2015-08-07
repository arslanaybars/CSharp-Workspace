using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_07SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mevsim Giriniz : ");
            string mevsim = Console.ReadLine().ToLower();

            switch (mevsim)
            {
                case "kis":
                    Console.WriteLine("Aralık");
                    Console.WriteLine("Ocak");
                    Console.WriteLine("Şubat");
                    break;
                case "sonbahar":
                    Console.WriteLine("Mart");
                    Console.WriteLine("Nisan");
                    Console.WriteLine("Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran");
                    Console.WriteLine("Temmuz");
                    Console.WriteLine("Ağustos");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Eylül");
                    Console.WriteLine("Ekim");
                    Console.WriteLine("Kasım");
                    break;
                default:
                    Console.Write("Hatalı Giriş");
                    break;
            }
            Console.ReadKey();
        }
    }
}
