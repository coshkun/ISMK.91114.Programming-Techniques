using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_switch_case_kullanim2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            Console.WriteLine("1.PHP için php giriniz.");
            Console.WriteLine("2.Java için java");
            Console.WriteLine("3.C# için cs");
            Console.WriteLine("4.Basic için bas");
            Console.WriteLine("5.Python için py");

            Console.Write("\nSeciminizi Yapınız: ");
            x = Console.ReadLine();

            switch (x)
            {
                case "php":
                    Console.WriteLine("Seciminiz: PHP dili");
                    break;
                case "java":
                    Console.WriteLine("Seciminiz: Java dili");
                    break;
                case "cs":
                    Console.WriteLine("Seciminiz: C# dili");
                    break;
                case "bas":
                    Console.WriteLine("Seciminiz: Basic dili");
                    break;
                case "py":
                    Console.WriteLine("Seciminiz: Python dili");
                    break;
                default:
                    Console.WriteLine("Secim yapmadınız..");
                    break;
            }

            Console.ReadKey();
        }
    }
}
