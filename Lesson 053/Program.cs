using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_053
{
    class Program
    {
        // İstenilen sayının faktöriyelini alın
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("Bir sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int faktroriyel = 1;
            for (int b = 1;  b<= a; b++)
            {
                faktroriyel = b * faktroriyel;
            }
            Console.WriteLine(faktroriyel);

        }
    }
}
