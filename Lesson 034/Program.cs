using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_034
{
    class Program
    {
        // Mezuniyet tarihi ile bugün arasındaki gün farkı
        // şu andan gece 11'e kadar ki süre
        static void Main(string[] args)
        {
            Gecensure();
            cıkısanekadarvar();
            Console.ReadLine();
        }

        private static void cıkısanekadarvar()
        {
            var simdi = DateTime.Now;
            var cıkıs = Convert.ToDateTime("2022-1-12 23:00:00");
            var cıkıs2 = new DateTime(2022, 12, 02, 23, 0, 0); //cıkıs2 ve cıkıs aynı anlama gelir
            TimeSpan sure = cıkıs - simdi;
            Console.WriteLine("Toplam " + sure.TotalMinutes + " dk");
            Console.WriteLine("Çıkışa " + sure.Hours + " saat " + sure.Minutes + " dk kaldı");

        }

        private static void Gecensure()
        {
            DateTime mezuniyet = new DateTime(2021, 5, 6);
            TimeSpan gecensüre = DateTime.Today-mezuniyet; // Geçen süreyi hesaplayan kod
            Console.WriteLine("Mezuniyetten bugüne kadar geçen toplam süre "+gecensüre);
            Console.WriteLine("Mezuniyetten bugüne "+gecensüre.TotalDays + " gün geçti"); // Totaldays kodu belirtilen sürede kaç gün olduğunu hesaplar

        }
    }
}
