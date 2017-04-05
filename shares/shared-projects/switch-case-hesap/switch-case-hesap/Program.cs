using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_hesap
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi1, sayi2;
            Console.Write("1. sayıyı giriniz:");
            sayi1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            sayi2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Toplama işlemi için +");
            Console.WriteLine("Çıkarma işlemi için -");
            Console.WriteLine("Çarpma işlemi için *");
            Console.WriteLine("Bölme işlemi için /");
            char secim = Convert.ToChar(Console.ReadLine());

            switch(secim)
            {
                case '+':
                    Console.WriteLine("Toplam Sonucu:{0}", (sayi1 + sayi2));
                    if ((sayi1 + sayi2) > 100)
                    {
                        Console.Clear(); //console yapısını temizle
                        Console.WriteLine("Toplam sonucu 100 geçtiği için yarısı alındı:{0}", (sayi1 + sayi2) / 2);
                    }
                    break;
                case '-':
                    Console.WriteLine("Toplam Sonucu:{0}", (sayi1 - sayi2));
                    break;
                case '*':
                    Console.WriteLine("Toplam Sonucu:{0}", (sayi1 * sayi2));
                    break;
                case '/':
                    Console.WriteLine("Toplam Sonucu:{0}", (sayi1 / sayi2));
                    break;
            }

            Console.ReadKey();
        }
    }
}
