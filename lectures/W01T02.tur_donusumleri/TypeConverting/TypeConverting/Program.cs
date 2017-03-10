using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //string y;
            //y = Console.ReadLine();
            //x = Convert.ToInt32(y);
            //Console.Write("klavyeden atanan değer=" + x);
            //Console.ReadKey();

            /*
            Tür            Kullanım şekli:
            bool   Convert.ToBoolean(x);
            byte   Convert.ToByte(x) ;
            Sbyte  Convert.ToSbyte();
            int16  Convert.ToInt16();
            int32  Convert.ToInt32();
            double Convert.ToDouble();
            float  Convert.ToSingle();
            string Convert.ToString();
            */


            //float x=2545;
            //string y;
            //y = x.ToString(); //metinsel ifadenin içine sayı aktarımı
            //Console.WriteLine("metinsel ifade içine aktarılan sayı" + y);
            //y = Console.ReadLine();
            //x = Convert.ToInt32(y);
            //Console.Write("klavyeden atanan değer=" + x);
            //Console.ReadKey();

            //float sayi1, sayi2, sonuc;
            //string a;
            //Console.WriteLine("lütfen bir sayı giriniz :");
            //a = Console.ReadLine();//klavyeden okuma yap
            //sayi1 = Convert.ToSingle(a);//okunan değeri sayi1 içine ata
            //Console.WriteLine("lütfen diğer sayıyı girniz :");
            //a = Console.ReadLine();//klavyeden tekrar oku
            //sayi2 = Convert.ToSingle(a);//okunan değeri sayi2 içine ata
            //sonuc = sayi1 + sayi2;//sayi ve sayi2 yi topla
            //Console.WriteLine("toplama sonucu : " + sonuc);//toplamı ekrana yazdır
            //Console.ReadKey();//tuşa basılmasını bekle
            /*
            not: sring değişkeninin içerisine sayı atamas yaplacaksa kullanılacak durum :
            string x;
            int a= 25;
            x= a.ToSingle();
            */

            // float sayi1, sayi2, sonuc;
            //string a;
            // Console.WriteLine("lütfen toplama işlemi için bir sayı giriniz :");
            // a = Console.ReadLine();//klavyeden okuma yap
            // sayi1 = Convert.ToSingle(a);//okunan değeri sayi1 içine ata
            // Console.WriteLine("lütfen diğer sayıyı girniz :");
            // a = Console.ReadLine();//klavyeden tekrar oku
            // sayi2 = Convert.ToSingle(a);//okunan değeri sayi2 içine ata
            // sonuc = sayi1 + sayi2;//sayi ve sayi2 yi topla
            // Console.WriteLine("toplama sonucu : " + sonuc);//toplamı ekrana yazdır

            // Console.WriteLine("lütfen çıkarma işlemi için bir sayı giriniz :");
            // a = Console.ReadLine();//klavyeden okuma yap
            // sayi1 = Convert.ToSingle(a);//okunan değeri sayi1 içine ata
            // Console.WriteLine("lütfen diğer sayıyı girniz :");
            // a = Console.ReadLine();//klavyeden tekrar oku
            // sayi2 = Convert.ToSingle(a);//okunan değeri sayi2 içine ata
            // sonuc = sayi1 - sayi2;//sayi1 ve sayi2 yi çıkar
            // Console.WriteLine("çıkarma işlemi sonucu : " + sonuc);//farkı ekrana yazdır

            // Console.WriteLine("lütfen bölme işlemi için bir sayı giriniz :");
            // a = Console.ReadLine();//klavyeden okuma yap
            // sayi1 = Convert.ToSingle(a);//okunan değeri sayi1 içine ata
            // Console.WriteLine("lütfen diğer sayıyı girniz :");
            // a = Console.ReadLine();//klavyeden tekrar oku
            // sayi2 = Convert.ToSingle(a);//okunan değeri sayi2 içine ata
            // sonuc = sayi1 / sayi2;//sayi1 ve sayi2 yi böl
            // Console.WriteLine("bölme işlemi sonucu : " + sonuc);//bölme sonucunu ekrana yazdır

            // Console.WriteLine("lütfen çarpma işlemi için bir sayı giriniz :");
            // a = Console.ReadLine();//klavyeden okuma yap
            // sayi1 = Convert.ToSingle(a);//okunan değeri sayi1 içine ata
            // Console.WriteLine("lütfen diğer sayıyı girniz :");
            // a = Console.ReadLine();//klavyeden tekrar oku
            // sayi2 = Convert.ToSingle(a);//okunan değeri sayi2 içine ata
            // sonuc = sayi1* sayi2;//sayi1 ve sayi2 yi çarp
            // Console.WriteLine("çarpım işlemi sonucu : " + sonuc);//çarpımı ekrana yazdır
            // Console.ReadKey();//tuşa basılmasını bekle


            //float sayi1, sayi2, sonuc,sonuc2,sonuc3,sonuc4;
            //Console.WriteLine("lütfen toplama işlemi için bir sayı giriniz :");        
            //sayi1 = Convert.ToSingle(Console.ReadLine());//okunan değeri sayi1 içine ata
            //Console.WriteLine("lütfen diğer sayıyı girniz :");            
            //sayi2 = Convert.ToSingle(Console.ReadLine());//okunan değeri sayi2 içine ata
            //sonuc = sayi1 + sayi2;//sayi ve sayi2 yi topla
            //Console.WriteLine("toplama sonucu : " + sonuc);//toplamı ekrana yazdır
            //sonuc2 = sayi1 - sayi2;//sayi ve sayi2 yi farkla
            //Console.WriteLine("çıkarma sonucu : " + sonuc2);//farkı ekrana yazdır
            //sonuc3 = sayi1 * sayi2;//sayi ve sayi2 yi böl
            //Console.WriteLine("çarpma sonucu : " + sonuc3);//çarpımı ekrana yazdır
            //sonuc4 = sayi1/sayi2;//sayi ve sayi2 yi böl
            //Console.WriteLine("bölme sonucu : " + sonuc4);//bölümü ekrana yazdır
            //Console.ReadKey();



            /* const tamımlanan değişkeni sabit tutmak için kullanılır örn : const int x =2 */
            ///*mod alma*/
            //int x = 10,y=3,kalan;
            //kalan = x % y;
            //Console.WriteLine(kalan);
            //Console.ReadKey();
            ///*mod alma*/

            //int x, y, kalan;
            //Console.WriteLine("Mod ilk sayı için bir sayı giriniz");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //y = Convert.ToInt32(Console.ReadLine()); 

            //kalan = x % y;
            //Console.WriteLine(kalan);
            //Console.ReadKey();


            /*OPERATORLER*/
        }
    }
}
