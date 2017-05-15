using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_params_ornek3
{
    class Program
    {
        public static float ortalama(string x,params float[] y)
        {
            if (x == "Ortalama")
            {
                int sayac = 0;
                float topla = 0, ort = 0;
                foreach (float i in y)
                {
                    sayac++;
                    topla += i;
                    ort = topla / sayac;
                }
                return ort;
            }
            else
                return 0;
            
        }
        static void Main(string[] args)
        {
            
       Console.WriteLine("Ortalama Sonucu "+ortalama("Ortalama", 25, 25, 20, 120, 20));
            Console.ReadKey();
        }
    }
}
