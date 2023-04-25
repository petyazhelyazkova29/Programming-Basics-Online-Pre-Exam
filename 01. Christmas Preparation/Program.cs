using System;

namespace _01._Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int fabric = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = paper * 5.80 + fabric * 7.20 + glue * 1.20;
            sum -= sum * discount/100;
            Console.WriteLine($"{sum:f3}");
        }
    }
}
