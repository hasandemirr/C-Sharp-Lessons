using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_024
{
    class Program
    {
        static void Main(string[] args)
        {
            InLineif();
            Console.ReadLine();
        }

        private static void InLineif()
        {
            // if else if ile aynı amaç için kullanılır
            int sayi = 9;
            bool _3unkatimi = 9 % 3 == 0 ? true : false;
            string kullanici_sehir = Console.ReadLine();
            string sehir = kullanici_sehir == "İstanbul" ? "34" : kullanici_sehir == "istanbul" ? "34" : "0";
            // kullanici_sehir İstanbul'a eşitse 34, istanbul'a eşitse 34, değilse 0 yazdıran kod.
            Console.WriteLine(sehir);

        }
    }
}
