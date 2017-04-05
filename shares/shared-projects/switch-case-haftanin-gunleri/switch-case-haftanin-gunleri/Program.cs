using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_haftanin_gunleri
{
    class Program
    {
        static void x()
        {
            
        }
        static void Main(string[] args)
        {
            byte x;

            etiket:

            Console.Write("Lütfen 1 ile 7 arası sayı giriniz:");
            x = Convert.ToByte(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Haftanın 1. Günü Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Haftanın 2. Günü Salı");
                    break;
                case 3:
                    Console.WriteLine("Haftanın 3. Günü Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Haftanın 4. Günü Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Haftanın 5. Günü Cuma");
                    goto case 1;
                case 6:
                    Console.WriteLine("Haftanın 6. Günü Cumartesi");
                    goto case 5;
                   
                case 7:
                    Console.WriteLine("Haftanın 7. Günü Pazar");
                    break;
                 
                default:
                    Console.WriteLine("Lütfen 1 ile 7 arasında sayı giriniz.");
                    break;


            }
            goto etiket;
            Console.WriteLine("\u00a9"+ "©" + "Mehmet Akif Arvas" );
            Console.ReadKey();
        }
    }
}
