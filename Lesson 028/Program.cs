using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_028
{
    class Program
    {
        static void Main(string[] args)
        {
            switchusing();
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            // kullanıcının seçtiği dile göre selam veren kod
            Console.WriteLine("Dil seçiniz (tr/de/en)");
            string cevap = Console.ReadLine();

            switch(cevap)
            {
                case "tr":
                    Console.WriteLine("Merhaba");
                    break;
                case "en":
                    Console.WriteLine("Hello");
                    break;
                case "de":
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("Geçersiz dil.");
                    break;


            }
        }

        private static void switchusing()
        {
            //çok eşitlik olduğunda switch kullanılır
            ConsoleColor renk = Console.BackgroundColor;
            switch(renk)
            {
                case ConsoleColor.Black:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case ConsoleColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                        
            }
        }
    }
}
