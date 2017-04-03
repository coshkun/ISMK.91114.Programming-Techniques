using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.@while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            while (a<10)
            {
                a++;
                Console.Write(a + " ");
            }

            Console.ReadKey();
        }
    }
}
