using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_fonksiyonları
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dairenin yarıçapını bulan prg */

            Console.WriteLine("Dairenizin Alanını giriniz..: ");
            var a = Convert.ToDouble( Console.ReadLine());
            var r2 = (a / Math.PI);
            Console.WriteLine("Yarı Çap: {0}", Math.Sqrt(r2));

            Console.WriteLine("Hadi bitanede yarı çap giriniz: ");
            var r = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Alan: {0}", (Math.Pow(r, 2) * Math.PI) );

            Console.ReadKey();
        }
    }
}
