using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerdede_kopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float[] x = { 54.45f, 43.78f,2,236,85};
            float[] y = new float[11];
            x.CopyTo(y, 6);
            //x'in bütün elemanlarını kopyala, y'nin 6. indexten itibaren yapıştır.

            foreach (float b in y)
                Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
