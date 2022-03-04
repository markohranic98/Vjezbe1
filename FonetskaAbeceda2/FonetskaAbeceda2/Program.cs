using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonetskaAbeceda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] abecedaNATO = new string[] {
            "Alfa","Bravo","Charlie","Delta","Echo","Foxtrot","Golf","Hotel","India","Juliett","Kilo","Lima","Mike","November",
            "Oscar","Papa","Quebec","Romeo","Sierra","Tango","Uniform","Victor","Whiskey","Xray","Yankee","Zulu"
            };

            Console.WriteLine("Enter a word using phonetic alphabet: ");
            string userInput = Console.ReadLine();
       
            string[] userInputSplit = userInput.Split(' ');
            string finalWord = "";

            foreach  (string word in userInputSplit)
            {
                if (!abecedaNATO.Contains(word))
                {
                    Console.WriteLine("Your entry was invalid!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    finalWord = finalWord + word.Substring(0, 1);
                }  
            }

            if(finalWord.Length > 0)
            {
                Console.WriteLine("You wrote '"+finalWord+"' !");
            }
            Console.ReadLine();
        }
    }
}
