using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_051
{
    class Program
    {
        static void Main(string[] args)
        {
            foreachdongusu() ;
            Console.ReadLine();
        }

        private static void foreachdongusu()
        {
            // dizilerdeki elemanlar arasındaki döngü için foreach kullanılır
            string[] ulkeler = { "Türkiye", "Amerika", "Almanya" };
            foreach(var item in ulkeler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
