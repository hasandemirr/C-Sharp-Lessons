using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_032
{
    class Program
    {
        //Kullanıcının yaşının rakamları toplamını ekrana yazdıran bir metod yazalım.
        static void Main(string[] args)
        {           
            rakamlar();
            Console.ReadLine();
        }

        private static void rakamlar()
        {
            int yaslar = yasibul();
            int a = yaslar / 10;
            int b = yaslar % 10;
            Console.WriteLine("Yaşınız " + yaslar);
            Console.WriteLine("Basamak toplamı = " + (a + b));

        }

        private static int yasibul()
        {
            return DateTime.Today.Year - yıl();
        }

        private static int yıl()
        {
            Console.WriteLine("Lutfen doğdunuz yılı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
