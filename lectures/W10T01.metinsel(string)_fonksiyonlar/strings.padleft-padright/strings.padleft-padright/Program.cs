using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings.padleft_padright
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "İsmek";
            Console.WriteLine(x.PadLeft(15, '*'));
            Console.WriteLine(x.PadRight(15, '#'));
            Console.WriteLine((x.PadLeft(15, '*')) + x.PadRight(15, '#'));
            Console.ReadKey();

            x = x.Remove(1, 3);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
