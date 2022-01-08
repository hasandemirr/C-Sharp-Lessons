using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_012
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayı = 5;
            Console.WriteLine("Sayı: "+sayı);
            Console.WriteLine("Sayının karesi: " + sayı * sayı);
            Console.WriteLine("Sayının yarısı: " + sayı / 2);
            Console.WriteLine("Sayının 2 ile bölümünden kalan: " + sayı % 2);
            Console.ReadLine();
        }
    }
}
