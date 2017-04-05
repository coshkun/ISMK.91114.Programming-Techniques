using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_magaza_urun
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            Console.WriteLine("Toplam Ürün Fiyatını Giriniz:");
            x = float.Parse(Console.ReadLine());

            if(x<50 && x>0)
            {
                x += 5;
                Console.WriteLine("Toplam Ürün Fiyatı:{0}\nKargo ücreti:{1}", x, 5);
            }
           else if(x>50 && x<100)
            {
                x += 2;
                Console.WriteLine("Toplam Ürün Fiyatı:{0}\nKargo ücreti:{1}", x, 2);
            }
            else
                Console.WriteLine("Toplam Ürün Fiyatı:{0}\nKargo Bedava", x);
            Console.ReadKey();


        }
    }
}
