/*
    Örnek Program dosyası ile verilen tepkileri simüle eden programı yazınız.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04T02.sinav.sorusu_coskun
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;

            Console.Write("Kullanı adını giriniz: ");
            kullaniciadi = Console.ReadLine();

            Console.Write("Sifre giriniz: ");
            sifre = Console.ReadLine();

            if (kullaniciadi.ToLower() == "ismek" && sifre.ToLower() == "123")
            {
                Console.WriteLine("Onay işlemi tamamlandı, Yükleme Yapılsınmı? (e)evet / (h)hayır");
                char cvp = Console.ReadLine().ToLower()[0];
                if (cvp == 'e')
                {
                    Console.WriteLine("Yükleniyor..");

                    Console.Write("1.Sınav Notunuzu giriniz: ");
                    float sinav1 = Convert.ToSingle(Console.ReadLine().Replace('.',','));

                    Console.Write("2.Sınav Notunuzu giriniz: ");
                    float sinav2 = Convert.ToSingle(Console.ReadLine().Replace('.', ','));

                    float ort = ((sinav1 * 0.40f) + (sinav2 * 0.60f));
                    
                    if (ort>= 44.50f)
                    {
                        Console.WriteLine("Tebrikler! Dersi geçtiniz.. Ortalamanız: {0}", ort.ToString("N2"));
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm! Dersdersten Kaldınız.. Ortalamanız: {0}", ort.ToString("N2"));
                    }
                }
                else
                    goto cikis;
                
            }
            else
            {
                Console.WriteLine("kullanıcı adı veya sifre hatalı..");
                // Arabalar buraya
                Console.WriteLine("********************");
                Console.WriteLine("Mercedes \t (1)");
                Console.WriteLine("Bmw \t\t (2)");
                Console.WriteLine("Ford \t\t (3)");
                Console.WriteLine("Audi \t\t (4)");
                Console.WriteLine("Wolswagen \t (5)");
                Console.WriteLine("********************");
                Console.Write("Seçiminiz? : ");

                int sec = Convert.ToInt32(Console.ReadLine());
                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Secilen Araç Modeli: Mercedes");
                        break;
                    case 2:
                        Console.WriteLine("Secilen Araç Modeli: Bmw");
                        break;
                    case 3:
                        Console.WriteLine("Secilen Araç Modeli: Ford");
                        goto case 4;
                    case 4:
                        Console.WriteLine("Secilen Araç Modeli: Audi");
                        break;
                    case 5:
                        Console.WriteLine("Secilen Araç Modeli: Wolswagen");
                        goto case 2;
                    default:
                        break;
                }
            }

            cikis:
            Console.WriteLine("çıkmak içim bir tuşa basın..");
            Console.ReadKey();
        }
    }
}
