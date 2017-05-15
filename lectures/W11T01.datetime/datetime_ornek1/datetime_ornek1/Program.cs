using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;

            Console.WriteLine("Dogum tarihinizi giriniz (gg/aa/yyy): ");
            String inpt = Console.ReadLine();

            if (inpt.Contains('/'))
                inpt = inpt.Replace('/', '.');

            string[] pinpt = inpt.Split('.');

            dt = new DateTime(Convert.ToInt32(pinpt[2]), Convert.ToInt32(pinpt[1]), Convert.ToInt32(pinpt[0]));

            TimeSpan yas = DateTime.Now.Subtract(dt);

            Console.WriteLine("Yaşınız: {0}", (yas.Days / 365));

            Console.ReadKey();
        }
    }
}
