using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double Y = double.Parse(Console.ReadLine());
            double rezultat = 1;

            if (Y >= 0)
            {
                for(int i = 0; i < Y; i++)
                {
                    rezultat = rezultat * X;
                    if (i < Y - 1)
                    {
                        Console.Write(X + " * ");
                    }
                    else
                    {
                        Console.Write(X + " = " + rezultat);
                    }
                }
            }
            else if (Y < 0)
            {
                X = 1 / X;
                Y = Y * (-1);
                for (int i = 0; i < Y; i++)
                {
                    rezultat = rezultat * X;
                    if (i < Y - 1)
                    {
                        Console.Write(X + " * ");
                    }
                    else
                    {
                        Console.Write(X + " = " + rezultat);
                    }
                }
            }


            Console.WriteLine();
            Console.Read();    
        }
    }
}
