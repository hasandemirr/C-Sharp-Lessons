using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_068
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] Hasan = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var Antep in Hasan)
            {
                Antep.Work();
            }

            IEat[] Duygu = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var Gonya in Duygu)
            {
                Gonya.Eat();
            }

            ISalary[] Heddas = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var Osmnaniye in Heddas)
            {
                Osmnaniye.GetSalary();
            }

            Console.ReadLine();

        }
    }
    interface IWorker
    {
        void Work();              
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Afiyet Olsun");
        }

        public void GetSalary()
        {
            Console.WriteLine("3 kuruşa 5 köfte yok");
        }

        public void Work()
        {
            Console.WriteLine("Az laf çok iş!!!");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Afiyet Olsun");
        }

        public void GetSalary()
        {
            Console.WriteLine("3 kuruşa 5 köfte yok");
        }

        public void Work()
        {
            Console.WriteLine("Az laf çok iş!!!");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Az laf çok iş!!!");
        }
    }
}
