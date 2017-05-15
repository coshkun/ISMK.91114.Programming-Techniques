using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerde_kopyalama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 25, 12, 365, 25, 98, 64 };
            int[] y = new int[2];
            Array.Copy(x, 2, y, 3, 3);
            /*x'in 2. indexinden sonra 3 elemanı kopyala
             y'nin 3. index'İnden sonrasına yapıştır.
             En sondaki 3 rakamı kaç eleman kopyalanacağını belirtir.
             
             */

            foreach (int a in y)
                Console.Write(a+ " ");

            Console.ReadKey();
        }
    }
}
