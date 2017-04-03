using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.ornek_soru
{
    class Program
    {
        /*
        klavyeden girilen bir sayının
        asal olup olmadıgını bulan programı 
        for ile yapınız. 
        */
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Bir sayı giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());
            string msj = "";

            if (x < 0)
                msj = "Negatif bir sayı girdiniz. Asal sayılar 1'den başlayan doğal sayılardır.";
            else
            {

                for (int i = 2; i < 10; i++)
                {

                    msj = x + " Sayısı Asal sayıdır. ";

                    if (x % i == 0)
                    {
                        if (x == 1 || x == 2 || x == 3 || x == 5 || x == 7)
                        { msj = x + " Sayısı Asal sayıdır. "; break; }
                        else
                        { msj = "Sayı Asal değildir. "; break; }
                    }
                }
            }

            Console.Write(msj);

            Console.ReadKey();
        }
    }
}
