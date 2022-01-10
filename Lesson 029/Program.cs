using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_029
{
    class Program
    {
        // kullanıcının cinsiyeti, kilosu ve boyuna göre endeks durumunu veren kod
        // endeks=kilo/boy*boy(metre)
        // erkekler için 20-25 kadınlar için 19 24
        static void Main(string[] args)
        {
            endekshesabı();
            Console.ReadLine();
        }

        private static void endekshesabı()
        {
            Console.WriteLine("Lütfen cinsiyetinizi giriniz");
            string cinsiyet = Console.ReadLine();
            Console.WriteLine("Lütfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu cm cinsinden olacak şekilde giriniz");
            int boy = Convert.ToInt32(Console.ReadLine());

            double metre = boy / 100;
            double endeks = kilo / boy * metre;

            switch (cinsiyet)
            {
                case "kadın":
                    Console.WriteLine(endeks < 19 ? "Zayıf" : endeks < 24 ? "İdeal" : "Şişman");
                    break;
                case "erkek":
                    Console.WriteLine(endeks < 20 ? "Zayıf" : endeks < 25 ? "İdeal" : "Şişman");
                    break;
                default:
                    Console.WriteLine("Geçersiz Cinsiyet");
                    break;
            }
        }
    }
}
