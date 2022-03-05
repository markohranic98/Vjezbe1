using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzbornikISortiranje
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int menuChoice = 0;
            List<string> townList = new List<string>();
            do
            {
                
                Console.Clear();
                Console.WriteLine("1. Unos podataka");
                Console.WriteLine("2. Sortiranje");
                Console.WriteLine("3. Ispis");
                Console.WriteLine("4. Izlaz");
               
                int sortMode = 0;
                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        DataEntry(townList);
                        Console.WriteLine(townList);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Press 1 if you want to sort ascending, 2 for descending");
                        sortMode = int.Parse(Console.ReadLine());
                        SortTowns(townList, sortMode);
                        break;
                    case 3:
                        Output(townList);
                        break;
                    case 4: 
                        Console.WriteLine("Izlaz iz programa");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }

            }while(menuChoice != 4);
        }

         static void DataEntry(List<string> townList)
        {
            Console.Clear();
          
            Console.WriteLine("How many towns do you want to enter: ");
            int numberOfEntry = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfEntry; i++)
            {
                townList.Add(Console.ReadLine());
            }
            return;
        }
        
        static  void SortTowns(List<string> townList, int sortMode)
        {
            if(sortMode == 1)
            {
                townList.Sort();
            }
            else if (sortMode == 2)
            {
                townList.Sort();
                townList.Reverse();
            }
            else
            {
                Console.WriteLine("Something went wrong, check your sort option");
            }
            return;
        }

        static void Output(List<string> townList)
        {
        
            for(int i = 0; i < townList.Count; i++)
            {
                Console.WriteLine(townList[i]);
            }

            Console.WriteLine("Press anything to proceed");
            Console.ReadLine();
            return;
        }
    }
}
