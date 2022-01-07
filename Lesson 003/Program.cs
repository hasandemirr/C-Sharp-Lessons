using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_003
{
    class Program
    {
        //kullanıcıya yaşını sorun
        //En güzel yaşın kullanıcının yaşı olduğunu belirtin
        //bip sesi ile programı sonlandırın
        static void Main(string[] args)
        {
            Console.Write("Kaç yaşındasınız ? ");
            var yas = Console.ReadLine();
            Console.WriteLine("En güzel yaş " + yas);
            Console.ReadLine();
            Console.Beep(); //bip sesi alma komutu

        }
    }
}
