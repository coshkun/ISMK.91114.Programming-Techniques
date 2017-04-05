using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu_toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            bool durum = true;
            char e;
            for (;durum;)
            { 
            Console.Write("Lütfen bir sayı giriniz:");
            for(int x=Convert.ToInt32(Console.ReadLine());x>0;x--)
            {
                toplam += x;
                
            }
            Console.WriteLine("Toplam Sonuç: " + toplam);
                Console.WriteLine("Çıkış Yapılsın mı?: Evet(e) Hayır(h)");
                e = Convert.ToChar(Console.ReadLine());
                if (e == 'e' || e == 'E')
                    durum = false;
                else if (e == 'h' || e == 'H')
                    continue;
             
            }
            
        }
    }
}
