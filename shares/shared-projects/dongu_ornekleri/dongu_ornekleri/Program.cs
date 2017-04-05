using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongu_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            int x;

            while (true)
            {
                Console.WriteLine("Sayı giriniz:");
                x = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0 && i != 1)
                        a = true;

                }

                if (a == true)
                    Console.WriteLine("Girilen sayı asal değildir.");
                else
                {
                    a = false;
                    Console.WriteLine("Girilen sayı asaldır.");
                }
                  
            }
        }
          
        }
    }

