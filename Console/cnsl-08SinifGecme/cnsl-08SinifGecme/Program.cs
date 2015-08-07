using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_SinifGecme
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            Console.Write("Vizeyi giriniz : ");
            vize = int.Parse(Console.ReadLine());
            Console.Write("Finali giriniz : ");
            final = Convert.ToInt32(Console.ReadLine());

            if (vize < 100 && vize >= 0 && final < 100 && final >= 0)
            {
                double ort = (Convert.ToDouble(vize + final) / 2);

                Console.WriteLine("Ortalamaniz : {0}", ort);

                if (ort >= 50 && ort < 60)
                    Console.WriteLine("E ile Geçtiniz. ortalamanız : {0}", ort);
                else if (ort >= 60 && ort < 70)
                    Console.WriteLine("D ile Geçtiniz. ortalamanız : {0}", ort);
                else if (ort >= 70 && ort < 80)
                    Console.WriteLine("C ile Geçtiniz. ortalamanız : {0}", ort);
                else if (ort >= 80 && ort < 90)
                    Console.WriteLine("B ile Geçtiniz. ortalamanız : {0}", ort);
                else if (ort >= 90 && ort <= 100)
                    Console.WriteLine("A ile Geçtiniz. ortalamanız : {0}", ort);
                else
                    Console.WriteLine("F ile Kaldınız. ortalamanız : {0}", ort);
            }
            else
            {
                Console.WriteLine("Yanlış aralıkta vize veya final notu girdiniz.");
            }
            Console.ReadKey();
        }
    }
}
