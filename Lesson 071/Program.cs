using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_071
{
    class Program
    {
        static void Main(string[] args)
        {
            Database Hasan = new Oracle();
            Hasan.Add();
            Hasan.Delete();
            Database Heddas = new SqlServer();
            Heddas.Add();
            Heddas.Delete();
            Console.ReadLine();
        }
    }

    abstract class Database // Abstract classlar new'lenmez
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); 
        // Abstract class içerisinde abstract class kullnıldığında boş olmalı ve override zorunludur.

    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
