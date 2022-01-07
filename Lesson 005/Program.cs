using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005
{
    class Program
    {
        //Console sınıfının title elemanını değiştirin
        //Console sınıfının CursorSize elemanını değiştirinü
        //Console sınıfının BackgroundColor elemanını değiştirin
        static void Main(string[] args)
        {
            Console.Title = "SSS";
            Console.BackgroundColor = ConsoleColor.Red; //sadece yazının arkaplanı rengi
            Console.CursorSize = 60; //Yazı büyüklüğü
            Console.CursorLeft = 30; //Sol taraftan bırakılan boşluk
            Console.CursorTop = 30;//üstten bırakılan boşluk
            Console.WriteLine("Deneme");
            Console.ReadLine();

        }
    }
}
