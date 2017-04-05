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
            byte x=0;
      
            Console.WriteLine("PHP için 1");
            Console.WriteLine("Java için 2");
            Console.WriteLine("C# için 3");
            Console.WriteLine("Phyton için 4");
            Console.Write("Seçiminizi yapınız:");
            x = Convert.ToByte(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine("Seçtiğiniz Programlama dili PHP");
                    break;
                case 2: Console.WriteLine("Seçtiğiniz Programlama dili Java");
                    break;
                case 3:
                    Console.WriteLine("Seçtiğiniz Programlama dili C#");
                    break;
                case 4:
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
