using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_072
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sehirler = new ArrayList(); 
            //Arraylist'te dizilerin aksine sınır yoktur ekleme yaptığınızda bir öncekini silmez
            //Arraylist'te sadece string ya da integer zorunluluğu yoktur.
            sehirler.Add("Mersin");
            sehirler.Add("Bursa");
            sehirler.Add(1);
            foreach (var heddas in sehirler)
            {
                Console.WriteLine(heddas);
            }

            // Tip korumalı koleksiyonlar için List<tip> şeklinde kullanılır
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("istanbul");
            foreach (var wowow in cities)
            {
                Console.WriteLine(wowow);
            }
            List<Customer> mevlana = new List<Customer>();
            mevlana.Add(new Customer { Id = 1, Firstname = "Igor" });
            mevlana.Add(new Customer { Id = 2, Firstname = "Rassamahe" });
            var customer2 = new Customer()            
            {
                Id = 5,
                Firstname = "Mr.fantastik",
            };
            mevlana.Add(customer2);
            mevlana.AddRange(new Customer[2] // çoklu eklemeler için AddRange komutu kullanılır
            { 
                new Customer{Id=8, Firstname="Enes Batur"},
                new Customer{Id=4,Firstname="Youtube Budur"}
            });
            Console.WriteLine(mevlana.Contains(customer2));
            // contains içerir mi anlamına gelir doğruysa true geri döndürür.
            // mevlana.clear işlemi koleksiyonu temizler
            var index = mevlana.IndexOf(customer2);
            Console.WriteLine("Index: {0}",index);
            mevlana.Remove(customer2);
            // customer 2 yi kaldırır

            foreach (var abababab in mevlana)
            {
                Console.WriteLine(abababab.Firstname+" "+abababab.Id);
            }

            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
    }
}
