using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            int suma = 0;
            var rezultat = new List<int>();
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());
            Console.Write("C = ");
            C = int.Parse(Console.ReadLine());

            // swap
            if (B<A)
            {
                A = A + B;
                B = A - B;
                A = A - B;
            }

            for(int i = A; i <= B; i++)
            {
                if (i % C == 0)
                {
                    rezultat.Add(i);
                }
            }
            
            if(rezultat.Count != 0)
            {
                Console.Write("Rezultat je: ");
                foreach (int broj in rezultat)
                {
                    Console.Write(broj + " ");
                    suma += broj;
                }
                Console.WriteLine();  
                Console.WriteLine("Suma je: " + suma);
            } 
            else
            {
                Console.WriteLine("Nema brojeva između "+A+" i "+B+" koji su dijeljivi sa "+C);
            }
            Console.ReadLine();
        }
    }
}
