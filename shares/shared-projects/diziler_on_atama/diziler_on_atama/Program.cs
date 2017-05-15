using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_on_atama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x= { 5, 80, 25,8205};
            string[] y = { "C#", "Java", "Asp.net" };
            char[] z = { 'A', 'g', '*' };
            byte[] t = { 2, 580, 255 };//burada 255'ten yukarı değer yazılamaz.
            //byte türünden tanımlanmış olan dizinin içerisine 255'ten fazla eleman yazılabilir.
            Console.WriteLine(x[1]);
            Console.WriteLine(y[2]);
            Console.ReadKey();
        }
    }
}
