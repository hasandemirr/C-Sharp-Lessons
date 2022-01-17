using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_066
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer musteri = new Customer()
            {
                Id = 1,
                FirstName = "Hasan",
                LastName = "Demir",
                Adress = "Ankara",

            };

            Student duygu = new Student()
            {
                Id = 2,
                FirstName="Duygunur",
                LastName="Özdemir",
                Department="Optik",
            };

            manager.Add(duygu);
            manager.Add(musteri);
            Console.ReadLine();
        }
    }

    interface IPerson //Her interface I ile başlar
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson ogrenci)
        {
            Console.WriteLine(ogrenci.FirstName);
        }
    }

}
