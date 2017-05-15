using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_ornekleri_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[6, 6];
      
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    x[a, b] = a + b; 
                }
            }

            for (int z = 1; z < 4; z++)
            {
                for (int t = 0; t < 5; t++)
                {
                    Console.Write(x[z, t]+ " ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
