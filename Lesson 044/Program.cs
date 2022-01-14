using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_044
{
    class Program
    {
        //diziyi parçalara ayır son elemanı yazdır
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();

        }

        private static void Ornek()
        {
            string tarih = "29.11.2018";
            string[] parcalar = tarih.Split('.');
            Console.WriteLine(parcalar[2]);
            int index = parcalar.Length - 3; // indexi parcalar -3 e atadık
            Console.WriteLine(parcalar[index]);

        }
    }
}
