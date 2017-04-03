using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_odev_soru_kargo_ucreti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bir magazadan satın alınan ürünlerin topl. fiyatı 0-50TL
            toplam fiyata ilave olarak +5TL eklensin.
            50-100TL olduğunda +2TL eklensin,
            100TL ve üzerinde toplam ürün fiyatı ve ücretsiz kargo ekrana yazılsın.
            */
            Console.WriteLine("Satış fiyatını giriniz: ");
            float price = Convert.ToSingle(Console.ReadLine());

            if ( 0 < price && price < 50)
            {
                Console.WriteLine("+5TL kargo ücreti eklenen toplam ürün bedeli: " + (price + 5) + " TL." );
            }
            else if ((50 <= price) && (price < 100))
            {
                Console.WriteLine("+2TL kargo ücreti eklenen toplam ürün bedeli: " + (price + 2) + " TL.");
            }
            else if (100 <= price)
            {
                Console.WriteLine("kargo ücretiniz 0TL, toplam ürün bedeliniz: " + price + " TL.");
            }
            else
            {
                Console.WriteLine("pozitif bir ücret giriniz..");
            }

            Console.ReadKey();
        }
    }
}
