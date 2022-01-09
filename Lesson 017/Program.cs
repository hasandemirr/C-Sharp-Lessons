using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_017
{
    class Program
    {
        // Pc: Hangi programlama dilini seviyorsunuz?
        // K:
        // cevap c# ise harika, php ise güzelmiş, farklı bir cevap ise ama c# da güzel
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("Hangi programlama dilini seviyorsunuz");
            string cevap = Console.ReadLine();
            if(cevap=="c#"|| cevap == "C#")
            {
                Console.WriteLine("Harika!");
            }
            else if(cevap=="php" || cevap == "PHP")
            {
                Console.WriteLine("Fevkalade!");
            }
            else
            {
                Console.WriteLine("C# da güzel.");
            }
        }
    }
}
