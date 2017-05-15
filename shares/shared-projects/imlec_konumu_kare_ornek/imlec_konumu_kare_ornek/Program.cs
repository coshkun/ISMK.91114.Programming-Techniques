using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlec_konumu_kare_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 20; x <= 50; x++)
            {
                Console.SetCursorPosition(x, 5);
                Console.Write("*");

            }
            for (int y = 5; y <= 20; y++)
            {
                Console.SetCursorPosition(50, y);
                Console.Write("*");
            }
            for (int z = 50; z >= 20; z--)
            {
                Console.SetCursorPosition(z, 20);
                Console.Write("*");
            }
            for (int t = 5; t <= 20; t++)
            {
                Console.SetCursorPosition(20, t);
                Console.Write("*");
            }


            Console.ReadKey();


        }
    }
}
