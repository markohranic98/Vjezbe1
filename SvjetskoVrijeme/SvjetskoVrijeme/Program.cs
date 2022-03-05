using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvjetskoVrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[]
            {
                "Santiago;-4",
                "Salvador;-3",
                "London;+0",
                "Zagreb;+1",
                "Damask;+2",
                "Istanbul;+3"
            };

            foreach (string zapis in data)
            {
                string[] orgData = zapis.Split(';');
                string townName = orgData[0];
                int timeDiff = int.Parse(orgData[1]);

                Console.WriteLine("Trenutno vrijeme za "+townName+" je: " + (DateTime.UtcNow.AddHours(timeDiff).ToShortTimeString()));
            }
            Console.Read();
        }
    }
}
