using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.epsilon_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=5, snc = 0;

            Console.Write("Toplamı alınacak sayıyı giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                snc += i;
            }

            Console.WriteLine("\n\n" + "0'dan " + n + "'e kadar olan sayıların toplamı : " + snc);
            Console.ReadKey();
        }
    }
}
