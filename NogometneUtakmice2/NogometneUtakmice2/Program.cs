using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometneUtakmice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rezultati = new string[]
            {
                "ARG 1:1 ISL",
                "HRV 2:0 NIG",
                "ARG 0:3 HRV",
                "NIG 2:0 ISL",
                "NIG 1:2 ARG",
                "ISL 1:2 HRV"
            };

            Console.WriteLine("TABLICA REZULTATA");
            Console.WriteLine("Upišite oznaku reprezentacije (HRV, ARG, NIG ili ISL).");
            string drzava = Console.ReadLine();
            Console.WriteLine("Utakmice reprezentacije: " + drzava);

            for(int i = 0; i < rezultati.Length; i++)
            {
                string[] rasclanjenRezultat = rezultati[i].Split(' ');
                if(rasclanjenRezultat[0] == drzava)
                {
                    Console.WriteLine(rezultati[i]);
                }
                else if(rasclanjenRezultat[2] == drzava)
                {
                    EditString(rasclanjenRezultat);
                }
            }
            Console.ReadLine();
        }
        static void EditString(string[] rasclanjenRezultat)
        {
            string invertedMiddlePart = string.Empty;
            for(int i = rasclanjenRezultat[1].Length - 1; i >= 0; i--)
            {
                invertedMiddlePart += rasclanjenRezultat[1][i];
            }

            string editedString = rasclanjenRezultat[2] + " " + invertedMiddlePart + " " + rasclanjenRezultat[0];
            Console.WriteLine(editedString);
            return;
        }
    }
}
