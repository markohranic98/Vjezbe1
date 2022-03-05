using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusKnjigeUKnjiznici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> data = new List<string>
            {
                "Prstenova druzina;Dostupna",
                "Dvije kule;Dostupna",
                "Povratak kralja;Na posudbi",
                "Rat i mir;Dostupna",
                "Zlocin i kazna;Na posudbi",
                "Jadnici;Dostupna"
            };
            string naredba = "";
            do
            {
                Console.WriteLine("Unesite naredbu:");
                naredba = Console.ReadLine();
          
                
                switch (naredba)
                {
                    case string a when a.Contains("#status "):
                        string inputBookName = a.Substring(8);
                        int found = 0;
                        foreach(string s in data)
                        {
                            string[] splitData = s.Split(';');
                            if (splitData[0] == inputBookName && splitData[1] == "Dostupna")
                            {
                                found++;
                                Console.WriteLine("Knjiga " + inputBookName + " je dostupna za posudbu!");
                            }
                            else if (splitData[0] == inputBookName && splitData[1] == "Na posudbi")
                            {
                                found++;
                                Console.WriteLine("Knjiga " + inputBookName + " je vec posudena!");
                            }
                    
                        }
                        if (found==0)
                        {
                            Console.WriteLine("Ne postoji ta knjiga u knjiznici");
                        }
                        found = 0;
                        Console.WriteLine();
                        break;
                    case string b when b == "#exit":
                        break;
                    default:
                        Console.WriteLine("Kriva naredba, postoje #exit i #status");
                        break;
                }

            } while (naredba != "#exit");

            Console.Read();
        }
    }
}
