using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());

            while (x>=0)
            {
                if (x % 2 == 0)
                    Console.Write(x + " ");
                x--;

            }
            Console.ReadKey();

        }
    }
}
