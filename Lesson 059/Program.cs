using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_059
{
    class Program
    {
        static void Main(string[] args)
        {
            breakandcontinue();
            Console.ReadLine();
        }

        private static void breakandcontinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
            for (int j = 0; j < 10; j++)
            {
                if (j% 2 == 0)
                        continue;
                Console.WriteLine(j);
            }
        }
    }
}
