using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y,z;
            Console.Write("1. Sayıyı Giriniz:");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            y = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Toplam işlemi için +");
            Console.WriteLine("Çıkarma işlemi için -");
            Console.WriteLine("Çarpma işlemi için *");
            Console.WriteLine("Bolme işlemi için /");
            Console.Write("Seçim yapınız:");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == '+')
            {
                z = x + y;
                Console.WriteLine("Toplam Sonucu:" + z);
            }
            else if (secim == '-')
            {
                z = x - y;
                Console.WriteLine("Çıkarma Sonucu:" + z);
            }
            else if (secim == '*')
            {
                z = x * y;
                Console.WriteLine("Çarpım Sonucu:" + z);
            }
            else if (secim == '/')
            {
                z = x / y;
                Console.WriteLine("Bölüm Sonucu:" + z);
            }
            else
                Console.WriteLine("Seçim Yapmadınız.");

            Console.ReadKey();
        }
    }
}
