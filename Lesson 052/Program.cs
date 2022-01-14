using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_052
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            ornek2();
            Console.ReadLine();
        }

        private static void ornek2()
        {
            // Dizideki en büyük negatif sayiyi ve en küçük pozitif sayiyi ekrana yazdıran kod
            int[] sayidizisi = { 19, 45, -247, 212, -134, 319, -78 };
            int kucukpozitif = int.MaxValue;
            int buyuknegatif = int.MinValue;

            foreach (var item in sayidizisi)
            {
                if(item>0 && item<kucukpozitif)
                {
                    kucukpozitif = item;
                }
                else if(item<0 && item>buyuknegatif)
                {
                    buyuknegatif = item;
                }
            }
            Console.WriteLine("En büyük negatif sayı= " + buyuknegatif);
            Console.WriteLine("En küçük pozitif sayı= " + kucukpozitif);
        }

        private static void Ornek1()
        {
            int[] sayilar = { 5, 9, 15, 17 };
            //her sayinin 1 eksiğini alt alta ekrana yazdıran kod
            foreach (var item in sayilar)
            {
                Console.WriteLine((item - 1) * 3);
            }
        }
    }
}
