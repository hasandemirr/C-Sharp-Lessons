using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_067
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager musteriyoneticisi = new CustomerManager();
            musteriyoneticisi.Add(new SqlServerCustomerDal());

            IReallife[] yeni = new IReallife[3] // Veriyi tüm klasslara girebilmek için dizi oluştururuz.
            {
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var adana in yeni)
            {
                adana.Add();
                adana.Update();
                adana.Delete();
            }

            Console.ReadLine();
        }
    }
}
