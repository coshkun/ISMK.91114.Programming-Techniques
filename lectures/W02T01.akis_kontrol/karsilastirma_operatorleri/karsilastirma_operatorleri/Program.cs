using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karsilastirma_operatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int z1;
            Console.Write("Bi sayı gir: ");
            z1 = Convert.ToInt32(Console.ReadLine());
            bool z2 = z1 > 5 && z1 < 8;
            Console.WriteLine(z2);

            Console.Write("Bi sayı gir: ");
            z1 = Convert.ToInt32(Console.ReadLine());
            bool z3 = z1 <= 10 || z1 >= 2;
            Console.WriteLine(z3);
            Console.WriteLine("");

            Console.WriteLine("z2:{0}, z3:{1}", z2, z3);
            Console.ReadKey();
        }
    }
}
