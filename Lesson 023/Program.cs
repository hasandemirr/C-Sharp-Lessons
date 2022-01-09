using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_023
{
    class Program
    {
        // ikizler burcu olup olmadığını kontrol eden kod
        static void Main(string[] args)
        {
            burc();
            Console.ReadLine();
        }

        private static void burc()
        {
            Console.WriteLine("Kaçıncı ayda doğdunuz? (0-12)");
            int cevap1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(+cevap1+". Ayın kaçında doğdunuz?");
            int cevap2 = Convert.ToInt32(Console.ReadLine());
            if((cevap1>=5 && cevap2>=22) || (cevap1<=6 && cevap2<=22))
            {
                Console.WriteLine("Malesef ikizler burcusunuz.");
            }
            else
            {
                Console.WriteLine("Ne mutlu ki size ikizler burcu değilsiniz.");
            }
        }
    }
}
