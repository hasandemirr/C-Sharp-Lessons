using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_067
{
    interface IReallife
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : IReallife
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleServerCustomerDal : IReallife
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class MySqlServerCustomerDal : IReallife
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    class CustomerManager
    {
        public void Add(IReallife hasan)
        {
            hasan.Add();
        }
    }
}
