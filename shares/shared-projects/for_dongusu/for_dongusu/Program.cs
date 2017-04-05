using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            Console.Write("Tek Sayılar :\t");
            for (int x=0;x<=50;x++)
            {
                
                if(a<50)
                {
                    for(int y=1;y<=50;y+=2)
                {
                    Console.Write(" "+ y);
                    a+=2;
                }
                    Console.Write("\nÇift Sayılar:\t");
                }

                if (x%2==0)
                    Console.Write(" "+ x);
            }        
            Console.ReadKey();
        }
    }
}
