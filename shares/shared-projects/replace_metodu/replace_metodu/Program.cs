using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Bılgısayar Sıstemlerı";
            x = x.Replace('ı', 'i');
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
