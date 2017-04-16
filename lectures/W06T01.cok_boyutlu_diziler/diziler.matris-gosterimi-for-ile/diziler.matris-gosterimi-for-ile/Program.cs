using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.matris_gosterimi_for_ile
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3, n = 5;
            int sonuc = 0;
            int[,] matA = new int[m, n];

            // matA.yi dolduralım
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //matA[i, j] = i + j;   //yada..

                    if (i < 1)
                        matA[i, j] = j + 1;
                    else
                        matA[i, j] = j + 1 + i;
                }
            }

            Console.WriteLine("\n\n MatA: \n");
            // gösterelim
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matA[i, j] + " ");
                }
                Console.Write("\n");
            }


            Console.WriteLine("\nMatB'nin elemanlar toplamı: " + sonuc);

            Console.ReadKey();
        }
    }
}
