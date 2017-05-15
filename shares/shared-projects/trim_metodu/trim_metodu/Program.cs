using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trim_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "   İsmek Yenibosna Bilişim Okulu        ";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(x.Trim());
            Console.WriteLine(x.TrimStart());
            Console.WriteLine(x.TrimEnd());
            Console.ReadKey();
        }
    }
}
