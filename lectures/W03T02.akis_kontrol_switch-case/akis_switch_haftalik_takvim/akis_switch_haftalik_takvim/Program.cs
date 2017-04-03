using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_switch_haftalik_takvim
{
    class Program
    {
        static void Main(string[] args)
        {
etiket:
            /* Bu program klavyeden girilen sayıya göre 
               haftanın gününü döndürür.
            */
            Console.WriteLine("\nBu program klavyeden girilen sayıya göre, \nhaftanın gününü döndürür. \u00a9" + "author:coshkun");
            Console.WriteLine("========================");
            Console.Write("Bir sayı giriniz(1-7 arası): ");
            byte sec = Convert.ToByte(Console.ReadLine());

            switch (sec)
            {
                case 1:
                    Console.WriteLine("Pazartesi günü");break;
                case 2:
                    Console.WriteLine("Salı günü");break;
                case 3:
                    Console.WriteLine("Çarşamba günü");break;
                case 4:
                    Console.WriteLine("Perşembe günü"); break;
                case 5:
                    Console.WriteLine("Cuma günü"); break;
                case 6:
                    Console.WriteLine("Cumartesi günü"); break;
                case 7:
                    Console.WriteLine("Pazar günü"); break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    break;
            }

            Console.WriteLine("\nçıkmak için 'q' bas..");
            string c = Console.ReadLine();
            if (c == "q" || c == "Q")
                goto cikis;
            goto etiket;
        cikis:;
        }
    }
}
