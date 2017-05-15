using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toUpper_toLower_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir metin giriniz= ");
            string metin = Console.ReadLine();

            Console.WriteLine("Metin büyük harf yapıldı."+metin.ToUpper());
            Console.WriteLine("Metin küçük harf yapıldı." + metin.ToLower());
            Console.ReadKey();

        }
    }
}
