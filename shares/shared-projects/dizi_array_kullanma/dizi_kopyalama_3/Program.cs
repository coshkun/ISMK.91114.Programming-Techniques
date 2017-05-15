using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_kopyalama_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] x = new int[7];

            Array y = Array.CreateInstance(typeof(int), 5);
            //typeof veri türünün ne olacağı
 //Tek boyutlu dizi tanımlamalarında kullanılabilir.(Yeni versiyonlar dahil değildir)
          y.SetValue(258, 0);
            y.SetValue(12, 1,0);
            y.SetValue(28, 2,0);
            y.SetValue(45, 3);
            y.SetValue(258, 4);
         
            foreach (int c in y)
                Console.Write(c + " ");
            Console.ReadKey();
            
        }
    }
}
