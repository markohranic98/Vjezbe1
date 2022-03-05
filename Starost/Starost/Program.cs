using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godina, mjesec;
            Console.Write("Godina: ");
            godina = int.Parse(Console.ReadLine());
            Console.Write("Mjesec: ");
            mjesec = int.Parse(Console.ReadLine());
            int currentMonth = int.Parse(DateTime.Now.Month.ToString());
            int currentYear = int.Parse(DateTime.Now.Year.ToString());

            int yearDiff = currentYear - godina; // 2. mjesec 2020 = 23 mjeseca
            int monthDiff = currentMonth - mjesec; //
            int rezultat = yearDiff * 12 - monthDiff;
            Console.WriteLine(rezultat + " mjeseci");
            Console.WriteLine(rezultat * 30 + " dana");
            Console.ReadLine();

        }
    }
}
