using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_036
{
    class Program
    {
        static void Main(string[] args)
        {
            TarihFormat();
            Console.ReadLine();
        }

        private static void TarihFormat()
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString()); // Sadece tarihi verir
            Console.WriteLine(simdi.ToLongDateString()); // gün, ay, yıl şeklinde verir
            Console.WriteLine(simdi.ToShortTimeString()); // sadece saati verir
            Console.WriteLine(simdi.ToLongTimeString()); // sadece saati saniyesi ile verir

            // MM ay (sayı) 
            // MMMM ay (yazı)
            // dd gün
            // yyyy yıl
            // hh (12 saat)
            // HH(24 saat)

            Console.WriteLine(simdi.ToString("MM/dd/yyyy MMMM dd - can hh:mm HH:mm"));

        }
    }
}
