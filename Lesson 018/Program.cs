using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_018
{
    class Program
    {
        /* Kullanıcıdan kare ya da daire için parametreleri aldıktan sonra alanı hesaplayan kod */
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            Console.WriteLine("Kare mi, Daire mi?");
            string cevap = Console.ReadLine();
            if(cevap=="kare"||cevap=="Kare")
            {
                Console.WriteLine("Kenar uzunluğunu giriniz.");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Karenin alanı = " + a * a);
            }
            else if(cevap=="Daire"||cevap=="daire")
            {
                Console.WriteLine("Yarıçap uzunluğunu giriniz.");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dairenin alanı = " + Math.PI * Math.Pow(r , 2));
                //Math.PI Pi'yi çağırır
                //Math.Pow (r,2), r^2 işlemini yapar
            }
            else
            {
                Console.WriteLine("Geçersiz Şekil!");
            }

        }
    }
}
