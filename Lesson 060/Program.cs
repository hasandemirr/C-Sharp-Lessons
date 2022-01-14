using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_060
{
    class Program
    {
        static void Main(string[] args)
        {
            rastgele();
            Console.ReadLine();
        }

        private static void rastgele()
        {
            Random r = new Random();
            int sayi = r.Next(10); //0 ile 10 arasında rastgele bir sayı atar
            Console.WriteLine("Rastgele sayi: " + sayi);

            string[] sehir = { "İstanbul", "Ankara", "Bursa" };

            Random city = new Random();
            int rastgelesehir = city.Next(2); //gekebilecek sayilar 0-1-2
            Console.WriteLine("Rastgele şehir: " + sehir[rastgelesehir]);
        }
    }
}
