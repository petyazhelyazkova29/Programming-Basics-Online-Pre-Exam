using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaVacantions = int.Parse(Console.ReadLine());
            int mountainVacantions = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int profit = 0;
            while (input!= "Stop")
            {
                if (input== "sea")
                {
                    if (seaVacantions>0)
                    {
                        profit += 680;
                        seaVacantions--;
                    }                                      
                }
                else if (input== "mountain")
                {
                    if (mountainVacantions>0)
                    {
                        profit += 499;
                        mountainVacantions--;
                    }                                    
                }

                if (seaVacantions==0 && mountainVacantions==0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (seaVacantions == 0 && mountainVacantions == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
