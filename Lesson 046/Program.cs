using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_046
{
    class Program
    {
        // dizi şeklinde 3 soru sorup Yanlış sayısını ekrana yazdıran kod
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            string[] sorular = { "34 plakalı ilimiz neresidir?", "Muzu ile meşhur olan ilçemiz neresidir", "Mersin hangi bölgededir?" };
            string[] cevap = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sorular[i]);
                cevap[i] = Console.ReadLine();
            }
            int dogru = 0;
            int yanlis = 0;
            if(cevap[0]=="İstanbul")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if (cevap[1] == "Anamur")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if (cevap[2] == "Akdeniz")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlis);


        }
    }
}
