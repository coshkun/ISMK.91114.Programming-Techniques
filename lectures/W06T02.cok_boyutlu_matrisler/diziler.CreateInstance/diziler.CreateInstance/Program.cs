using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.CreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Array x = Array.CreateInstance(typeof(string), 5);

            x.SetValue("1", 0);
            x.SetValue("13", 1);
            x.SetValue("2", 2);
            x.SetValue("85", 3);
            x.SetValue("11", 4);

            Array.Sort(x);
            //Array.Reverse(x);

            foreach (string i in x)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
