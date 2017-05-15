using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starswidth_endswitdh_metodalrı
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "www.ismek.com";
            if(x.EndsWith(".com"))
            {
                if(x.StartsWith("www."))
                {
                    Console.WriteLine("Girilen internet adresi doğrulandı");
                }
            }
            Console.ReadKey();
        }
    }
}
