using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random.ornek_soru1
{
    class Program
    {
        /*
                program çalıştığında 0 ile 6 arasında rastgele sayı üretip,
            bu sayı 2'ye eşit olduğunda sonucu ekranda gösterip,
            yazının rengini kırmızı, arkaplan rengini beyaz yapacak,
            5' eşit olduğunda sonucunu ekranda yazdırıp,
            yazı rengini sarı arkaplan zemin rengini mavi yapıp,
            ekranda gösteren programı yazınız. 
        */
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(6);

            if (x == 2)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else if (x == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
            }
            Console.WriteLine(x);

            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
