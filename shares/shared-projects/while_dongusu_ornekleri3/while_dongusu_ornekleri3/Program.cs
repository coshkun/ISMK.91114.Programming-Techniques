using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu_ornekleri3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            while (x >= 0)
            {
                toplam += x;
                x--;
            }
            Console.WriteLine("Toplam sonucu=" + toplam);
            Console.ReadKey();
        }
    }
}
