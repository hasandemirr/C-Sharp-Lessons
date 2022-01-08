using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_014
{
    class Program
    {
        /* bir bool değişkene şu ifadeyi atayalım
         * Directory sınıfının Exists metoduna "test parametresini gönderelim" */
        static void Main(string[] args)
        {
            bool varmı = Directory.Exists("test");
            Console.ReadLine();
        }
    }
}
