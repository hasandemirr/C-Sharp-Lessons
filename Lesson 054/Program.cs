using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_054
{
    class Program
    {
        // Kullanıcının girmiş olduğu 05559998877 şeklindeki numarayı 0555 999 88 77 şeklinde çeviren kod
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();

        }

        private static void Ornek()
        {
            Console.WriteLine("Telefon numarısını giriniz.");
            string tlf = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < tlf.Length; i++)
            {
                if(i==4||i==7||i==9)
                {
                    Console.Write(" ");
                }
                Console.Write(tlf[i]);
            }


        }
    }
}
