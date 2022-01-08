using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_011
{
    class Program
    {
        // Kullanıcıdan 1-5 arası sayı isteyin
        // Math sınıfının PI elemanını bir değişkene atayın.
        // (not: küsüratsız)
        // İki değeri çarpıp ekrana yazdırın
        static void Main(string[] args)
        {
            Console.WriteLine("1-5 arasında değer giriniz");
            int girilen = Convert.ToInt32(Console.ReadLine());
            double sss = Math.PI; // Pi sayısı tamsayı olmadığı için double şeklinde çağırıldı
            int küsüratsız = Convert.ToInt32(sss);
            Console.WriteLine(küsüratsız * girilen);
            Console.ReadLine();

        }
    }
}
