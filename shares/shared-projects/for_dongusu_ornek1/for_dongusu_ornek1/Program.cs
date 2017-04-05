using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu_ornek1//klavyeden girilen harfe göre z harfine kadar olan harfleri sırala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Harf Giriniz:");
            for (char x =Convert.ToChar(Console.ReadLine()); x <= 'z'; x++)
                Console.Write(x + " ");
            Console.ReadKey();
        }
    }
}
