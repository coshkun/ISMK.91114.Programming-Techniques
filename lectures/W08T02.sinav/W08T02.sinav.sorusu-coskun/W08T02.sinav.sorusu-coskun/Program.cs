using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08T02.sinav.sorusu_coskun
{
    class Program
    {
        /* 
        Random türünden üretilen (1 ile 15 arası) sayıyı bulan program için;
        
            1-Eğer randomla üretilen sayı küçükse
        klavyeden girilen sayıyı "büyütün" mesajını verip
        console arka plan rengini KIRMIZI, yapan
            2-Klavyeden girilen sayı randomdan büyükse
        girilen sayıyı "küçültün" mesazını verip arka planı 
        YESIL yapan,
            3-sayı bulundugu taktirde ekrana "tebrikler" yazıp
        arka plan rengini MAVİ yapan,

        5 tahmin hakkı veren, tahmin yürütme oyununu yazınız.

        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 15);
            int tahmin = 0;
            int deneme = 5;

            Console.WriteLine("Bir sayı giriniz..");

            while (deneme > 0)
            {
                deneme--;
                try { tahmin = Convert.ToInt32(Console.ReadLine()); } catch(Exception e) { Console.WriteLine(e.Message); continue; }

                if (r < tahmin)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tekrar deneyin, daha KÜÇÜK bir sayı giriniz.");
                    Console.ResetColor();
                }
                else if (tahmin < r)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tekrar deneyin, daha BÜYÜK bir sayı giriniz.");
                    Console.ResetColor();
                }
                else if (r == tahmin)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tebrikler bildiniz.");
                    Console.ReadKey(); // wait for user.
                    Console.ResetColor();
                    break;
                }
            }


            if (r != tahmin)
            {
                Console.Clear();
                Console.WriteLine("Üzgünüm Başarısız oldunuz, hoşçakalın..");
                Console.ReadKey();
            }

        }
    }
}
