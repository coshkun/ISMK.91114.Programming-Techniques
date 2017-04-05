using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu_toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adı: ");
            string m = Console.ReadLine();//Klaveden Okuma İşlemi Yapıldı.
            Console.Write("Şifre adı: ");
            string sifre = Console.ReadLine();
            if (m == "ismek" && sifre=="123")//m değişkeni Tamam ifadesine eşit mi?
            {
                Console.Write("Onay işlemi tamam. Yükleme işlemi yapılsın mı? Evet (e) ");
                string b = Console.ReadLine(); //Klaveden Okuma İşlemi Yapıldı.

                if (b == "e"|| b=="E")//b değişkeni Evet ifadesine eşit mi?
                   
                {
                    Console.WriteLine("Loadind....");
                    float sayi1, sayi2, sonuc;
                    Console.Write("1. sınav notunu giriniz: ");
                    sayi1 = Convert.ToSingle(Console.ReadLine());

                    Console.Write("2. sınav notunu giriniz: ");
                    sayi2 = Convert.ToSingle(Console.ReadLine());

                    sonuc = sayi1*40/100 + sayi2*60/100;

                    if (sonuc >= 45)
                        Console.WriteLine("Dersten başarılı bir şekilde geçtiniz. Ortalamanız= " + sonuc);

                    else
                        Console.WriteLine("Üzgünüm dersten başarılı olamadınız. Ortalamanız="+sonuc);

                }

                else
                    /*
                     Evet'in haricinde herhangi birşey girilirse else devreye girip
                     programı bitirecektir. 

                         */
                    Console.WriteLine("Yükleme devam edilemedi....");
            }

            else// m değişkeni Tamam ifadesine eşit değilse burası devreye girecektir.
            {
                Console.Clear();
                Console.WriteLine("Kullanıcı adı veya şifre yanlış");
             
                    byte x;
                    Console.WriteLine("Lütfen seçiminizi yapınız:\n\n********************\n");
                    // \n bir alt satıra geç
                    Console.WriteLine(" Mercedes\t(1)"); //  \t ifadesi bir tab tuşu kadar boşluk bırak
                    Console.WriteLine(" Bmw\t\t(2)");
                    Console.WriteLine(" Ford\t\t(3)");
                    Console.WriteLine(" Audi\t\t(4)");
                    Console.WriteLine(" Wolkswagen\t(5)");
                    Console.Write("\n********************\nSeçiminiz? : ");
                    x = Convert.ToByte(Console.ReadLine());

                    switch (x)
                    {

                        case 1:
                            Console.WriteLine("Seçilen Araç Modeli: Mercedes");
                            break;
                        case 2:
                            Console.WriteLine("Seçilen Araç Modeli: Bmw");

                            break;
                        case 3:
                            Console.WriteLine("Seçilen Araç Modeli: Ford");
                            goto case 4;

                        case 4:
                            Console.WriteLine("Seçilen Araç Modeli: Audi ");

                            break;
                        case 5:
                            Console.WriteLine("Seçilen Araç Modeli: Wolkswagen ");
                            goto case 2;//


                        default:
                            Console.WriteLine("lütfen 1 ile 5 arasında sayı giriniz");
                            break;
                    }

              
            }
            Console.ReadKey();

        }

    }
    }

