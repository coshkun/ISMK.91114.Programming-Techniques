using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            Console.WriteLine("İlk 15 Karekter: " + x.Substring(0, 15));
            Console.WriteLine("Bir Parçası: " + x.Substring(5, 10));
            Console.ReadKey();

        }
    }
}
