using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_metodu
{
    class Program
    {
        public static void karsilastir(string metin1,string metin2)
        {
            int gelen=0;
            gelen = string.Compare(metin1, metin2);
            if (gelen == 1)
                Console.WriteLine("1. metin 2. metinden büyüktür");
          else  if(gelen==-1)
                Console.WriteLine("1. metin 2. metinden Küçüktür");
            else if(gelen == 0)
                Console.WriteLine("1. metin 2. metine eşittir.");

        }
        static void Main(string[] args)
        {
            string x, y;
            Console.WriteLine("1.Metni Giriniz:");
            x = Console.ReadLine();
            Console.WriteLine("2.Metni Giriniz:");
            y = Console.ReadLine();
            karsilastir(x, y);
            Console.ReadKey();

        }
    }
}
