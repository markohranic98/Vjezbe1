using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovcanaNaknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime zaposlenika:");
            string imeZaposlenika = Console.ReadLine();

            string[] data = new string[]
            {
                "Ivan Ivic;8NS",
                "Ivan Ivic;6DS",
                "Ivan Ivic;4DS",
                "Ivan Ivic;4P",
                "Pero Peric;3NS",
                "Pero Peric;5DS",
                "Pero Peric;7DS",
                "Pero Peric;4DS",
                "Pero Peric;3P"
            };

            float cijenaSata = 150;
            const float koefNS = 1.5f;
            const float koefP = 2f;
            float rezultat = 0;
            int brojSati = 0;
            string tipSmjene = "";

            foreach(string entry in data)
            {
                string[] trenutniZapis = entry.Split(';');
                if(trenutniZapis[0].Contains(imeZaposlenika))
                {
                    tipSmjene = trenutniZapis[1].Substring(1);
                    brojSati = int.Parse(trenutniZapis[1].Substring(0,1));

                    if(tipSmjene.Contains('P'))
                    {
                        rezultat += brojSati * koefP * cijenaSata;
                    }
                    else if (tipSmjene.Contains("NS"))
                    {
                        rezultat += brojSati * koefNS * cijenaSata;
                    }
                    else if (tipSmjene.Contains("DS"))
                    {
                        rezultat += brojSati * 1 * cijenaSata;
                    }
                }
                
            }

            Console.WriteLine("Zaposleniku " + imeZaposlenika + " treba isplatiti ukupno " + rezultat + " kuna!");
            Console.Read();
        }
    }
}
