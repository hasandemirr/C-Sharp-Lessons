using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_048
{
    class Program
    {
        static void Main(string[] args)
        {
            NullableNedir();
            ForDongusu();
            Console.ReadLine();
        }

        private static void ForDongusu()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void NullableNedir()
        {
            string a = null;
            //string class null olabilir

            // int ve double struct olduklarından null olamazlar

            Nullable<int> sayi = null;
            DateTime tarih = new DateTime(); // datetime ı boş bırakırsanız garip bir tarih verir
            Console.WriteLine();
        }
    }
}
