using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padleft_padright_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "İsmek",y="";
            Console.WriteLine(x.PadLeft(15, '#')+y.PadRight(15,'#'));      
            Console.ReadKey();
        }
    }
}
