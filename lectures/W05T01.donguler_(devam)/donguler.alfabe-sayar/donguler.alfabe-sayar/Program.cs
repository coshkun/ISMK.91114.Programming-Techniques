using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler.alfabe_sayar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char harf = 'a';
            Console.WriteLine("Letters of English:");

            for (int i = 0; i < 26; i++)
            {
                Console.Write(harf + " ");
                harf++;
            }
            Console.ReadKey();
        }
    }
}
