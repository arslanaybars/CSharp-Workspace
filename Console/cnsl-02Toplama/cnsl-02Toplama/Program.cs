using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_02Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("1.Sayiyi giriniz : ");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayiyi giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam : " + (s1 + s2));
            Console.WriteLine("{0} + {1} = {2}", s1, s2, s1 + s2);

            int sonuc = s1 + s2;
            Console.WriteLine("Toplam : " + sonuc);
            Console.WriteLine("Toplam : {0}", sonuc); 

            Console.ReadKey();
        }
    }
}
