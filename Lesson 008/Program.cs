using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_008
{
    class Program
    {
        // pc: Alışveriş tutarınız?
        // k: 100
        // (%10 indirim olduğunu varsayalım)
        // pc: 10 tl indirim kazandınız.
        static void Main(string[] args)
        {
            Console.WriteLine("Alışveriş tutarınız ne kadar?");
            var tutar = Console.ReadLine();
            int yenitutar = Convert.ToInt32(tutar);
            yenitutar = yenitutar / 10;
            Console.WriteLine("Tebrikler, " + yenitutar + "TL indirim kazandınız!");
            Console.ReadLine();
        }
    }
}
