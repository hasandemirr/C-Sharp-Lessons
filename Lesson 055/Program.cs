using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_055
{
    // Alfabeyi ekrana bastıran kod
    class Program
    {
        static void Main(string[] args)
        {
            alfabe();
            Console.ReadLine();
        }

        private static void alfabe()
        {
            for (int i ='A'; i <= 'Z'; i++)
            {
                Console.Write((char)i+" "); // char(i) = ascii koduna karşılşık gelen harfi verir
            }
        }
    }
}
