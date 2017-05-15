using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_3boyut
{
    class Program
    {
        static void Main(string[] args)
        {
            object[,,] x = new object[2, 2, 3];
            x[0, 0, 0] = 2;
            x[0, 0, 1] = 5;
            x[0, 0, 2] = 121.568;
            x[0, 1, 0] = 52;
            x[0, 1, 1] = 24;
            x[0, 1, 2] = "222aas";
            x[1, 0, 0] = '1';
            x[1, 0, 1] = '?';
            x[1, 0, 2] = 1252;
            x[1, 1, 0] = 522;
            x[1, 1, 1] = 412;
            x[1, 1, 2] = 3582;


            foreach (object a in x)
                Console.Write(a +" ");
            Console.ReadKey();
           
        }
    }
}
