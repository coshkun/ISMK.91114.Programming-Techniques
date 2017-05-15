using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_ornek_1
{
    class Program
    {
        public static void tekmi(int a)//public her tarafta erişilebilir olarak tanımlandı
        {
            int sonuc=0;
            if (sonuc == a % 2)
            Console.WriteLine("Girilen Sayı çifttir");  
            else
                Console.WriteLine("Girilen Sayı tektir");
        }

            static void Main(string[] args)
        {
            int x;
            Console.Write("Lütfen bir sayı giriniz");
            x = int.Parse(Console.ReadLine());
            tekmi(x);
            Console.ReadKey();
        }
    }
}
