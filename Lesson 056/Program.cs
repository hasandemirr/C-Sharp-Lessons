using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_056
{
    class Program
    {
        // Ekrana üçgen bastıran kod
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
