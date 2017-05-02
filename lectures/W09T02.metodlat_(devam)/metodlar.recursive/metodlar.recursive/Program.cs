using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar.recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyel alınacak sayı gir: ");
            var say = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuc= " + iterFaktoriyel(say));
            Console.ReadKey();
        }

        public static int faktoriyel(int x) // Rekürsif model
        {
            if (x == 0)
                return 1;

            return x * faktoriyel(x - 1);
        }

        public static int iterFaktoriyel(int x) // İteratif model
        {
            int snc = 1;
            for (int i = 1; i <= x; i++)
            {
                snc *= i;
            }
            return snc;
        }
    }
}
