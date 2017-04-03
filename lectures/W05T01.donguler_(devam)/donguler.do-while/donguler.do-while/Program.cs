using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            do
            {
                toplam += x;
                x--;
            } while (x>0);

            Console.Write("Toplam: {0}", toplam);
            Console.ReadKey();
        }
    }
}
