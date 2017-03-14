using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akis_kontrol_login
{
    class Program
    {
        /*
        Kullanıcı adı ve şifre sorgulayan yapıyı if ve else ile yapalım.
        login doğru ise ekrana "Giris yapıldı" değilse hata mesajı versin.
        */
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;
            Console.WriteLine("Kullanı adını giriniz:");
            kullaniciadi = Console.ReadLine();
            Console.WriteLine("Sifre giriniz:");
            sifre = Console.ReadLine();

            if (kullaniciadi == "admin")
            {
                if(sifre == "123456")
                {
                    Console.WriteLine("Giriş Başarılı! Hoşgeldin, " + kullaniciadi);
                }
                else
                {
                    Console.WriteLine("Sifreniz Hatalı!");
                }
            }
            else
            {
                Console.WriteLine("kullanıcı adınız hatalı, tekrar deneyiniz..");
            }
            
            Console.ReadKey();
        }
    }
}
