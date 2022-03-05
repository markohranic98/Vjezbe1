using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureZraka2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";
            string[] splitMeteoStanica = meteoStanica.Split('|');
            int brojac = 1;
            foreach (string zapis in splitMeteoStanica)
            {
                if (zapis == "-")
                {
                    Console.WriteLine((brojac++) + ". ocitanje nije uspjelo ");
                }
                else
                {
                    string[] ocitanje = zapis.Split(';');
                    string mjernaJedinica = ocitanje[1];
                    double temperatura = double.Parse(ocitanje[0]);
                    if (mjernaJedinica == "K")
                    {
                        temperatura -= 273.15;
                    }
                    Console.WriteLine((brojac++) + ". ocitanje = " + temperatura + " stupanj C");
                }
            }
            Console.ReadLine();
        }
    }
}
