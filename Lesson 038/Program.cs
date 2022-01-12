using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_038
{
    class Program
    {
        // Kullanıcının kaç gün yaşadığını ve hangi hafta doğduğunu yazdıran kod
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("Lütfen doğum tarihinizi giriniz");
            DateTime dogum = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dogum.DayOfWeek);
            int ömür = (int)(DateTime.Today - dogum).TotalDays;
            Console.WriteLine(ömür);
        }
    }
}
