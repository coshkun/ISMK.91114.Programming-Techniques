using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Bilgisayar,Matematik,Coğrafya,Edebiyat";
            string[] y = x.Split(',');
            Console.WriteLine(y[2]);
            Console.ReadKey();
        }
    }
}
