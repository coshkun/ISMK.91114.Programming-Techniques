using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yakalama_mekanizmalari
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,toplam=0;
            bool z = true;
            while(z)
                {


                try
                {
                    Console.Write("1. Sayıyı Giriniz:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayıyı Giriniz:");
                    y = Convert.ToInt32(Console.ReadLine());
                    toplam = x + y;
                    Console.WriteLine("Toplam Sonucu:{0}", toplam);
                }
                catch (FormatException a)
                {
                    Console.WriteLine("OOPPSSS sayı yerine harf girdiniz!" + a.Message);
                }

                catch (OverflowException b)
                {
                    Console.WriteLine("Sayı giriş kapasitesi aşıldı" + b.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine("Bilinmeyen Hata: " + e.Message);
                }
                finally//Her halükarda burası çalışacaktır.
                {
                    string ok;
                    Console.WriteLine("Çıkış Yapılsınmı?");
                    ok = Console.ReadLine();
                    if (ok == "E" || ok == "e")
                        z = false;
                }
            }

        
        }
    }
}
