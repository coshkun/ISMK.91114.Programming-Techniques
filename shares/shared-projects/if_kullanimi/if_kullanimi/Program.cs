using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_kullanimi
{
    class Program
    {

        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 2 == 0)
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            else if (y % 2 == 1)
                Console.WriteLine("Girdiğiniz sayı Tektir.");
            else
                Console.WriteLine("Matematikte açık yakalandı.");

            Console.ReadKey();
        }
    }
}
