using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_odev_sorusu
{
    class Program
    {
        /* Klavyeden gelen 2 sayıyı bölüp sonuç tamsayı ise
        sonucu 1 arttırıp, oluşan yeni degeri 100'den büyük ve 120'ye eşit degil ise TRUE
        aksi halde FALSE yazdırılsın. işlem sonucu bitsel olarak 1 sola kaydırılıp nihayi sonuç 
        100'e eşitse ekrana "Kayan deger 100'e esit." değilse "Kayan deger 100'e esit değil." 
        yazılsın.
        */
        static void Main(string[] args)
        {
            int a, b, c;
            float snc = 0;

            Console.WriteLine("1.Sayıyı Giriniz: "); a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz: "); b = Convert.ToInt32(Console.ReadLine());

            snc = a / b;

            bool chk = (snc - (int)snc) > 0;  // tamsayı ise TRUE olur

            snc++;

            bool x = snc > 100 && snc != 120;
            Console.WriteLine(x);

            byte z = Convert.ToByte(snc);
            z = (byte) (z << 1);

            Console.WriteLine(z == 100 ? "Kayan deger 100'e esit." : "Kayan deger 100'e esit degil.");

            Console.WriteLine((int)snc);
            Console.ReadKey();

        }
    }
}
