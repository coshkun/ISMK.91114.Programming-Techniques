using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomize.sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int y = r.Next(1,50);

            // Yazı rengini değiştirelim
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(y);
            //Yazı rengini resetliyelim
            Console.ResetColor();

            int y1 = r.Next(20);
            Console.WriteLine(y1);

            int y2 = r.Next();
            Console.WriteLine(y2);


            Console.ReadKey();
        }
    }
}
