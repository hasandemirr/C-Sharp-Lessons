using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_010
{
    class Program
    {
        // Date time sınıfının Today elemanının Year elemanını bir değişkene atayalım
        // Date time sınıfının Today elemanının Month      "     "    "         "
        // Date time sınıfının Today elemanının Day        "     "     "         "
        // Yarının tarihini ekrana yazdırın
        static void Main(string[] args)
        {
            int yıl = DateTime.Today.Year;
            int ay = DateTime.Today.Month;
            int gün = DateTime.Today.Day+1;
            Console.WriteLine(gün + "." + ay + "." + yıl);
            Console.ReadLine();
        }
    }
}
