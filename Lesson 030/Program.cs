using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_030
{
    class Program
    {
        // sayıların ortalamasını metod ile ekrana yazdıran kod
        static void Main(string[] args)
        {
            int sayi1 = sayiiste();
            int sayi2 = sayiiste();
            Console.WriteLine((sayi1 + sayi2) / 2);
            Console.ReadLine();
        }

        private static int sayiiste()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
