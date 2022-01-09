using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_020
{
    class Program
    {
        /* kullanıcı adı ve şifre doğrulaması yapan kod */
        static void Main(string[] args)
        {
            şifre();
            Console.ReadLine();
        }

        private static void şifre()
        {
            Console.WriteLine("Kullanıcı adınızı giriniz.");
            string userid = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            string userkey = Console.ReadLine();
            if(userid=="Admin" && userkey=="123") // && kullanımında if'in içerisindeki iki önerme de doğruysa ancak çalışır
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı giriş.");
            }

        }
    }
}
