using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int x = 0; x < 20; x++)
            //    Console.WriteLine("Merhaba.. Fondiple..Kalan şişe sayısı: {0}", 20-x);

            //Console.ReadKey();

            Console.WriteLine("0'dan 100'e ..Çift Sayılar:");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("\n\n1'den 100'e ..Tek Sayılar:");
            for (int i = 1; i < 101; i += 2)
            {
                Console.Write(" {0} ", i);
            }


            Console.ReadKey();
        }
    }
}
