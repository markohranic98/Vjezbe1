using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi godinu rođenja: ");
            int prezivjelePrijestupneGodine = 0;  
            int godina = int.Parse(Console.ReadLine());
            int trenutnaGodina = System.DateTime.Today.Year;
            int starostKorisnika = trenutnaGodina-godina;
            for (int i = godina;i<=trenutnaGodina;i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    prezivjelePrijestupneGodine++;
                }
            }
            Console.WriteLine("Broj prezivjelih prijestupnih godina: "+prezivjelePrijestupneGodine);
            Console.WriteLine("Starost korisnika: "+starostKorisnika);
            Console.ReadLine();
        }
    }
}
