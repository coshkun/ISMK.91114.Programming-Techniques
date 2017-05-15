using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_ornekleri_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[2, 3];//2x3 boyutunda dizi tanımlandı
            int toplam = 0;
            x[0, 0] = 125;
            x[0, 1] = 32;
            x[0, 2] = 10;

            x[1, 0] = 4;
            x[1, 1] = 481;
            x[1, 2] = 25698;
            // toplam = x[0, 0] + x[0, 1] + x[0, 2] + x[1, 0] + x[1, 1] + x[1, 2];
            //Console.WriteLine(toplam);

            /*  foreach(int a in x)
              {
                  toplam = toplam + a;

              }*/

            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    toplam += x[a, b];
                }
            }
            Console.WriteLine(toplam);

            Console.ReadKey();
        }
    }
}
