using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_040
{
    class Program
    {
        // Hata fırlatma örneği
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("1-3 arasında bir sayı giriniz");
            string sayi = Console.ReadLine();
            switch(sayi)
            {
                case "1":
                    throw new Exception("Beğenmedim");
                    break;
                case "2":
                    throw new Exception("Başka sayı bulamadın mı");
                    break;
                case "3":
                    throw new Exception("Bu ne biçim bir sayı");
                    break;
            }
        }
    }
}
