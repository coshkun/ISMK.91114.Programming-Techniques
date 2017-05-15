using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_havale_ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            bool y = true, surekli = true, banka = true;
            int kalan = 0, a = 3;
            string sifre = null, kuladi = null;//ilk değerler boş olarak atandı.

           while(true)
            {
                Console.Write("Giriş yapmak için kullanıcı adını giriniz:");
                kuladi = Console.ReadLine();
                Console.Write("Şifrenizi giriniz:");
                sifre = Console.ReadLine();

                surekli = true;
                y = true;
                banka = true;

                if (sifre == "123" && kuladi == "mehmet" && kalan < 4)
                {
                    Console.Clear();//console ekranı temizle
                    Console.WriteLine("Giriş Yapıldı");

                    while (surekli)
                    {
                        for (; y;)
                        {
                            Console.WriteLine("Banka tercihinizi yapınız");
                            Console.WriteLine("Akbank\t\t[1]");
                            Console.WriteLine("Vakıfbank\t[2]");
                            Console.WriteLine("Halkbankası\t[3]");
                            Console.WriteLine("Ziraat Bankası\t[4]");

                            int z = Convert.ToInt32(Console.ReadLine());

                            if (z < 5 && z > 0)
                            {
                                banka = true;

                                for (; banka;)
                                {
                                    Console.Write("Havale yapılacak hesap numarasını giriniz:");
                                    string hesap = Console.ReadLine();

                         if (hesap.Length == 10)// hesap uzunluğunun kontrolü
                                    {
                                        Console.WriteLine("Havale Tutarı:");
                                        int havale = Convert.ToInt32(Console.ReadLine());

                                        if (havale < 10)
                                            Console.WriteLine("Havale tutarı 10tl'den düşük olamaz");

                                        else
                                        {
               Console.WriteLine("Havale işlemi yapılmıştır. Tutar:{0} \nHesap No:{1}", havale, hesap);
                                Console.WriteLine("Çıkış yapılsın mı? Evet (e) Hayır (h)");
                                            string cikis = Console.ReadLine();

                                            if (cikis == "e" || cikis == "E")
                                            {
                                                surekli = false;
                                                y = false;
                                                banka = false;

                                                break;
                                            }

                                            else if (cikis == "h" || cikis == "H")
                                                banka = false;
                                        }

                                    }

                                    else
                                        Console.WriteLine("Hesap numarası yanlış");
                                }

                            }

                            else
                                Console.WriteLine("Lütfen 1 ile 4 arası seçiminizi giriniz");
                        }
                    }
                }

                else
                {
                    a--;
                    kalan++;
                    Console.WriteLine("Kalan şifre kullanım hakkınız:{0}", a);

                    if (a == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hesabınız Bloke edildi");
                        break;
                    }


                }
            }

            Console.ReadKey();


        }
    }
}
