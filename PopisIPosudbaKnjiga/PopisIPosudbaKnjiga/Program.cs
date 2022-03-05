using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisIPosudbaKnjiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dostupneKnjige = new List<string> 
            {
            "Prstenova druzina", "Dvije kule",
            "Rat i mir", "Jadnici"
            };

            List<string> nedostupneKnjige = new List<string>
            {
            "Povratak kralja", "Zlocin i kazna"
            };

            string izbor = "";
            string tempString = "";
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "#exit":
                        break;
                    case "#popis":
                        foreach (string  knjiga in dostupneKnjige)
                        {
                            Console.WriteLine(knjiga + " Status:(dostupna)");
                        }
                        foreach (string knjiga in nedostupneKnjige)
                        {
                            Console.WriteLine(knjiga + " Status:(nedostupna)");
                        }
                        Console.WriteLine();
                        break;

                    case string a when a.Contains("#posudi "):
                        tempString = a.Substring(8);
                        
                        foreach(string knjiga in dostupneKnjige)
                        {
                            if (knjiga.Equals(tempString))
                            {
                                
                                nedostupneKnjige.Add(knjiga);
                                dostupneKnjige.Remove(knjiga);
                                Console.WriteLine("Knjiga " + tempString + " je uspjesno posuđena!");
                                Console.WriteLine();
                                break;
                            }
                        }
                        break;

                        default:
                            Console.WriteLine("Krivi unos naredbe, popis, exit i posudi su dostupni");
                            break;
                }
            } while (izbor != "#exit");
            Console.WriteLine("Kraj programa");
            Console.ReadLine();
        }
    }
}
