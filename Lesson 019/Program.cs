using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_019
{
    class Program
    {
        /* Kullanıcıya 3 soruluk bir test ve testin sonunda doğru yanlış sayısını ifade eden kod*/
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            int doğru = 0;
            int yanlış = 0;
            Console.WriteLine("Türkiyenin başkenti neresidir?");
            string cevap1 = Console.ReadLine();
            if(cevap1=="Ankara"|| cevap1== "ankara")
            {
                doğru++;
            }
            else
            {
                yanlış++;
            }
            Console.WriteLine("Almanya hangi kıtadadır?");
            string cevap2 = Console.ReadLine();
            if(cevap2=="Avrupa"||cevap2=="avrupa")
            {
                doğru++;
            }
            else
            {
                yanlış++;
            }
            Console.WriteLine("Kaymağı ile ünlü ilimiz neresidir? ");
            string cevap3 = Console.ReadLine();
            if (cevap3 == "Afyonkarahisar" || cevap3 == "afyonkarahisar")
            {
                doğru++;
            }
            else
            {
                yanlış++;
            }
            Console.WriteLine("Toplam doğru sayısı: " + doğru);
            Console.WriteLine("Toplam yanlış sayısı: " + yanlış);


        }
    }
}
