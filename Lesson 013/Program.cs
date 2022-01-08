using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_013
{
    class Program
    {
        // Bool Boolean: True veya False değerini alır.
        static void Main(string[] args)
        {
            bool onerme1 = 5 > 3; // True
            bool onerme2 = 7 != 6; // True
            bool onerme3 = 8 == 6; //False

            //** ornek kullanıcının resit olup olmadıgını sorgulayan kod yazınız **//

            Console.WriteLine("Kaç yaşınızdasınız?");
            int yas = Convert.ToInt32(Console.ReadLine());
            bool resit = yas >= 12;
            Console.WriteLine(resit);
            Console.ReadLine();

        }
    }
}
