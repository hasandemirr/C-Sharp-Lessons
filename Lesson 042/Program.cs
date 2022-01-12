using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_042
{
    class Program
    {
        static void Main(string[] args)
        {
            Loglama();
            Console.WriteLine();
        }

        private static void Loglama()
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 3)
                {
                    throw new Exception("böyle sayı olmaz");
                }

            }
            catch(Exception hata) //Hatanın bilgilerine ulaşmak için exception kullanılır
            {
                File.AppendAllText("log.txt", Environment.UserName); // log.txt adında dosya oluşturur ve dosyaya bilgisayarın adını yazar
                File.AppendAllText("log.txt", Environment.NewLine); // log.txt dosyasında alt satıra iner
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH.mm")); //dosyada tarihi girer 
                File.AppendAllText("log.txt", Environment.NewLine); 
                File.AppendAllText("log.txt", hata.Message); // Hatayı yazdırır
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace); // Hatanın yerini yazdırır
                File.AppendAllText("log.txt", Environment.NewLine+"****************"+Environment.NewLine);


            }
            
        }
    }
}
