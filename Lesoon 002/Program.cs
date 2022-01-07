using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesoon_002
{
    class Program
    {
        //Kullanıcıya nasılsın diye sorun
        //Kullanıcının cevabını iletin.
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba ,"); //writeline bir satır aşağı atlar
            Console.Write("Bugün Nasılsın? ");
            var hal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ben de "+hal);         
            Console.ReadLine(); //Console'u açmak için readline kullanılır
        }
    }
}
