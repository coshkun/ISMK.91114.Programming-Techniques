using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "C#", "Java", "HTML" };

            Console.WriteLine("Dizi değişkenine eleman sayısı giriniz: ");
            int[] sayı = new int[Convert.ToInt32(Console.ReadLine())];
            sayı[5] = 258;
            Console.WriteLine(sayı[5]);

            sayı.ToList().ForEach(item => { Console.WriteLine( item.ToString()); });

            Console.ReadKey();
        }
    }
}
