using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_061
{
    class Program
    {
        // kullanıcının pc ile taş/kağıt/makas oynadığı skoru tutabilen, q ile oyundan çıkılabilen kod
        static void Main(string[] args)
        {
            taskagitmakas();
            Console.ReadLine();
        }

        private static void taskagitmakas()
        {
            int kazanan = 0;
            int kaybeden = 0;
            string kullanici = "";
            do
            {
                Console.WriteLine("Lütfen taş, kağıt ve makas seçeneklerinden birisini giriniz");
                kullanici = Console.ReadLine();
                Console.WriteLine(" ");
                string[] secenek = { "Taş", "Kağıt", "Makas" };
                Random pc = new Random();
                int a = pc.Next(3);
                Console.WriteLine("Kullanıcı: " + kullanici);
                Console.WriteLine("PC:        " +secenek[a]);
                Console.WriteLine(" ");

                if(kullanici == "Taş" && secenek[a] == "Kağıt")
                {
                    kaybeden++;
                }
                if (kullanici == "Taş" && secenek[a] == "Makas")
                {
                    kazanan++;
                }
                if (kullanici == "Makas" && secenek[a] == "Kağıt")
                {
                    kazanan++;
                }
                if (kullanici == "Makas" && secenek[a] == "Taş")
                {
                    kaybeden++;
                }
                if (kullanici == "Kağıt" && secenek[a] == "Makas")
                {
                    kaybeden++;
                }
                if (kullanici == "Kağıt" && secenek[a] == "Taş")
                {
                    kazanan++;
                }
                Console.WriteLine("Kullanıcı: " + kazanan);
                Console.WriteLine("PC: " + kaybeden);
                Console.WriteLine(" ");
                Console.WriteLine("**********************************************");
                Console.WriteLine(" ");


            } while (kullanici!="q");
        }
    }
}
