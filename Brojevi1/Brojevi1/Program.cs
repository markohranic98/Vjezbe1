using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;
            do
            {
                Console.WriteLine("Unesite broj jedinica: ");
                int brojJedinica = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite broj desetica: ");
                int brojDesetica = int.Parse(Console.ReadLine());
                broj = brojJedinica + brojDesetica * 10;
                if(broj < 1 && broj > 99)
                {
                    Console.WriteLine("Krivi unos!");
                }
            } while (broj<1 && broj>99);
            Console.WriteLine("Rezultat: " +(broj * 2.1));
            Console.ReadLine();
        }
    }
}
