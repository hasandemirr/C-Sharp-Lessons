using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_026
{
    class Program
    {
        // vize ve final notlarına göre dersten geçeni belirleyen kod
        static void Main(string[] args)
        {
            Kabus();
            Console.ReadLine();
        }

        private static void Kabus()
        {
            Console.WriteLine("Vize notunuz kaç?");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunuz kaç?");
            double final = Convert.ToDouble(Console.ReadLine());
            vize = vize * 0.4;
            final = final * 0.6;
            double ortalama = vize + final;

            string sonuc = ortalama >= 50 ? "Geçtiniz" : ortalama < 50 ? "Kaldınız" : "";
            Console.WriteLine(sonuc);

        }
    }
}
