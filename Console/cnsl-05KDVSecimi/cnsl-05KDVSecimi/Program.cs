using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_05KDVSecimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürünün Fiyatını Giriniz : ");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---KDV ORANLARI---");
            Console.WriteLine("1 - Gıda Ürünleri : %1");
            Console.WriteLine("2 - Sağluk Ürünleri : %8");
            Console.WriteLine("3 - Diğer Ürünler : %18");
            int secim = Convert.ToInt32(Console.ReadLine());


            // fiyat + (fiyat * 1(KDV ORANI) / 100)
            if (secim == 1)
                Console.WriteLine("Fiyatı : {0} KDV+Fiyat : {1} KDV : {2}", fiyat, fiyat + (fiyat * 1 / 100), (fiyat * 1 / 100));
            else if (secim == 2)
                Console.WriteLine("Fiyatı : {0} KDV+Fiyat : {1} KDV : {2}", fiyat, fiyat + (fiyat * 8 / 100), (fiyat * 8 / 100));
            else if (secim == 3)
                Console.WriteLine("Fiyatı : {0} KDV+Fiyat : {1} KDV : {2}", fiyat, fiyat + (fiyat * 18 / 100), (fiyat * 18 / 100));
            else
                Console.WriteLine("Secim Tanımlanmamıştır.!!");
            
            Console.ReadKey();
        }
    }
}
