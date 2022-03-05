using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite iznos KUNA(cijeli broj) koji želite promijeniti(u tekstualnom obliku)");

            string[] brojevi = new string[]{
                "nula","jedan","dva","tri","četiri","pet","šest","sedam","osam","devet"
            };
            string[] unos = Console.ReadLine().Split(' ');
            int[] unosIntConvert = new int[unos.Length];
            int brojac = 0;
            string finalBroj ="";
            foreach (string rijec in unos)
            {
                for(int i = 0;i < brojevi.Length;i++)
                {
                    if (brojevi[i] == rijec) 
                    { 
                        unosIntConvert[brojac] = i; 
                    }
                    
                }
                brojac++;
            }   
            
            for(int i = 0; i <unosIntConvert.Length;i++)
            {
                finalBroj = finalBroj + unosIntConvert[i];
            }
            int rjesenje = int.Parse(finalBroj);

            Console.WriteLine("Unesite tečaj EUR ( u brojčanom decimalnom obliku");
            float tecajEUR = float.Parse(Console.ReadLine());

            Console.WriteLine(rjesenje + " KN po tečaju " + tecajEUR + " iznosi " + (rjesenje / tecajEUR));
            Console.ReadLine();
        }
    }
}
