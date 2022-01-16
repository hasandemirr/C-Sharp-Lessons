using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_065
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager can = new CustomerManager(20);
            can.List();
            Product boz = new Product { Id = 1, Name = "Computer" };
            Product urun = new Product(2, "Laptop");
            urun.hoba();
            EmployeeManager hasan = new EmployeeManager(new DatabaseLogger());            
            hasan.Add();
            PersonManager furkan = new PersonManager("Adana");
            furkan.Addd();

            Manager.DoSomething();
            Manager Turgay = new Manager();
            Turgay.DoSomething2();
            Teacher.Number = 15;

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 10;
        public CustomerManager(int a)
        {
            _count = a;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        private int _id;
        private string _name;

        public Product(int id, string isim)
        {
            _id = id + 5;
            _name = isim + " ürünü";
        }
        public void hoba()
        {
            Console.WriteLine(_id + " " + _name);
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger demir)
        {
            _logger= demir;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class Baseclass
    {
        private string _entity;
        public Baseclass(string furkan)
        {
            _entity = furkan;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonManager:Baseclass
    {
        public PersonManager(string wow):base(wow)
        {

        }
        public void Addd()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }

    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("done 2");
        }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
    }
}
