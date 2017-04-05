using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz:");
            int x = Convert.ToInt32(Console.ReadLine()) ;
            int toplam = 0;
            do
            {

                toplam += x;
                x--;
            }
            while (x>=0);

            Console.WriteLine("Toplam Sonucu=" + toplam);
                Console.ReadKey();

        }
    }
}
