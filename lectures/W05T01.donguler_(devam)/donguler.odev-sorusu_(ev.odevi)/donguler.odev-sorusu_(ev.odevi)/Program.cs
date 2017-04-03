using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace donguler.odev_sorusu__ev.odevi_
{
    class Program
    {
        /* 
        bir bankanın atm'sine k.adı ve sifre girilerek
        giris yapılsın, 3 kere yanlış girilmesinde
        hesabınız bloke edildi uyarısı verilsin.

        dogru giriş yapıldıysa, 4 tane banka secimi için
        secenek sunulsun. seceneklerden bir tanesini
        secimini yaptıktan sonra, havale yapılacak hesap no istensin.

        HEs.No.10 hane ile sınırlandırılsın.

        hesap no doğru girildikten sonra,
        Havale tutarı 10TL. altında olmayacak şekilde kontrol sağlanıp
        eger gecerliyse belirtilen hesaba havale yapılmıştır yazısı
        yazdırılsın.
        */
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;
            int sifre_say = 3;


            while (true)
            {
                Console.WriteLine(" ..:: ZETRA BANK ATM.v.1.0 ::..");
                Console.WriteLine(" . Bankayım AŞ. Gururla Sunar .");
                Console.WriteLine(" ..............................");
                Console.WriteLine("================================");
                Console.WriteLine("Devam etmek için ENTER basınız ..");
                //input = Console.Read();
                    Thread.Sleep(600);
                Console.Clear();
                    Thread.Sleep(400);
                if (Console.KeyAvailable) //(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Devam etmek için ENTER basınız..");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            do
            {
                Console.Write("\nKullanıcı adını giriniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                kullaniciadi = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("Sifre giriniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                sifre = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (kullaniciadi.ToLower() == "ismek" && sifre.ToLower() == "123")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Giriş Başarılı, Hoşgeldiniz {0}!", kullaniciadi);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Lütfen havale geçmek istediğiniz bankayı seciniz..");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("==================================================");
                    Console.WriteLine("1.Akbank \t\t(AKB)");
                    Console.WriteLine("2.İş Bankası \t\t(ISB)");
                    Console.WriteLine("3.Yapı Kredi \t\t(YKB)");
                    Console.WriteLine("4.Ziraat Bankası \t(ZRB)");
                    Console.Write("Seciminiz: ");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    if (sec <1 || sec >4)
                        Console.WriteLine("Hatalı Secim yapıldı, Çıkış yapılıyor..");
                    else
                    {
                        string bank="";
                        if (sec == 1)
                            bank = "Akbank";
                        else if (sec == 2)
                            bank = "İşBank";
                        else if (sec == 3)
                            bank = "YapıKredi";
                        else if (sec == 4)
                            bank = "ZiraatBank";

                        string hes_no = string.Empty;
                        do
                        {
                            Console.WriteLine("\nLütfen " + bank + " için hedef hesap numarasını giriniz.");
                            Console.Write(bank + " : "); hes_no = Console.ReadLine();
                            Console.Clear();
                        } while (hes_no.Length != 10);

                        string hav_tut = string.Empty;
                        float miktar = 0;
                        do
                        {
                            Console.WriteLine("\nLütfen " + hes_no + " için havale tutarını giriniz.");
                            Console.Write("Miktar(TL) : "); hav_tut = Console.ReadLine().Replace('.',',');
                            float.TryParse(hav_tut, out miktar);
                            Console.Clear();
                        } while (hav_tut.Length == "".Length || miktar < 10.0f);

                        bool onaysiz = true;
                        do
                        {
                            Console.WriteLine("\nHavale Detayları:");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("Banka: {0}\nHesapNo: {1}\nMiktar: {2} TL.\n", bank, hes_no, miktar);
                            Console.WriteLine("-------------------");
                            Console.Write("Yukarıdaki meblağ, xxx-no.lu ZETRABANK - {0} hesabınızdan ödenecektir.\nOnaylıyor musunuz? (e/h)" ,kullaniciadi);
                            ConsoleKeyInfo cki = Console.ReadKey();

                            if (cki.Key == ConsoleKey.E)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nHavale Başarılı!! Çıkış Yapılıyor.. ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Yeniden bekleriz, Hoşcakalın! ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                goto EXIT;
                            }
                            else if (cki.Key == ConsoleKey.H)
                            {
                                break;
                            }
                            Console.Clear();
                        } while (onaysiz);

                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nİşlem iptal edildi!! Çıkış Yapılıyor.. ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Yeniden bekleriz, Hoşcakalın! ");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    goto EXIT;
                }
                else
                    Console.WriteLine("Hatalı giriş yaptınız, kalan deneme saysı: {0}", --sifre_say);

            } while (sifre_say > 0);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kartınız bloke edildi! Lütfen müşteri hizmetlerini arayınız.. ");

            EXIT:
            Console.ReadKey();
        }
    }
}
