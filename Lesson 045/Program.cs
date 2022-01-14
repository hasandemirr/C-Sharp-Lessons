using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_045
{
    class Program
    {
        // Proje dosyasında kaç tane dosya olduğunu yazdırın
        // ilk dosyanın yolunu yazdırın
        // dosya yolundaki son \ daki dosya ismini yazdırın
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            string[] dosyalar = Directory.GetFiles(@"C:\Users\metha\Desktop\C# Lessons\Lesson 045");
            // Directory.GetFiles komutu dosyaları çağırır ve Directory.GetFiles(@"asdadsad") şeklinde kullanılır
            Console.WriteLine("C sürücüsünde " + dosyalar.Length + " kadar dosya var");
            Console.WriteLine("İlk dosyanın yolu ---> " + dosyalar[0]);
            string[] dosyaadlar = dosyalar[0].Split('\\');
            Console.WriteLine("Dizinin son elemanı ---> "+dosyaadlar[dosyaadlar.Length - 1]);
        }
    }
}
