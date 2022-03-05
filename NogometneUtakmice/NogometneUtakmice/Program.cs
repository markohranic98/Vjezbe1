using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometneUtakmice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rezultati = new string[]
            {
                "HRV 2:0 NIG",
                "HRV 3:0 ARG",
                "HRV 2:1 ISL",
                "HRV 1:1 DAN",
                "HRV 2:2 RUS",
                "HRV 2:1 ENG",
                "HRV 2:4 FRA"
            };
            int pobjeda = 0;
            int poraz = 0;
            int remi = 0;
            foreach(string rezultat in rezultati)
            {
                string[] trenutniRezultat = rezultat.Split(' ');
                string[] brojevi = trenutniRezultat[1].Split(':');
                
                if(brojevi[0]== brojevi[1])
                {
                    remi++;
                }
                else if(int.Parse(brojevi[0]) > int.Parse(brojevi[1]))
                {
                    pobjeda++;
                }
                else if (int.Parse(brojevi[0]) < int.Parse(brojevi[1]))
                {
                    poraz++;
                }


            }

            Console.WriteLine("Ukupno ostvarenih pobjeda: " + pobjeda);
            Console.WriteLine("Ukupno ostvarenih poraza: "+ poraz);
            Console.WriteLine("Ukupno ostvarenih remija: "+remi);
            Console.Read();
        }
    }
}
