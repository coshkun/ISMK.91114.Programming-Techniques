using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int sayi,toplam=0;
            while(x)
            {
                Console.WriteLine("Lütfen sayı giriniz:");
                sayi = int.Parse(Console.ReadLine());

                toplam = (sayi * ++sayi) / 2;          
                Console.WriteLine("Toplam Sonucu=" + toplam);

                if (toplam > 50)
                {
                    Console.WriteLine("toplam Sonucu 50'den büyük olduğu için döngüden çıkış yapıldı.'");
                    x = false;
                }
                         
            }

            Console.ReadKey();
        }
    }
}
