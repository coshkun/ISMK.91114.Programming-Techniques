using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.aray_koleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] y = new int[2];

            //for (int i = 0; i < x.Length; i++)
            //    x[i] = rnd.Next(10);

            //Array.Copy(x, 2, y, 1, 3);

            Array d = Array.CreateInstance(typeof(int), 5);

            d.SetValue(128, 0);
            d.SetValue(128, 1);
            d.SetValue(128, 2);
            d.SetValue(128, 3);
            d.SetValue(128, 4);

            //gösterelim
            for (int i = 0; i < y.Length; i++)
                Console.WriteLine(y[i]);

            Console.ReadKey();
        }
    }
}
