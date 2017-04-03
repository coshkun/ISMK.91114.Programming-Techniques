using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.while_cift_sayılar
{
    class Program
    {
        /*
        klavyeden girilen sayıya kadar olan 
        çift sayıları gösteren programı 
        while ile yazınız. 
        */
        static void Main(string[] args)
        {
            int sayi = 0;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çift aralık:");
            int i = 0;
            while (i <= sayi)
            {
                if (i%2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
