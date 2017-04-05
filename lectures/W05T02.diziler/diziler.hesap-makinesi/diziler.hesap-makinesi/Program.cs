using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[2];
            float[] outputs = new float[4];

            Console.Write("1.Sayıyı giriniz: ");
            inputs[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            inputs[1] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                if (i % 4 == 0)
                    outputs[i] = inputs[0] + inputs[1];
                if (i % 4 == 1)
                    outputs[i] = inputs[0] - inputs[1];
                if (i % 4 == 2)
                    outputs[i] = inputs[0] * inputs[1];
                if (i % 4 == 3)
                    outputs[i] = inputs[0] / inputs[1];
            }

            Console.WriteLine("\nBir işlem Seciniz..");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Çıkarma");
            Console.WriteLine("3.Çarpma");
            Console.WriteLine("4.Bölme");
            Console.Write("Seçim: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            sec--;

            if (sec > 0 && sec < 5)
            {
                for (int i = 1; i <=4; i++)
                {
                    if (i % 4 == sec)
                        Console.WriteLine("\nSonuc: " + outputs[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
