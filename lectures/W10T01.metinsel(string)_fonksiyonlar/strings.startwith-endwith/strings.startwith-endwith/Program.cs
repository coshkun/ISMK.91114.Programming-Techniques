using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings.startwith_endwith
{
    class Program
    {
        static void Main(string[] args)
        {
            string web = "www.ismek.com";
            if (web.EndsWith(".com"))
            {
                if (web.StartsWith("www."))
                {
                    Console.WriteLine("web adresi doğrulandı.");
                }
            }

            Console.ReadKey();
        }
    }
}
