using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_006
{
    class Program
    {
        // Console sınıfının Readline metodundan dönen değeri değişkene atayın
        // Convert sınıfının ToInt32 metoduna bu değişkeni parametre olarak gönderin 
        // Bu ifadeyi başka bir değişkene atayın
        static void Main(string[] args)
        {
            var sss = Console.ReadLine();
            int zzz = Convert.ToInt32(sss);
            Console.WriteLine(sss);
            Console.ReadLine();
        }
    }
}
