using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizileri
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] sayi = new float[3];
            Console.WriteLine("Birinci Sayıyı Giriniz:");
            sayi[0] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz:");
            sayi[1] = Convert.ToSingle(Console.ReadLine());

            if(sayi[0]>sayi[1])
            {

       
            Console.WriteLine("Toplam Sonucu={0}",(sayi[0] + sayi[1]));
            sayi[2] = sayi[0] - sayi[1];
            Console.WriteLine("Çıkarma Sonucu=" + sayi[2]);
            sayi[2] = sayi[0] * sayi[1];
            Console.WriteLine("Çarpma Sonucu=" + sayi[2]);
            sayi[2] = sayi[0] / sayi[1];
            Console.WriteLine("Bölme Sonucu=" + sayi[2]);

            }
            else
            {

                sayi[2] = sayi[0] + sayi[1];
                Console.WriteLine("Toplam Sonucu=" + sayi[2]);
                sayi[2] = sayi[1] - sayi[0]; 
                Console.WriteLine("Çıkarma Sonucu=" + sayi[2]);
                sayi[2] = sayi[0] * sayi[1];
                Console.WriteLine("Çarpma Sonucu=" + sayi[2]);
                sayi[2] = sayi[1] / sayi[0]; 
                Console.WriteLine("Bölme Sonucu=" + sayi[2]);

            }

            Console.ReadKey();
        }
    }
}
