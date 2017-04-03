using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_switch_case_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x=0;
            Console.WriteLine("1.PHP");
            Console.WriteLine("2.Java");
            Console.WriteLine("3.C#");
            Console.WriteLine("4.Basic");
            Console.WriteLine("5.Python");

            Console.Write("\nSeciminizi Yapınız: ");
            x = Convert.ToByte(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Seciminiz: PHP dili");
                    break;
                case 2:
                    Console.WriteLine("Seciminiz: Java dili");
                    break;
                case 3:
                    Console.WriteLine("Seciminiz: C# dili");
                    break;
                case 4:
                    Console.WriteLine("Seciminiz: Basic dili");
                    break;
                case 5:
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
