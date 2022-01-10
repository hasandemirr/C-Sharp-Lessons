using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_027
{
    class Program
    {
        // girilen sayi tek ise karesini çift ise küpünü alan kod
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("Sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());

            string sonuc = sayı % 2 == 1 ? "sayının küpü = " + sayı * sayı * sayı : "sayının karesi = " + sayı * sayı;
            Console.WriteLine(sonuc);
        }
    }
}
