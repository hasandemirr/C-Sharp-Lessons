using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_007
{
    class Program
    {
        // Yaşı sorun
        // 5 eksiği yaşında gösteriyorsunuz şeklinde yazdırın
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Yaşınızdasınız? ");
            var yas = Console.ReadLine();
            int yasim = Convert.ToInt32(yas);
            yasim = yasim - 5;
            Console.Write(yasim);
            Console.Write(" yaşında gösteriyorsunuz.");
            Console.ReadLine();
        }
    }
}
