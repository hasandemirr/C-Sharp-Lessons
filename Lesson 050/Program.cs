using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_050
{
    class Program
    {
        // Sifreyi bilene kadar soran kod
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            int a= 123;

            do
            {
                Console.WriteLine("Lütfen sifreyi giriniz");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a != 123);

            Console.WriteLine("Şifre doğru");

        }
    }
}
