using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_058
{
    class Program
    {
        // 1-50 arasında kaç asal sayı var
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();

        }

        private static void ornek()
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int asaltane = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (Asalmi(i))
                    asaltane++;
            }
            Console.WriteLine("1 ile " + sayi + " arasında " + asaltane + " tane asal sayi vardır");
        }

        private static bool Asalmi(int deger)
        {
            bool isasal = true;
            if(deger==1 || deger == 0)
            {
                return false;
            }
            for (int i =2; i < deger; i++)
            {
                if(deger%i==0)
                {
                    isasal = false;
                }
                
            }
            return isasal;
        }
    }
}
