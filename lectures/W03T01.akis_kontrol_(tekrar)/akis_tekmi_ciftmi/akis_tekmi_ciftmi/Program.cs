using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_tekmi_ciftmi
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            string val = "";

            while (true)
            {
                Console.WriteLine("Herhangi bir sayı giriniz: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0)
                    Console.WriteLine("Cift sayı girdiniz. :)");
                else
                    Console.WriteLine("Hop..! Tek sayı girdiniz.");

                Console.WriteLine("Cıkmak için 'q' tuşabas..");

                val = Console.ReadLine();
                if (val == "q") { break; }
                else
                    continue;
               
            }
        }
    }
}
