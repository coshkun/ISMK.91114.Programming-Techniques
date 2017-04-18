using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi.ArrayList_Inserting
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

            l.Insert(2, "C#");
            
            Console.WriteLine(" ");
            foreach (object o in l)
                Console.Write(o + " ");

            Console.ReadKey();
        }
    }
}
