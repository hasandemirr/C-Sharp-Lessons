using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_016
{
    class Program
    {
        // Kullanıcıdan yaşını isteyin
        // Reşitse Ehliyet alıp alamayacağını geri bildirin
        static void Main(string[] args)
        {
            resit();
            Console.ReadLine();
        }

        private static void resit()
        {
            Console.WriteLine("kaç yaşınızdasınız?");
            int yas = Convert.ToInt32(Console.ReadLine());
            if(yas>=18)
            {
                Console.WriteLine("ehliyet alabilirsiniz.");
            }
            else
            { 
                Console.WriteLine("ehliyet alamazsınız"); 
            }


        }
    }
}
