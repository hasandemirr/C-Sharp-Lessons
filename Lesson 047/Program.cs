using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_047
{
    class Program
    {
        // öğrencinin adı soyadı boş ya da 3 karakterden azsa uyarı veren kod
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("Aradığınız öğrenci adı soyadı");
            string adsoyad = Console.ReadLine();

            if(string.IsNullOrEmpty(adsoyad.Trim())) //IsNullOrEmpty ifade boş mu kontrol eder // Trim ifadedeki boşlukları kaldırır
            {
                Console.WriteLine("boş bırakmayınız");
            }
            else if(adsoyad.Length<3)
            {
                Console.WriteLine("En az 3 karakter giriniz");
            }
            else
            {
                Console.WriteLine("teşekkürler");
            }
        }
    }
}
