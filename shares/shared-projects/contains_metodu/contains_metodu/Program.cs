using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contains_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string x = "Programalama teknikleri. Bilişim Okulu Yenibosna";

                Console.WriteLine("Aramak istediğiniz kelimeyi giriniz");
                bool arama = x.Contains(Console.ReadLine());
                if (arama == true)
                    Console.WriteLine("Aranan ifade bulundu");
                else
                    Console.WriteLine("Aranan ifade bulunamadı!");

                Console.WriteLine("Çıkış Yapılsın mı? Evet e veya devam için herhangi bir tuşa basın");
                if (Console.ReadLine() == "e")
                    break;

            }
        }
    }
}
