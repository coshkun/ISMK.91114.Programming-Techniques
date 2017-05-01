using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonlar.giris
{
    class Program
    {
        static int gX;
        static int gY;

        public static int gZ;

        static int topla(int a, int b) { return a + b; }
        static void ismek()
        {
            int x=0, y=0;
            try
            {
                Console.Write("1.Sayı giriniz: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n2.Sayı giriniz: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("\nHata: " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nToplam: {0}", x + y);
                Console.WriteLine("Programdan Çıkılsınmı? (e/h) :");
                Char a = Convert.ToChar(Console.ReadLine());
                if (a == 'e' || a == 'E') { }
                else
                    Console.ReadKey();
            }
            
        }

        static void Main(string[] args)
        {
            int x, y;
            
            x = 3;
            y = 2;
            int z = topla(x, y);

            gX = 90;
            gY = 100;
            gZ = 110;

            ismek();
        }
    }
}
