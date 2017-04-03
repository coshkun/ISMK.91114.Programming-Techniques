using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_konsol_hesap_makinesi
{
    class Program
    {
        /*
        Klavyeden girilen 2 sayıyı, ekranda secilecek olan işleme göre,
        toplama, cıkarma, çarpma bölme yapan programı yazınız.
        */
        static void Main(string[] args)
        {
            float x, y, z = 0;
            Console.Write("Birinci sayıyı giriniz: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            y = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nBir işlem seciniz:");
            Console.WriteLine("========================");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Çıkarma");
            Console.WriteLine("3.Çarpma");
            Console.WriteLine("4.Bölme");
            string sec = Console.ReadLine();

            if (sec == "1" || sec == "+")
                z = x + y;
            else if (sec == "2" || sec == "-")
                z = x - y;
            else if (sec == "3" || sec == "*")
                z = x * y;
            else if (sec == "4" || sec == "/")
                z = x / y;
            else
                Console.WriteLine("Geçersiz seçim yaptınız.");

            Console.WriteLine("========================");
            Console.WriteLine("Sonuç: " + z);


            Console.ReadKey();
        }
    }
}
