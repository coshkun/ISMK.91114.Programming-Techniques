using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_bitwise_shifting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 2;
            byte y = (byte) (x << 1);

            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
