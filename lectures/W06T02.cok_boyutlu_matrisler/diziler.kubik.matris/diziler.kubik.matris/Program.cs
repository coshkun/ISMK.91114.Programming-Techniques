using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.kubik.matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] x = new int[2, 2, 3];

            x[0, 0, 0] = 2;
            x[0, 0, 1] = 2;
            x[0, 0, 2] = 2;

            x[0, 1, 0] = 2;
            x[0, 1, 1] = 2;
            x[0, 1, 2] = 2;

            x[1, 0, 0] = 2;
            x[1, 0, 1] = 2;
            x[1, 0, 2] = 2;

            x[1, 1, 0] = 2;
            x[1, 1, 1] = 2;
            x[1, 1, 2] = 2;

            foreach (int item in x)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
