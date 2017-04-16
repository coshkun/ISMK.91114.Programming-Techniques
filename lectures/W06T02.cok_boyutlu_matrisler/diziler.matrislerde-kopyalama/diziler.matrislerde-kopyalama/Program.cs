using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.matrislerde_kopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] x = { 54.45f, 43.78f, 2, 236, 85 };
            float[] y = new float[10];

            x.CopyTo(y, 2);

            foreach (var i in y)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
