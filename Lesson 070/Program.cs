using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_070
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer hasan = new SqlServer();
            hasan.Add();
            MySql heddas = new MySql();
            heddas.Add();
            hasan.Delete();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public override void Delete()
        {
            Console.WriteLine("Silindi");
        }
    }
    class MySql:Database
    {

    }
}
