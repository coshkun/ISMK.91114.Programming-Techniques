using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings.split_methodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Bilgisayar, Matematik, Edebiyat, Coğrafya";
            string[] y = x.Split(',');

            Console.WriteLine(y[1].Trim()); //Trim Başındaki kıçındaki boşlukları alır.
            Console.ReadKey();
        }
    }
}
