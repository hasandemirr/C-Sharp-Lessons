using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_037
{
    class Program
    {
        // 10 gün sonrasını gün ay yıl formatında yazdıran örnek
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            DateTime simdi = DateTime.Now;
            DateTime ongunsonra = simdi.AddDays(10);
            Console.WriteLine(ongunsonra.ToString("dd.MM.yyyy"));
        }
    }
}
