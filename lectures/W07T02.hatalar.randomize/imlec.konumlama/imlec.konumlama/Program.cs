using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlec.konumlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.SetCursorPosition(119, 29);
            int h = Console.WindowHeight -1;
            int w = Console.WindowWidth -1;
            int kare_w = 20, kare_h = 10;
            int a = 0, b = 0, top = 10;

            a = (w - kare_w) / 2;
            //Console.SetCursorPosition(a, 0);   // Üst Kenar
            for (int i = 0; i < kare_w; i++)
            {
                Console.SetCursorPosition(a + i, top);
                Console.WriteLine('*');
                b = a + i;
            }

            //Console.SetCursorPosition(b, 0);    // Sağ Kenar
            for (int i = 0; i < kare_h; i++)
            {
                Console.SetCursorPosition(b, top + i);
                Console.WriteLine('*');
            }

            //Console.SetCursorPosition(a, 0);  // Sol Kenar
            for (int i = 0; i < kare_h; i++)
            {
                Console.SetCursorPosition(a, top + i);
                Console.WriteLine('*');
            }

            //Console.SetCursorPosition(a, kare_h);
            for (int i = 0; i < kare_w; i++)
            {
                Console.SetCursorPosition(a + i, top + kare_h);
                Console.WriteLine('*');
            }

            //Console.WriteLine('*');
            Console.ReadKey();
        }
    }
}
