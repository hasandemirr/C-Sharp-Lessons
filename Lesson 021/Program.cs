using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_021
{
    class Program
    {
        // Kullanıcının alanını ve iş durumuna uygun yönlendirme yapan kod
        static void Main(string[] args)
        {
            alan();
            Console.ReadLine();
        }

        private static void alan()
        {
            /*
            Console.WriteLine("Şu an çalışıyor musunuz? (e/h)");
            string cevap1 = Console.ReadLine();
            Console.WriteLine("Sayısal bölüm mezunu musunuz? (e/h)");
            string cevap2 = Console.ReadLine();
            if(cevap1=="h" && cevap2=="e")
            {
                Console.WriteLine("Mt programına başvurabilirsiniz");
            }
            else
            {
                Console.WriteLine("Kolay gelsin");
            }
            */

            Console.WriteLine("Şu an çalışıyor musunuz? (e/h)");
            bool calisiyorMu = Console.ReadLine() == "e";
            Console.WriteLine("Sayısal bölüm mezunu musunuz? (e/h)");            
            bool sayisalmi = Console.ReadLine() == "e";
            if(!calisiyorMu && !sayisalmi) // !calisiyormu = h ise ve sayisalmi = e ise ancak if in içine girecek 
            {
                Console.WriteLine("Mt programına başvurabilirsiniz");
            }
            else
            {
                Console.WriteLine("Geçersiz kriter.");
            }

        }
    }
}
