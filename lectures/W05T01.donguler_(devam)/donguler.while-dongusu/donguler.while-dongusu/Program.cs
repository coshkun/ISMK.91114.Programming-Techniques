using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.while_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int sayi, toplam = 0;

            while (x)
            {
                Console.WriteLine("Sayı gir lan.. : ");
                sayi = int.Parse(Console.ReadLine());

                toplam = (sayi * ++sayi) / 2;
                Console.WriteLine("Toplam: " + toplam);

                if (toplam > 50)
                {
                    Console.WriteLine("Sonuç 50'yi geçtiği için döngüden çıkıldı.");
                    x = false;
                }
            }
            Console.ReadKey();
        }
    }
}
