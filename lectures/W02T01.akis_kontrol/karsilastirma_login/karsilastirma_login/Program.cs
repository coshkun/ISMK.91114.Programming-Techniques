using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karsilastirma_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;
            Console.WriteLine("Kullanı adını giriniz:");
            kullaniciadi = Console.ReadLine();
            Console.WriteLine("Sifre giriniz:");
            sifre = Console.ReadLine();

            bool x = kullaniciadi == "admin" && sifre == "123456";
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
