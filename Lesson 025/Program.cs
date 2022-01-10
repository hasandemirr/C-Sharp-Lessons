using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_025
{
    class Program
    {
        // iki sayi isteyen ve bu iki sayiyi karşılaştıran kod
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("İlk sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine()); // ? ise anlamına gelir, : değilse anlamına gelir
            string cevap = sayi1 > sayi2 ? sayi1 + " büyüktür " + sayi2 + "den" : sayi1 == sayi2 ? "İki sayı eşittir" : sayi1 + " küçüktür " + sayi2 + "den";
            Console.WriteLine(cevap);
        }
    }
}
