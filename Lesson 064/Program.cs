using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_064
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager can = new CustomerManager();
            can.add();
            can.update();
            ProductManager boz = new ProductManager();
            boz.add();
            boz.update();

            Customer hakan = new Customer();
            hakan.City = "Ankara";
            hakan.Id = 2;
            hakan.FirstName = "hakan";
            hakan.LastName = "tasdelen";

            Customer hasan = new Customer()
            {
                Id=1,City="Ankara",FirstName="Hasan",LastName="Demir" 
            };

            Console.WriteLine(hasan.Id+" "+hasan.FirstName+" "+hasan.LastName+" "+hasan.City);
            Console.ReadLine();
        }
    }
}
