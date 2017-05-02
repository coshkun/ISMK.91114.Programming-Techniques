using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar.@params
{
    class Program
    {
        static List<float> parametreler = new List<float>();

        static void Main(string[] args)
        {
            int say = 0;
            Console.WriteLine("Ortalama almak için \"Ortalama\" komutunu giriniz, ardından parametreleri giriniz.");
            string cmd = Console.ReadLine();

            Console.WriteLine((++say).ToString() +".Sayıyı giriniz.(Hesaplamak için 'h' giriniz)");
            while (say > 0)
            {
                string input = Console.ReadLine().Trim();
                if (input.Trim().ToLower() == "h")
                    break;

                parametreler.Add(Convert.ToSingle(input));
            }

            float? sonuc = ortala(cmd, parametreler.ToArray());
            if(sonuc != null)
                Console.WriteLine("Sonuc= " + sonuc);
            else
                Console.WriteLine("Sonuc hesaplanamıyor..");
            Console.ReadKey();
        }

        public static float? ortala(string cmd, params float[] args)
        {
            if (cmd.Trim().ToLower() != "ortalama")
                return null;

            float toplam = 0, snc =0;
            foreach (float i in args)
            {
                toplam += i;
                snc = toplam / (float)args.Length;
            }

            return snc;
        }
    }
}
