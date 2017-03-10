using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 54676;
            double sayi = 2548 / 25;
            float sayi2 = 154.258f;
            float fgh = 59.25f;
            object y = "asdfgsadg";
            object z = 25455;
            object v = ';';

            bool xc = false;
            bool vb = 5 < 2;
            byte bnm = 255;
            string jkl = "aklsjdfh dfasojknf fdjndf";
            char tyu = 'h';

            //string say = Console.ReadLine();
            //Console.WriteLine("Klavyeden okunan sayı: " + say);

            //Console.WriteLine(x);
            //Console.ReadLine();

            int x = 21, j = 5, toplam, bolum, carpim, fark;

            toplam = x + j;
            carpim = x * j;
            bolum = x / j;
            fark = x - j;
            Console.WriteLine("Sonuc " + toplam + " " + carpim + " " + bolum +" " + fark);

            Console.ReadKey();
        }
    }
}
