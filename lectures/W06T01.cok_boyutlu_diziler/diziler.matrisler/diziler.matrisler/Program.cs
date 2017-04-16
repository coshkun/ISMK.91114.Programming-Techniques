using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.matrisler
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 4, n = 6;
            int sonuc = 0;
            int[,] matA = new int[m, n];
            int[,] matB = { { 5, 3 }, { 10, 3 }, { 2, 0 }, { 4, 123 } };
            Random rnd = new Random();

            // matA.yi dolduralım
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matA[i, j] = rnd.Next(0, 10); // 0-10 araswı rastgelsin..
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

            Console.WriteLine("\n\n MatB: \n");
            // matB.yi de gösterelim
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matB[i, j] + "\t ");
                }
                Console.Write("\n");
            }


            foreach (int item in matB)
                sonuc += item;

            Console.WriteLine("\nMatB'nin elemanlar toplamı: " + sonuc);

            Console.ReadKey();
        }
    }
}
