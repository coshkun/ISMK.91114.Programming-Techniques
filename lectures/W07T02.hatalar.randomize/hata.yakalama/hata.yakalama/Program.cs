using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata.yakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool z = true;
            
            while (z)
            {
                try
                {
                    Console.Write("\n1.Sayıyı giriniz: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n2.Sayıyı giriniz: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Toplamın Sonucu: {0}", (x + y));


                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Hata: " + fe.Message);
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("Hata: " + oe.Message);
                }
                catch (Exception e)
                {
                    //if (e.GetType() == typeof(FormatException))
                    //{

                    //}                
                    Console.WriteLine("Hata: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Çıkış Yapılsınmı (e/h)?");
                    var ok = Console.ReadKey();
                    if (ok.Key == ConsoleKey.E)
                        z = false;
                } 
            }

            /*  Some Type Of Known Issues:
            
            TYPE                            WHEN THRONW
            FormatException                 Veri girişi yanlış biçimde olduğunda
            OutOfMemoryException            Yıgın bellek bölgesinin birden fazla metodlarda kullanılması durumunda
            NullReferenceException          Bellekte yer ayrılmamış bir nesne üzerinden üye elamanlara yada değerlere erişmeye çalıştığımızda
            IndexOutOfRangeException        Secilen index değeri dizinin boyutlarını aştığı zaman
            DividedByZero                   herhangi bir sayı sıfıra bölünmeye çalışıldığında
            ArithmeticException             Matematiksel hesaplama hatalarında
            ArrayTypeMismatchException      Bir dizinin elemanlarına yanlış türde veri ataması yapılmaya çalışıldığında
            OverflowException               Değişken kapasiteleri aşıldığında
            InvalidCastException            Tür dönüşümlerinde yanlış tipe dönüşüm yapılmaya çalışıldığında
            Exception                       Genel hata tipidir. Cinsi belirli olmayan tüm diğer hatalarda devreye girer.
            */

            //Console.ReadKey();
        }
    }
}
