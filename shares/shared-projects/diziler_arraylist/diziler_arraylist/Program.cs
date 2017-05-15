using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//arraylist kütüphane dosyası

namespace diziler_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Birden fazla farklı değişken türü kullanılacağı durumlarda
             tercih edilebilir. Tek değişken türü kullanılacaksa tercih 
             edilmemesi gerekir. Nedeni, bu metot object türünden verileri
             aldığı için gereksiz kapasite kullanımına neden olacaktır.
             */

            ArrayList x = new ArrayList();
            x.Add("İsmek");
            x.Add(15);
            x.Add(123.258f);
            x.Add('?');

            /* int üründen farklı bir listeleme yöntemi kullanımı
            List<int> lst = new List<int>();
            lst.Add(15);
            
            */

            foreach (object a in x)
                Console.Write(a + " ");
        }
    }
}
