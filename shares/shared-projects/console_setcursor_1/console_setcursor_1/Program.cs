using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_setcursor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            Console.Write("Lütfen Adınızı Giriniz:");
            x = Console.ReadLine();
            for(int i=3;i<70;i++)
            {          
                Console.SetCursorPosition(i, 20);
                Console.ResetColor();
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(x);               
                for (int y = 0; y < 10000; y++)
                    for (int z = 0; z < 10000; z++) ;

            }
            Console.ReadKey();
        }
    }
}
