using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Array x = Array.CreateInstance(typeof(int), 5);
            x.SetValue(1, 0);
            x.SetValue(13, 1);
            x.SetValue(2, 2);
            x.SetValue(85, 3);
            x.SetValue(11, 4);
            
            Array.Sort(x);
            /*
             Sıralama Yaparken dizide tanımlanan değişken türüne göre
             eğer string türünden ise harflere göre sıralama yapar,
             sayısal bir değişken türü kullanılmışsa küçük sayıdan
             büyük sayıya göre sıralama yapar
             */

            foreach (int a in x)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
