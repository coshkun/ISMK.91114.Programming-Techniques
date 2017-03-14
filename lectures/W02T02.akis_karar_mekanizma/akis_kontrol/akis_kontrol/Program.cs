using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sonuc;
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine("10.dan büyük sayı girdiniz.");
                sonuc = x * 5;
                Console.WriteLine("saının 5 katı: " + sonuc);

                if (sonuc == 55)
                {
                    sonuc = sonuc / 2;
                    Console.WriteLine("sonuç 55 ise yarısını alırız: " + sonuc);
                }
                else
                {
                    Console.WriteLine("sonuç 55 olmadığı için bölme yapılamadı.");
                }
            }
            else if (x == 5)
            {
                Console.WriteLine("x, 5'tir.");
            }
            else if (x != 8)
            {
                Console.WriteLine("x, 8 değildir.");
            }
            else
            {
                Console.WriteLine("10.dan küçük sayı girdiniz.");
            }

            Console.ReadKey();
        }
    }
}
