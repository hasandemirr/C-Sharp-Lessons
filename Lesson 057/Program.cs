using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_057
{
    class Program
    {
        // Girilen sayının asallığını kontrol eden kod
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool asalmi = true;
            if(sayi==1 || sayi==0)
            {
                throw new Exception("Başka sayı girmeliydiniz.");
            }
            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    asalmi = false;
                }
            }
            if(asalmi)
            {
                Console.WriteLine(sayi + " sayısı asaldır");
            }
            else
            {
                Console.WriteLine(sayi + " sayısı asal değildir");
            }
        }
    }
}
