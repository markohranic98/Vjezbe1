using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureZraka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string glavni = "13,2|13,6|-|14,8|15,1|-|14,2|13,7";
            string rezervni = "286,45|286,85|287,25|288,05|288,35|287,95|287,45|286,95";
            double temperatura = 0;
            string[] splitRezervni = rezervni.Split('|');
            string[] splitGlavni = glavni.Split('|');
            int brojac = 0;
            double average= 0;
            Console.WriteLine("U proteklih 24 sata su izmjerene sljedece temperature: ");
            foreach (string entry in splitGlavni)
            {
                
                if (entry != "-")
                {
                    temperatura = double.Parse(entry);
                    Console.WriteLine(temperatura + " stupnjeva C");
                }
                else
                {
                    temperatura = double.Parse(splitRezervni[brojac]) -273.15;
                    Console.WriteLine(temperatura + " stupnjeva C");
                }
                average += temperatura;
                brojac++;
            }
            Console.WriteLine("Prosjecna izmjerena temperatura je " + Math.Round((average/brojac),1));
            Console.ReadLine();
        }
    }
}
