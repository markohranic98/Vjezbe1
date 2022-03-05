using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrijemeUGradu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] grad = new string[]
            {
                "Santiago","Salvador","London","Zagreb","Damask","Istanbul"
            };
            string[] zona = new string[]
            {
                "UTC-4","UTC-3","UTC-0","UTC+1","UTC+2","UTC+3"
            };
            Console.WriteLine("Unesite naziv grada: ");
            string gradInput = Console.ReadLine();
            int addHour = 0;
            for(int i = 0; i < grad.Length; i++)
            {
                if(grad[i] == gradInput)
                {
                    addHour = int.Parse(zona[i].Substring(3));
                    Console.WriteLine("Trenutno vrijeme u gradu " + grad[i] + " je: " + (DateTime.UtcNow.AddHours(addHour).ToShortTimeString()));
                }
            }
            Console.ReadLine();
        }
    }
}
