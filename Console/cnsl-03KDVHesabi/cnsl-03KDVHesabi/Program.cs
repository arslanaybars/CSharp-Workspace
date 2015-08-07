using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_03KDVHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürünün Fiyatını Giriniz : ");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            float kdv = fiyat * 18 / 100;
            Console.WriteLine("Fiyatı : " + fiyat);
            Console.WriteLine("KDV : {0}", kdv);
            Console.WriteLine("Fiyat + KDV : {0}", (fiyat + kdv));

            Console.ReadKey();
        }
    }
}