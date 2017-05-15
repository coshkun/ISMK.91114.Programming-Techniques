using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar.string_members
{
    class Program
    {
        static void Main(string[] args)
        {
            string n,m;
            Console.WriteLine("1.Metni gir:");
            n = Console.ReadLine();
            Console.WriteLine("2.Metni gir:");
            m = Console.ReadLine();
            int i = string.Compare(n, m, StringComparison.CurrentCultureIgnoreCase);

            sirala(n, m);
            birlestir(n, m);

            Console.WriteLine("Okul adında aramak için bir kelime yaz.");
            string s = Console.ReadLine();
            ara(s);

            Console.ReadKey();
        }

        public static void sirala(string a, string b)
        {
            int i = string.Compare(a, b, StringComparison.CurrentCultureIgnoreCase);

            if (i == -1)
                Console.WriteLine("1.Metin alfabetik olarak daha büyük");
            else if (i == 1)
                Console.WriteLine("2.Metin alfabetik olarak daha büyük");
            else
                Console.WriteLine("Metinler aynı");
        }
        public static void birlestir(string a, string b)
        {
            Console.WriteLine(string.Concat(a, b));
        }
        public static void ara(string kelime)
        {
            string x = "Programlama Teknikleri. Bilişim Okulu Yenibosna";
            if (x.Contains(kelime))
                Console.WriteLine("Aranan ifade bulundu.");
            else
                Console.WriteLine("Aranan ifade bulunamadaı.");
        }


    }
}
/* 
    Metinsel (String) Fonksiyonlar:
    1- Compare Methodu:
       iki metni karşılaştırır. eger 1. metin 2.metinden büyükse
       1 değeri, kısa ise -1 değeri, eşitse 0 değeri döndürür.
       z y x .... d c b a   -->  büyükten küçüğe sırala dır. 
       z en büyük, a en küçük sıradadır.
*/