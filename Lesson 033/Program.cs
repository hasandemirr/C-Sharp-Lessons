using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_33
{
    class Program
    {
        // Pascal Case: Her Kelimenin Baş Harfi Büyük
        // Camel Case: ilk Kelimenin Baş Harfi Küçük
        // Macar Notasyonu: hepsi küçük
        static void Main(string[] args)
        {
            FarklıTarih();
            Console.ReadLine();
        }

        private static void FarklıTarih()
        {
            DateTime tarih=Convert.ToDateTime("2019-01-01"); //  String türündeki ifadeyi tarihe çevirme
            Console.WriteLine(tarih);
            DateTime mezuniyet = new DateTime(2019, 06, 20);
            Console.WriteLine("Yılın " + mezuniyet.DayOfYear + ". günü");
            Console.WriteLine(mezuniyet.DayOfWeek);
        }
    }
}
