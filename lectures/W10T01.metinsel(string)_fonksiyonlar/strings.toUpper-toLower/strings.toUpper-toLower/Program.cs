using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings.toUpper_toLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Programlama Teknikleri";

            Console.WriteLine("Büyük: " + metin.ToUpper());
            Console.WriteLine("Küçük: " + metin.ToLower());

            Console.ReadKey();
        }
    }
}
