using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_params
{
    class Program
    {
        public static int metot1(params int[] carp)
        {
            int sonuc = 1;
            foreach (int i in carp)
                sonuc = sonuc*i;
            return sonuc;    
                }
        static void Main(string[] args)
        {
           Console.WriteLine(metot1(5, 2, 3, 4));
            Console.WriteLine(metot1(2, 585, 3));
            Console.ReadKey();
        }
    }
}
