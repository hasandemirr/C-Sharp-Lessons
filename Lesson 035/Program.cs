using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_035
{
    class Program
    {
        static void Main(string[] args)
        {
            ileritarih();
            Console.ReadLine();
        }

        private static void ileritarih()
        {
            DateTime bugün = DateTime.Today;
            DateTime biraysonra = bugün.AddMonths(1); // bugünden 1 ay sonrası
            DateTime birayönce = bugün.AddMonths(-1); // bugünden 1 ay öncesi
            DateTime birgünsonra = bugün.AddDays(5); // bugünden 5 gün sonrası
            DateTime birgünönce = bugün.AddDays(-5); // bugübden 5 gün öncesi

            Console.WriteLine("Bugün: " + bugün);
            Console.WriteLine("Bir ay sonrası: " +biraysonra);
            Console.WriteLine("Bir ay öncesi: " +birayönce);
            Console.WriteLine("Beş gün sonrası: " +birgünsonra);
            Console.WriteLine("Beş gün öncesi: " +birgünönce);
        }
    }
}
