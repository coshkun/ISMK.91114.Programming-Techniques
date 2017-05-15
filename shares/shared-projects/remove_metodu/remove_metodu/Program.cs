using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Yenibosna",y="Programlama",z="İsmek Bilişim Okulu";
            Console.WriteLine(x.Remove(2, 3));//2. indexten sonra 3 parçayı aradan kaldır.
            Console.WriteLine(y.Remove(1, 5));//1. indexten sonra 5 parçayı aradan kaldır.
            Console.WriteLine(z.Remove(6, 7));//6. indexten sonra 7 parçayaı aradan kaldır.
            Console.ReadKey();

        }
    }
}
