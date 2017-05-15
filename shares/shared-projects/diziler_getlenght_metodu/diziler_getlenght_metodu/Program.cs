using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_getlenght_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "C#", "Java", "Android", "IOS", "HTML" };
            Console.WriteLine(x.GetLength(0));//Kaç elemanlı olduğunu sayar

            int[,,] y = { { { 2, 5, 58, 45 } }, { { 3, 58, 365, 45 } }, { { 45, 47, 258, 45 } } };
            Console.WriteLine(y.GetLength(1));//

            string a = "2547";
         
            Console.WriteLine(a.Length);//burada kaç basamaklı olduğunu sayar
            Console.ReadKey();
        }
    }
}
