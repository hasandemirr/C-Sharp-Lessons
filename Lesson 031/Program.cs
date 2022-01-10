using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_031
{
    class Program
    {
        // Kullanıcının doğduğu yılı sorgulayarak yaşını hesaplayan metod
        static void Main(string[] args)
        {          
            int yasim = yasibul();
            Console.WriteLine("Yaşınız " +yasim);
            Console.ReadLine();
        }

        private static int yasibul()
        {
            return DateTime.Today.Year - yıl();
        }

        private static int yıl()
        {
            Console.WriteLine("Doğduğunuz yılı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
