using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concat_metodu
{
    class Program
    {
        public static void birlestir(string a,string b)
        {
            Console.WriteLine(string.Concat(a, b));
        }
        static void Main(string[] args)
        {
            string x = "Programlama", y = "Teknikleri";
            birlestir(x, y);
            Console.ReadKey();
        }
    }
}
