using System;
using System.Diagnostics.CodeAnalysis;

namespace _06._Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNum = number / 100;
            int thurdNum = number % 10;
            int secondNum = (number / 10) % 10;
            // abc
            for (int a = 1; a <= thurdNum; a++)
            {
                for (int b = 1; b <= secondNum; b++)
                {
                    for (int c = 1; c <= firstNum; c++)
                    {
                        int sum = a * b * c;
                        Console.WriteLine($"{a} * {b} * {c} = {sum};");
                    }
                }
            }
        }
    }
}
