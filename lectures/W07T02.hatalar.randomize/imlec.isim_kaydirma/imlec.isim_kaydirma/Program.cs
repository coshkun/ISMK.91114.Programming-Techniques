using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlec.isim_kaydirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = string.Empty;

            Console.WriteLine("Adinizi Giriniz: ");
            isim = Console.ReadLine().Trim();

            

            if (isim == String.Empty)
                return;

            for (int i = 0; i < (Console.WindowWidth - isim.Length) / 2; i++)
            {
                Console.SetCursorPosition(i, Console.WindowHeight / 2);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(isim);
                Console.ResetColor();
                System.Threading.Thread.Sleep(100);
            }

            Console.SetCursorPosition(0, (Console.WindowHeight / 2)+1);

            Console.ReadKey();
        }
    }
}
