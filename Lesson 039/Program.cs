using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_039
{
    class Program
    {
        // sınav notuna göre try catch metodu ile 3 farklı geri bildirim veren program
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("Lütfen sınav notunu giriniz.");
            try
            {
                int not = Convert.ToInt32(Console.ReadLine());
                if (not >= 0 && not <= 50)
                {
                    Console.WriteLine("Daha çok çalışmalısın.");
                }
                else if (not >= 51 && not <= 69)
                {
                    Console.WriteLine("Daha iyi olabilir");
                }
                else if (not >= 70 && not <= 100)
                {
                    Console.WriteLine("Başarılı");
                }
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş");
            }
            

        }
    }
}
