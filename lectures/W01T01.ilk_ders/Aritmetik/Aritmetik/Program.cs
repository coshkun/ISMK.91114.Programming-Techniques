using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetik
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 21, j = 5, toplam, bolum, carpim, fark;

            toplam = x + j;
            carpim = x * j;
            bolum = x / j;
            fark = x - j;
            Console.WriteLine("Toplama Sonucu " + toplam);
            Console.WriteLine("------------------------");
            Console.WriteLine("Çarpım Sonucu " + carpim);
            Console.WriteLine("------------------------");
            Console.WriteLine("Bolüm Sonucu " + bolum);
            Console.WriteLine("------------------------");
            Console.WriteLine("Çıkarma Sonucu " + fark);
            Console.WriteLine("------------------------");

            Console.WriteLine(" ");
            Console.WriteLine("Pres any key for exit..");
            Console.ReadKey();
        }
    }
}
