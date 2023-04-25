using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine()); 
            double rateingTotal = 0;
            double sales = 0;
            double salesTotal = 0;  

            for (int i = 1; i <= computers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int rate = number % 10;
                int posibleSales = number/10;
                rateingTotal+= rate;
                if (rate==3)
                {
                    sales = posibleSales * 0.50;
                }
                else if (rate ==4)
                {
                    sales = posibleSales * 0.70;
                }
                else if (rate ==5)
                {
                    sales = posibleSales * 0.85;
                }
                else if (rate ==6)
                {
                    sales = posibleSales;
                }
                else if (rate ==2)
                {
                    sales = posibleSales * 0;
                }
                
                salesTotal+= sales;
            }
            Console.WriteLine($"{salesTotal:f2}");
            Console.WriteLine($"{rateingTotal/computers:f2}");
        }
    }
}
