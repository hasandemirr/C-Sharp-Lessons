using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_041
{
    class Program
    {
        // kişi başı kaç gram kuruyemiş düşeceğini hesaplayan kod
        static void Main(string[] args)
        {
            ornek();
            Console.ReadLine();
        }

        private static void ornek()
        {
            try
            {
                Console.WriteLine("500 gram kuruyemişi kaç kişi yiyeceksiniz?");
                int kisi = Convert.ToInt32(Console.ReadLine());
                if (kisi == 0)
                    throw new DivideByZeroException();

                double gram = 500.0 / kisi;
                Console.WriteLine("Kisi başı " + gram + " gram kuruyemiş düşer.");
            }
            catch (DivideByZeroException sifirhatasi)
            {
                Console.WriteLine("Sıfır kişi mi yiyeceksiniz?");
            }
            catch (FormatException formathatasi)
            {
                Console.WriteLine("Yalnızca sayı giriniz");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata");
            }
            }

        }
    }

