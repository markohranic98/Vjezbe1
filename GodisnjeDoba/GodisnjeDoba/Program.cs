using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodisnjeDoba
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljan datum u formatu 'dd mmmm' (npr. 20 siječanj):");
            string[] userInput = Console.ReadLine().Split(' ');
            int day = int.Parse(userInput[0]);
            string month = userInput[1];
            int monthNumber = 0;
            string[] monthArray = new string[] {
            "siječanj","veljača","ožujak","travanj","svibanj","lipanj","srpanj","kolovoz","rujan","listopad","studeni","prosinac"
            };

            for(int i = 0; i < monthArray.Length; i++)
            {
                if(monthArray[i] == month)
                {
                    monthNumber = i+1;
                }
            }
            
            if((monthNumber >3 && monthNumber<6)  || (monthNumber==3 && day>20) || (monthNumber==6 && day < 21))
            {
                Console.WriteLine("Proljeće");
            }
            if (monthNumber > 6 && monthNumber < 9 || (monthNumber == 6 && day > 20) || (monthNumber == 9 && day < 23))
            {
                Console.WriteLine("Ljeto");
            }
            if (monthNumber > 9 && monthNumber < 12 || (monthNumber == 9 && day > 22) || (monthNumber == 12 && day < 21))
            {
                Console.WriteLine("Jesen");
            }
            if (monthNumber > 12 && monthNumber < 3 || (monthNumber == 12 && day > 20) || (monthNumber == 3 && day < 21))
            {
                Console.WriteLine("Zima");
            }
            Console.ReadLine();
        }
    }
}
