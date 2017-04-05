using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string x=null;
      
            Console.WriteLine("PHP için php");
            Console.WriteLine("Java için java");
            Console.WriteLine("C# için c#");
            Console.WriteLine("Phyton için pth");
            Console.Write("Seçiminizi yapınız:");
            x = Console.ReadLine();

            switch(x)
            {
                case "php":
                    Console.WriteLine("Seçtiğiniz Programlama dili PHP");
                    break;

                case "java":
                    Console.WriteLine("Seçtiğiniz Programlama dili Java");
                    break;
                case "c#":
                    Console.WriteLine("Seçtiğiniz Programlama dili C#");
                    break;
                case "pth":
                    Console.WriteLine("Seçtiğiniz Programlama dili Phyton");
                    break;
                default:
                    Console.WriteLine("Seçim Yapmadınız.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
