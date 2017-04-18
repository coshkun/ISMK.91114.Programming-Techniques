using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();

            l.Add("İsmek");
            l.Add(15);
            l.Add(123.258f);
            l.Add('?');

            foreach (object o in l)
                Console.Write(o + " ");


            List<int> lst = new List<int>();
            lst.Add(125);
            lst.Add(200);
            lst.Add(24);

            lst.Sort();

            Console.ReadKey();
        }
    }
}
