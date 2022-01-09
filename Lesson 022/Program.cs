using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_022
{
    class Program
    {
        // 65 yaş üzerine ve öğrencilere ücretsiz geçiş hakkı veren kod
        static void Main(string[] args)
        {
            Veya(); // veya koşulu || ile gösterilir, koşullardan birisinin karşılanması yeterdir
            Console.ReadLine();
        }

        private static void Veya()
        {
            Console.WriteLine("Kaç yaşınızdasınız?");
            int cevap1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci misiniz? (e/h)");
            string cevap2 = Console.ReadLine();
            if(((cevap1>0 && cevap1<=24) && cevap2 == "e") || cevap1>=65)
            {
                Console.WriteLine("İndirimli geçiş");
            }
            else
            {
                Console.WriteLine("Ücretli geçiş");
            }            
        }
    }
}
