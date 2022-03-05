using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonetskaAbeceda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] abecedaNATO = new string[] {
            "Alfa","Bravo","Charlie","Delta","Echo","Foxtrot","Golf","Hotel","India","Juliett","Kilo","Lima","Mike","November",
            "Oscar","Papa","Quebec","Romeo","Sierra","Tango","Uniform","Victor","Whiskey","Xray","Yankee","Zulu"
            };

            Console.WriteLine("Enter a word: ");
            string userInput = Console.ReadLine();
            char[] inputArray = userInput.ToArray();
            string solution = "";
            int notfoundCount = 0;

            foreach(char wordInput in inputArray)
            {
                foreach(string wordNATO in abecedaNATO)
                {
                    if (!wordNATO.StartsWith(wordInput.ToString()))
                    {
                        notfoundCount++;
                    }
                    else
                    {
                        solution = solution + wordNATO + " ";
                    }
                }
                if (notfoundCount == abecedaNATO.Length)
                {
                    Console.WriteLine("Wrong input!");
                    Console.Read();
                    return;
                }
            }
            Console.WriteLine("Your word in phonetic alphabet looks like this: "+solution);    
            Console.ReadLine(); 
        }
    }
}
