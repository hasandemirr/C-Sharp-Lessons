using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_015
{
    class Program
    {
        static void Main(string[] args)
        {
            ornek1();
            Console.ReadLine();
        }

        private static void ornek1()
        {
            if(true)
            {
                Console.WriteLine("Bu kod her zaman çalışır.");
            }
            if(DateTime.Today.Day==13)
            {
                Console.WriteLine("Ayın 13'ü geldi indirim zamanı.");
            }
            else
            {
                Console.WriteLine("İndirim için lütfen ayın 13'ü bekleyin.");
            }
        }
    }
}
