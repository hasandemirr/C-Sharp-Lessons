using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_049
{
    class Program
    {
        static void Main(string[] args)
        {
            while_for_farki();
            Console.ReadLine();
        }

        private static void while_for_farki()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int sayi = 0;
            while (sayi < 5)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
        }
    }
}
