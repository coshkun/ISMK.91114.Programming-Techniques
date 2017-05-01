using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08T02.bisection_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = 0, upper = 100;
            int tahmin = (upper - lower) / 2;
            int g = tahmin;

            Console.WriteLine("Aklinizdan 1 ile 100 arası bir sayı tutunuz..");
            Console.WriteLine("Bilgisayar sayınızı bilmek için tahminler yürütecektir,");
            Console.WriteLine("tahmini büyütmek için (b), küçültmek için (k) giriniz.");
            Console.WriteLine("tahmin doğru ise (d) giriniz.\n");

            while (true)
            {
                tahmin = ((upper - lower) / 2);

                Console.Write("Giriş Yapın: ");
                g = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
