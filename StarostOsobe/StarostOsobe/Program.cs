using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarostOsobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mjesecData = new string[]
            {
                "siječanj","veljača","ožujak","travanj","svibanj","lipanj","srpanj","kolovoz","rujan","listopad","studeni","prosinac"
            };
            Console.WriteLine("IZRAČUN STAROSTI OSOBE: ");
            Console.WriteLine("Unesite datum rođenja u formatu dd mmmmmm yyyy npr. 20 siječanj 1995");
            string userInptu = Console.ReadLine();
            DateTime dt;
            string currentYear = DateTime.Now.Year.ToString();
            string currentDay = DateTime.Now.Day.ToString();
            string currentMonth = DateTime.Now.Month.ToString();
            string currentDate = DateTime.Now.ToShortDateString();
            string[] splitInput = userInptu.Split(' ');
            int day = int.Parse(splitInput[0]);
            int initialYear = int.Parse(splitInput[2]);
            int mjesec = 0;
            for(int i = 0; i < mjesecData.Length; i++)
            {
                if(mjesecData[i] == splitInput[1])
                {
                    mjesec = i + 1;
                }
            }
            if(int.Parse(currentMonth) < mjesec || (int.Parse(currentMonth) == mjesec && int.Parse(currentDay) < day))
            {
                Console.WriteLine("Dana " + day + "." + mjesec + "." + currentYear + " ćete napuniti " + (int.Parse(currentYear) - initialYear) + " godina");
            }
            else if (int.Parse(currentMonth) >= mjesec || (int.Parse(currentMonth) == mjesec && int.Parse(currentDay) <= day))
            {
                Console.WriteLine("Dana " + day + "." + mjesec + "." + currentYear + " ste napunili " + (int.Parse(currentYear) - initialYear) + " godina");
            }
            //Console.WriteLine(int.Parse(currentYear) - initialYear);
            //Console.WriteLine(mjesec);
            Console.ReadLine();
            
        }
    }
}
